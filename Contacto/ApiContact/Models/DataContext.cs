namespace ApiContact.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiContact.Models.Contact> Contacts { get; set; }
    }
}