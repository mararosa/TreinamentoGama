namespace Gama.RedeSocial.Domain.Entities
{
    class Invite : BaseEntity
    {
        public User Sender { get; set; }
        public User Recipient { get; set; }
        public InviteStatus Status { get; set; }
    }
}
