using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bercea_Anelise_lab12.Models;

namespace Bercea_Anelise_lab12.Data
{
    public class Bercea_Anelise_lab12Context : DbContext
    {
        public Bercea_Anelise_lab12Context (DbContextOptions<Bercea_Anelise_lab12Context> options)
            : base(options)
        {
        }

        public DbSet<Bercea_Anelise_lab12.Models.ShopList> ShopList { get; set; }
    }
}
