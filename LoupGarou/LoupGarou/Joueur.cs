using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoupGarou
{
    public class Joueur : Client
    {
        public string leLogin;
        public int leNbrVote = 0;
        public bool estMort = false;
        public bool estActif = false;
        public Role leRole;

        public Joueur(string login, int num) : base(num)
        {
            this.leLogin = login;
        }
    }
}
