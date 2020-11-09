using Entities.Tables;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;



namespace DAL.ORM.EFCore
{
    public class MusteriSistemiContext :DbContext
    {
        public MusteriSistemiContext(DbContextOptions<MusteriSistemiContext> options)
        : base(options)
        { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Musteri> Musteris { get; set; }

    }
}
