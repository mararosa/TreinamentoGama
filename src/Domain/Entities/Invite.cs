namespace Gama.RedeSocial.Domain.Entities
{
    public class Invite : BaseEntity
    {
        public User Sender { get; set; }
        public User Recipient { get; set; }
        public InviteStatus Status { get; set; }

        public override void Validate() //vc tinha falado sobre essa questao de ao usar validate mas eu noa me lembro 
        {
            Sender.Validate();
            Recipient.Validate();
            Status.Validate();
        }
    }
}
