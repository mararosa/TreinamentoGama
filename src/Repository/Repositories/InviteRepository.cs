﻿using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class InviteRepository : RepositoryBase<Invite>, IInviteRepository
    {
        //private IInviteStatusRepository _inviteStatusRepository;

        //public InviteRepository(IInviteStatusRepository inviteStatusRepository)
        //{
        //    _inviteStatusRepository =
        //}

        public IEnumerable<Invite> GetByUserId(Guid userId)
        {
            //var sql = @"SELECT TB_INVITE.* FROM TB_INVITE  
            //            WHERE 
            //         TB_INVITE.ID_SENDER = @userId OR 
            //            TB_INVITE.ID_RECEIVER = @userId";

            //var parameters = new { userId };

            //return Execute<Invite>(sql, parameters);

            return Get(entity => entity.SenderId == userId || entity.ReceiverId == userId);
        }

        public IEnumerable<Invite> GetFriends(Guid userId)
        {
            var sql = @"SELECT TB_INVITE.* 
                        FROM TB_INVITE  
                        INNER JOIN TB_INVITE_STATUS on TB_INVITE.ID_INVITE_STATUS = TB_INVITE_STATUS.ID 
                        WHERE 
                        TB_INVITE_STATUS.DS_INVITE_STATUS = 'Aceito' AND 
	                    TB_INVITE.ID_SENDER = @userId OR 
                        TB_INVITE.ID_RECEIVER = @userId";

            var parameters = new { userId };


            return Execute<Invite>(sql, parameters);

            //return Get(entity => entity.SenderId == userId || entity.ReceiverId == userId);
        }
    }
}
