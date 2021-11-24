using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor.Model
{
    public class Notebook
    {
        [PrimaryKey, AutoIncrement]
        public uint Id { get; set; }
        public uint UserId { get; set; }
        public string Name { get; set; }
    }
}
