namespace BioRed.Application.Security;

public interface ITokenRefreshService
{
    Task<TokenRefreshResult> RefreshAsync(
        RefreshTokenRequest request,
        string? ipAddress,
        CancellationToken cancellationToken = default);
}