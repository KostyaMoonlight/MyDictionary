using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary.Context
{
    [Table("Dictionary")]
    public class Word
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }

        [Column("Original")]
        public string Original { get; set; }

        [Column("Translation")]
        public string Translation { get; set; }

        [Column("Rating")]
        public int Rating { get; set; }

        [Column("Note")]
        public string Note { get; set; }
    }
}
