using System;
namespace Gama.RedeSocial.Domain.Entities
{
    public class Invite : BaseEntity
    {
        public Invite()
        {
            Sender = new User();

            Receiver = new User();

            InviteStatus = new InviteStatus();
        }

        public Guid SenderId { get; set; }
        public User Sender { get; set; }

        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; }
        public InviteStatus InviteStatus { get; private set; }
        public Guid InviteStatusId { get; set; }
        public InviteStatus Status { get; set; }

        public override void Validate()
        {
            if (SenderId == Guid.Empty)
                throw new ArgumentNullException("'SenderId' não foi preenchido");

            if (ReceiverId == Guid.Empty)
                throw new ArgumentNullException("'ReceiverId' não foi preenchido");

            if (InviteStatusId == Guid.Empty)
                throw new ArgumentNullException("'InviteStatusId' não foi preenchido");

            if (SenderId == ReceiverId)
                throw new ArgumentException("Invite inválido");
        }
        #region MetodoTeste
        //public override void Validate() //vc tinha falado sobre essa questao de ao usar validate mas eu noa me lembro 
        //{
        //    Sender.Validate();
        //    Receiver.Validate();
        //    Status.Validate();
        //} 
        #endregion
    }
}
