using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Context
{
    class DictionaryDbContext : DbContext
    {

        DbSet<Word> Words { get; set; }
    }
}
