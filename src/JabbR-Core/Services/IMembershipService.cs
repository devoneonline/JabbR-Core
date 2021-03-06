﻿using System.Security.Claims;
using JabbR_Core.Data.Models;

namespace JabbR_Core.Services
{
    public interface IMembershipService
    {
        // Account creation
        ChatUser AddUser(ClaimsPrincipal claimsPrincipal);
        void LinkIdentity(ChatUser user, ClaimsPrincipal principal);
        ChatUser AddUser(string userName, string email, string password);

        void ChangeUserName(ChatUser user, string newUserName);

        // Password management
        void ChangeUserPassword(ChatUser user, string oldPassword, string newPassword);
        void SetUserPassword(ChatUser user, string password);
        void RequestResetPassword(ChatUser user, int requestResetPasswordValidThroughInHours);
        void ResetUserPassword(ChatUser user, string newPassword);

        string GetUserNameFromToken(string token);

        bool TryAuthenticateUser(string userName, string password, out ChatUser user);
    }
}