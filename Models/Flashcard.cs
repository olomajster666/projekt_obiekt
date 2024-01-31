using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektOOP.Models
{

    // Klasa pomocnicza do tworzenia fiszek, implementacje CRUD na niej są realizowane poprzez Flashcard Collection

    public class Flashcard
    {
        public int Id { get; set; }
        public string Front { get; set; }
        public string Back { get; set; }
    }
}