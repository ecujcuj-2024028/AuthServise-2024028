using System;
using Microsoft.Extensions.Logging;

namespace AuthServiceIN6BM.Application.Extensions;

public static partial class LoggentExtensions
{
    [LoggerMessage(
        EventId = 1001,
        Level = LogLevel.Information,
        Message= "User {username} registered successfulv"
    )]
    public static partial void LogUserRegistered (this ILogger logger, string username);
    
    
    [LoggerMessage(
        EventId = 1002,
        Level = LogLevel.Information,
        Message= "User login successfulv"
    )]
    public static partial void LogUserLoggedin (this ILogger logger);
    
    [LoggerMessage(
        EventId = 1003,
        Level = LogLevel.Warning,
        Message= "Failed login attempt"
    )]
    public static partial void LogFailedLoginAttempt(this ILogger logger);
    
    [LoggerMessage(
        EventId = 1004,
        Level = LogLevel.Warning,
        Message= "Registration rejected: email already exists"
    )]
    public static partial void LogRegitrationWithExistingEmail(this ILogger logger);
    
    [LoggerMessage(
        EventId = 1005,
        Level = LogLevel.Error,
        Message= "Erro uploading profile image"
    )]
    public static partial void LogImageUploadError(this ILogger logger);


}