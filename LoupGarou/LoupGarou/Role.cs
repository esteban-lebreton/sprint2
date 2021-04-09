using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Role
    {
        public string leLibelle;
        public string leDescriptif;

        public Role(string libelle, string descriptif)
        {
            this.leLibelle = libelle;
            this.leDescriptif = descriptif;
        }
    }
    
}
