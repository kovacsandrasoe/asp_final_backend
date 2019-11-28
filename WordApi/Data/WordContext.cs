using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordApi.Models;

namespace WordApi.Data
{
    public class WordContext : DbContext
    {
        public WordContext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Word> Words { get; set; }
    }
}
