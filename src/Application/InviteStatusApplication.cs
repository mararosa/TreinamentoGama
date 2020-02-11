using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
   public class InviteStatusApplication : ApplicationBase<InviteStatus>
    {
        private readonly IInviteStatusService _service;

        public InviteStatusApplication(IInviteStatusService service) : base(service)
        {
            _service = service;
        }
    }
}
