using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichiJump
{
    class Plataformas
    {
        private Plataforma[] plataformas;   // 1. Declarar la Referencia
        private int XMax;
        private int YMax;
        private Random r;
        private int n;

        public Plataformas(int XMax, int YMax, Random r, int n)
        {
            this.XMax = XMax;
            this.YMax = YMax;
            this.r = r;
            this.n = n;
            plataformas = new Plataforma[n];    // 2. Crear el espacio para los objetos

            // 3. Crear los objetos
            for (int i = 0; i < n; i++)
                plataformas[i] = new Plataforma(XMax, YMax, r, i, n);
        }

        public void Mover()
        {
            for (int i = 0; i < n; i++)
                plataformas[i].Mover();
        }

        public void Dibujar(Graphics graphics)
        {
            for (int i = 0; i < n; i++)
                plataformas[i].Dibujar(graphics);
        }
    }
}
