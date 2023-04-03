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

        public static Personne operator +(Personne a, Personne b)
        {
            return new Personne()
            {
                FirstName = a.FirstName.Substring(0, 2) + b.FirstName.Substring(2, 2),
                LastName = a.LastName.Substring(0, 2) + b.LastName.Substring(2, 2),
            };
        }

        public static bool operator ==(Personne a, Personne b)
        {
            return a.FirstName == b.FirstName;
        }
        public static bool operator !=(Personne a, Personne b)
        {
            return !(a == b);
        }
    }
}