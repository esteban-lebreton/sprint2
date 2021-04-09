using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoupGarou
{
    public partial class Plateforme : Form
    {
        public Plateforme()
        {
            InitializeComponent();
            Thread leTread = new Thread(new ThreadStart(CommunicationServer));
            leTread.Start();
        }

        public void CommunicationServer()
        {
            Server l = new Server(this, "127.0.0.1", 2021);
            l.Run();
        }

        private void Plateforme_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void rb_RSalle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
