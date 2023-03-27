﻿using Microsoft.EntityFrameworkCore;
using Api04.Models;
public class ApplicationDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){

    }
}