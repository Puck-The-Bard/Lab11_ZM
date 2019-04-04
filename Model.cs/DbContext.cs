using Microsoft.EntityFrameworkCore;

namespace ProfessorASP.Models
{
	public class ProfessorDbContext : DbContext
	{
		public ProfessorDbContext (DbContextOptions<ProfessorDbContext> options)
			: base(options)
		{
		}
		public DbSet<ProfessorASP.Models.Professor> Professor {get; set;}
	}
}