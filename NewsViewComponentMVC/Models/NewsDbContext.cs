using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace NewsViewComponentMVC.Models;

public partial class NewsDbContext : DbContext
{
    public DbSet<News> News { get; set; }

    public NewsDbContext(){}

    public NewsDbContext(DbContextOptions<NewsDbContext> options): base(options){}
}
