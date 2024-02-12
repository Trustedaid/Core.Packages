using Core.Security.JWT;
using Core.Security.OTPAuthenticator;
using Core.Security.OTPAuthenticator.OtpNet;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Security;

public static class SecurityServiceRegistration
{
    public static IServiceCollection AddSecurityService(this IServiceCollection services)
    {
        services.AddScoped<ITokenHelper, JwtHelper>();
        //services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
        services.AddScoped<IOtpAuthenticatorHelper, OtpNetOtpAuthenticatorHelper>();

        return services;
    }
}