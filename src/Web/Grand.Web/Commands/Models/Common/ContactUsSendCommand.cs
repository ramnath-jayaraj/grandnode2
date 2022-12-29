﻿using Grand.Domain.Stores;
using Grand.Web.Common.Models;
using Grand.Web.Models.Common;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Grand.Web.Commands.Models.Common
{
    public class ContactUsSendCommand : IRequest<(ContactUsModel model, IList<string> errors)>
    {
        public ContactUsModel Model { get; set; }
        public bool CaptchaValid { get; set; }
        public string IpAddress { get; set; }
        public Store Store { get; set; }
    }
}
