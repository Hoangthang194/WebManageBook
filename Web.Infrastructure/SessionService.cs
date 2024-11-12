using MediatR;
using Web.Domain.Login.Param.Query;
using Web.Integration.Login.Query;

namespace Web.Infrastructure
{
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMediator _mediator;
        public SessionService(IHttpContextAccessor httpContextAccessor, IMediator mediator)
        {
            _httpContextAccessor = httpContextAccessor;
            _mediator = mediator;
        }
        private ISession Session => _httpContextAccessor.HttpContext.Session;
        public async Task<bool> AuthenticateUser(string? email, string? password)
        {
            var query = new LoginQuery
            {
                UserEmail = email,
				UserPassword = password
            };
            var result = await _mediator.Send(query);
            if(result.LoginEntity != null)
            {
                _httpContextAccessor.HttpContext.Session.SetString("userId", result.LoginEntity?.UserId);

            }
            return result.LoginEntity != null ? true : false;
        }

        public string? GetSessionData(string key)
        {
            var result = Session.GetString(key);
            return result;
        }

        public void SetSessionData(string key, string value)
        {
            Session.SetString(key, value);
        }
    }

    public interface ISessionService
    {
        public Task<bool> AuthenticateUser(string? email, string? password);
        void SetSessionData(string key, string value);
        string? GetSessionData(string key);
    }
}

//abc