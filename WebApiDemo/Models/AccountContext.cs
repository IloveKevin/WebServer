using Microsoft.EntityFrameworkCore;

namespace WebApiDemo.Models
{
	public class AccountContext : DbContext
	{
		public AccountContext(DbContextOptions<AccountContext> options) : base(options)
		{
		}
		public DbSet<Account> Accounts { get; set; }
	}
}
