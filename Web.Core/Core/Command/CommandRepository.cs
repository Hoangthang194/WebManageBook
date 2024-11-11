using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Web.Domain;
using Web.Domain.Core.Command;

namespace Web.Core.Core.Command
{
    public class CommandRepository<T> : ICommandRepository<T> where T : class
    {
        private readonly IDbConnection _connection;
        private readonly IDapperContext context;

        public CommandRepository(IDapperContext context)
        {
            this.context = context;
            _connection = this.context.Connection;
        }
        public async Task<int> Add(T entity)
        {
            int rowsEffected = 0;
            try
            {
                string tableName = GetTableName();
                string columns = GetColumns(excludeKey: true);
                string properties = GetPropertyNames(excludeKey: true);
                string query = $"INSERT INTO {tableName} ({columns}) VALUES ({properties})";

                rowsEffected = await _connection.ExecuteAsync(query, entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding a record to db: ${ex.Message}");
                rowsEffected = -1;
            }
            finally
            {
                _connection.Close();
            }

            return rowsEffected;
        }

        public async Task<int> Update(T entity)
        {
            int rowsEffected = 0;
            try
            {
                string? tableName = GetTableName();
                string? keyColumn = GetKeyColumnName();
                string? keyProperty = GetKeyPropertyName();

                StringBuilder query = new StringBuilder();
                query.Append($"UPDATE {tableName} SET ");

                foreach (var property in GetProperties(true))
                {
                    var columnAttribute = property.GetCustomAttribute<ColumnAttribute>();

                    string propertyName = property.Name;
                    string columnName = columnAttribute?.Name ?? "";

                    query.Append($"{columnName} = @{propertyName},");
                }

                query.Remove(query.Length - 1, 1);
                query.Append($" WHERE {keyColumn} = @{keyProperty}");

                rowsEffected = await _connection.ExecuteAsync(query.ToString(), entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating a record in db: ${ex.Message}");
                rowsEffected = -1;
            }
            finally
            {
                _connection.Close();
            }

            return rowsEffected;
        }

        public async Task<int> Delete(T entity)
        {
            int rowsEffected = 0;
            try
            {
                string? tableName = GetTableName();
                string? keyColumn = GetKeyColumnName();
                string? keyProperty = GetKeyPropertyName();
                string query = $"DELETE FROM {tableName} WHERE {keyColumn} = @{keyProperty}";

                rowsEffected = await _connection.ExecuteAsync(query, entity);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting a record in db: ${ex.Message}");
                rowsEffected = -1;
            }
            finally
            {
                _connection.Close();
            }

            return rowsEffected;
        }

        private string GetTableName()
        {
            var type = typeof(T);
            var tableAttribute = type.GetCustomAttribute<TableAttribute>();
            if (tableAttribute != null)
                return tableAttribute.Name;

            return type.Name;
        }

        private static string? GetKeyColumnName()
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object[] keyAttributes = property.GetCustomAttributes(typeof(KeyAttribute), true);

                if (keyAttributes != null && keyAttributes.Length > 0)
                {
                    object[] columnAttributes = property.GetCustomAttributes(typeof(ColumnAttribute), true);

                    if (columnAttributes != null && columnAttributes.Length > 0)
                    {
                        ColumnAttribute columnAttribute = (ColumnAttribute)columnAttributes[0];
                        return columnAttribute?.Name ?? "";
                    }
                    else
                    {
                        return property.Name;
                    }
                }
            }

            return null;
        }


        private string GetColumns(bool excludeKey = false)
        {
            var type = typeof(T);
            var columns = string.Join(", ", type.GetProperties()
                .Where(p => !excludeKey || !p.IsDefined(typeof(KeyAttribute)))
                .Select(p =>
                {
                    var columnAttribute = p.GetCustomAttribute<ColumnAttribute>();
                    return columnAttribute != null ? columnAttribute.Name : p.Name;
                }));

            return columns;
        }

        private string GetColumnsAsProperties(bool excludeKey = false)
        {
            var type = typeof(T);
            var columnsAsProperties = string.Join(", ", type.GetProperties()
                .Where(p => !excludeKey || !p.IsDefined(typeof(KeyAttribute)))
                .Select(p =>
                {
                    var columnAttribute = p.GetCustomAttribute<ColumnAttribute>();
                    return columnAttribute != null ? $"{columnAttribute.Name} AS {p.Name}" : p.Name;
                }));

            return columnsAsProperties;
        }

        private string GetPropertyNames(bool excludeKey = false)
        {
            var properties = typeof(T).GetProperties()
                .Where(p => !excludeKey || p.GetCustomAttribute<KeyAttribute>() == null);

            var values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

            return values;
        }

        private IEnumerable<PropertyInfo> GetProperties(bool excludeKey = false)
        {
            var properties = typeof(T).GetProperties()
                .Where(p => !excludeKey || p.GetCustomAttribute<KeyAttribute>() == null);

            return properties;
        }

        private string? GetKeyPropertyName()
        {
            var properties = typeof(T).GetProperties()
                .Where(p => p.GetCustomAttribute<KeyAttribute>() != null).ToList();

            if (properties.Any())
                return properties?.FirstOrDefault()?.Name ?? null;

            return null;
        }
    }
}
