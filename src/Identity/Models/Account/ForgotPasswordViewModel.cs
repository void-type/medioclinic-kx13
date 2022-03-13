using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Identity.Models.Account
{
    public class ForgotPasswordViewModel
    {
        public EmailViewModel EmailViewModel => new EmailViewModel();

        [HiddenInput]
        public string? ResetPasswordAction { get; set; }

        [HiddenInput]
        public string? ResetPasswordController { get; set; }
    }
}
