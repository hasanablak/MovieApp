using Microsoft.EntityFrameworkCore;
using MovieApp.Web.Entity;

namespace MovieApp.Web.Data
{
	public class MovieContext : DbContext
	{
		public MovieContext(DbContextOptions<MovieContext> options) : base(options)
		{

		}
		public DbSet<Movie> Movies { get; set; }

		public DbSet<Person> People { get; set; }

		public DbSet<Crew> Crews { get; set; }
		public DbSet<Cast> Casts { get; set; }



		public DbSet<Genre> Genres { get; set; }


		public DbSet<User> Users { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Movie>()
			.Property(prop => prop.Title)
			.IsRequired();

			modelBuilder.Entity<Movie>()
			.Property(prop => prop.Title)
			.HasMaxLength(500);


			modelBuilder.Entity<Genre>()
			.Property(prop => prop.Name)
			.IsRequired();

			modelBuilder.Entity<Genre>()
			.Property(prop => prop.Name)
			.HasMaxLength(50);
		}
	}
}
