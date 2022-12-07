using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace I_Sail
{
    [Table("Sailor")]
    class Sailor
    {

        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }

        public string School { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }

        public override string ToString()
        {
            return string.Format("Name-{0} School-{1} Age-{2} Position-{3}",Name,School,Age,Position);
        }
    }
}
