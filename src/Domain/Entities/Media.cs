namespace Gama.RedeSocial.Domain.Entities
{
    public class Media : BaseEntity
    {

        public Media()
        {
            MediaType = new MediaType();
        } //construtor para nao dar erro. Pq quando da uma nova midia ela nao tem tipo e da para acessar. O construtor "libera" o acesso.

        public MediaType MediaType { get; set; } //para saber se eh foto ou video acesssa aqui
        public string Path { get; set; }
    }
}
