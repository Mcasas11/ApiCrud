using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCrud.Models
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext() { }
        public CrudDbContext(DbContextOptions<CrudDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
    public class Person
    {
        [Key]
        public int personId { get; set; }
        public string personName { get; set; }
        public string personLastName { get; set; }
        public string personAge { get; set; }
    }
}
