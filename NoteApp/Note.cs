using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NoteApp
{
    class Note
    {
        public Note()
        {
            Name = string.Empty;
            Importance = string.Empty;
        }
        public Note(string name, string importance)
        {
            Name = name;
            Importance = importance;
        }

        [PrimaryKey, AutoIncrement] //SQlite
        public int Id { get; set; }

        public string Name { get; set; }
        public string Importance { get; set; }
        
        
    }
}
