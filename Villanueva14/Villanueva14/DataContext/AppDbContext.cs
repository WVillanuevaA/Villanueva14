﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Villanueva14.Models;

namespace Villanueva14.DataContext
{
    public class AppDbContext: DbContext
    {
        //Path donde se va guardar la base de datos
        string DbPath = string.Empty;


        //Tablas de base de datos
        public DbSet<Compra> Product { get; set; }
        


        //Estándar del desarrollo con EFC
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlite($"Filename={DbPath}");
        }

    }
}
