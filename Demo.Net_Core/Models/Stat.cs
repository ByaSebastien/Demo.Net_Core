using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Net_Core.Models
{
    public enum StatType
    {
        Hp,
        Force,
        Defence,
        Vitesse
    }
    public class Stat
    {
        private Dictionary<StatType, int> _stats = new Dictionary<StatType, int>();

        public Dictionary<StatType, int> Stats
        {
            get { return _stats ?? new Dictionary<StatType, int>(); }
        }

        public int this[StatType stat]
        {
            get
            {
                if (!Stats.ContainsKey(stat))
                    Stats.Add(stat, 0);

                return Stats[stat];
            }
            set
            {
                if(!Stats.ContainsKey(stat))
                    Stats.Add(stat,0); 
                Stats[stat] = value < 0 ? 0 : value;
            }
        }
    }
}
