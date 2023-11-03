using Core.Application.Responses;
using Core.Security.Enums;
using Core.Security.JWT;

namespace Application.Features.Auth.Commands.Login;

public class LoggedResponse : IResponse
{
    public AccessToken? AccessToken { get; set; }
    public Core.Security.Entities.RefreshToken? RefreshToken { get; set; }
    public AuthenticatorType? RequiredAuthenticatorType { get; set; }

    public LoggedResponse() { }

    public LoggedResponse(
        AccessToken? accessToken,
        Core.Security.Entities.RefreshToken? refreshToken,
        AuthenticatorType? requiredAuthenticatorType
    )
    {
        AccessToken = accessToken;
        RefreshToken = refreshToken;
        RequiredAuthenticatorType = requiredAuthenticatorType;
    }

    public LoggedHttpResponse ToHttpResponse() =>
        new() { AccessToken = AccessToken, RequiredAuthenticatorType = RequiredAuthenticatorType };
}
