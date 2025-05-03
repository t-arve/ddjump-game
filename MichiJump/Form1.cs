using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichiJump
{
    public partial class MichiJump : Form
    {
        private Plataformas plataformas;
        private Random r;
        public MichiJump()
        {
            InitializeComponent();
            r = new Random();
            plataformas = new Plataformas(pbEscenario.Width, pbEscenario.Height, r, 2500);
        }
        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
        }

        private void timerAnimacion_Tick(object sender, EventArgs e)
        {
            //pelota.Borrar(pbCancha.CreateGraphics());
            plataformas.Mover();
            pbEscenario.Invalidate();
        }

        private void pbCancha_Paint(object sender, PaintEventArgs e)
        {
            plataformas.Dibujar(e.Graphics);
        }

        
    }
}
