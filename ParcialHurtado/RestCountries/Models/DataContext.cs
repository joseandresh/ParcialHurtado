using System.Data.Entity;

namespace RestCountries.Models
{
	public class DataContext : DbContext
	{
		public DataContext() : base("DefaultConnection")
		{

		}

		public System.Data.Entity.DbSet<RestCountries.Models.Country> Countries { get; set; }
	}
}