using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Net_Core.Models
{
    public enum Genres
    {
        Homme,
        Femme,
        Autre
    }
    public class Personne
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public Genres Genre { get; set; }
    }
}
