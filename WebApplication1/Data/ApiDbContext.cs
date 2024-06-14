﻿using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
        }
            public DbSet<Produto> Produtos { get; set; }
        
    }
}
