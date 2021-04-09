using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Jour
    {
        public string lEtat;
        public static int auto=0;
        public int lId;
        public List<Joueur> lesMorts;

        public Jour()
        {
            auto++;
            this.lId = auto;
            lesMorts = new List<Joueur>();
        }
    }
}
