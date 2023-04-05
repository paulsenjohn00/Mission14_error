using System;
using Microsoft.EntityFrameworkCore;

namespace MovieApi.Controllers.MovieData
{
	public class MovieDbContext: DbContext
	{
		public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options) { }

		public DbSet<MovieInfo> Movies { get; set; }
	}
}

