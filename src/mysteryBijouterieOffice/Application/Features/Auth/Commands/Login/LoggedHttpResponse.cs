using Core.Security.Enums;
using Core.Security.JWT;

namespace Application.Features.Auth.Commands.Login;

public class LoggedHttpResponse
{
    public AccessToken? AccessToken { get; set; }
    public AuthenticatorType? RequiredAuthenticatorType { get; set; }

    public LoggedHttpResponse() { }

    public LoggedHttpResponse(AccessToken? accessToken, AuthenticatorType? requiredAuthenticatorType)
    {
        AccessToken = accessToken;
        RequiredAuthenticatorType = requiredAuthenticatorType;
    }
}
