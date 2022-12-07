using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace I_Sail
{
    [Table("Races")]
    class Race
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string RaceName { get; set; }


        public override string ToString()
        {
            return string.Format("{0}", RaceName);
        }
    }
}
