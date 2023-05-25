namespace first_asp_app.Data
{
    public partial class BaseEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
