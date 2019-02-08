using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MVCSample.Models
{
    public class Sample
    {
        public int EID { get; set; }
        public string name { get; set; }
        public string salary { get; set; }
    }
    public class SampleContext:DbContext
    {
        public DbSet<Sample>Sample { get; set; }
    }
}
