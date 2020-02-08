using Gama.RedeSocial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Mappers
{
    public class InviteMapper : BaseMapper<Invite>
    {
        public InviteMapper()
        {
            ToTable("TB_INVITE");
            Map(entity => entity.Sender.Id).ToColumn("ID_SENDER");
            Map(entity => entity.Recipient.Id).ToColumn("ID_RECEIVER");
            Map(entity => entity.Status.Id).ToColumn("ID_STATUS");
        }
    }
}
