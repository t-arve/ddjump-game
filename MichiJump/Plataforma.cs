using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichiJump
{
    class Plataforma
    {
        private double x;
        private double y;
        private double radio;
        private int color;

        private double angulo;
        private double sentido;

        private bool estado;

        private int XMax;
        private int YMax;
        private Random r;

        public Plataforma(int XMax, int YMax, Random r, int id, int n)
        {
            x = ((2 * id + 1) * XMax) / (2 * n);
            y = r.Next(5, YMax);//YMax / 2;
            radio = r.Next(0, 5);// Math.Max(2, XMax/(10*n));
            color = r.Next(1, 1);
            estado = false;
            this.XMax = XMax;
            this.YMax = YMax;
            this.r = r;
            angulo = 90;//r.Next(90, 90);
            sentido = (radio / 2);
        }

        private Brush GetColor()
        {
            Brush res = null;
            //El color siempre sera case 1 a menos que cambiemos los parametros de los 2 "color" en el constructor y la instancia de traspaso
            switch (color)
            {
                case 1:
                    res = Brushes.Blue;
                    break;
                case 2:
                    res = Brushes.Red;
                    break;
                case 3:
                    res = Brushes.Green;
                    break;
                case 4:
                    res = Brushes.Cyan;
                    break;
                case 5:
                    res = Brushes.Magenta;
                    break;
                case 6:
                    res = Brushes.Brown;
                    break;
                case 7:
                    res = Brushes.Black;
                    break;
                default:
                    res = Brushes.Blue;
                    break;
            }

            return res;
        }

        public void Dibujar(Graphics graphics)
        {
            graphics.FillEllipse(GetColor(),
                (int)(x - radio), (int)(y - radio),
                (int)(2 * radio), (int)(2 * radio));
        }

        public void Borrar(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.White,
                (int)(x - radio), (int)(y - radio),
                (int)(2 * radio), (int)(2 * radio));
        }

        private void Traspasar()
        {

            if (YMax - y == 0)
            {
                y = 5;/*YMax / 2;          //5 en lugar de 0 para que las pelotas que aparezcan 
                                             con radio aleatorio no se bugueen apareciendo fuera de los limites//*/
                x = r.Next(10, XMax - 10);   //también para evitar que las pelotas aparezcan fuera de los limites
                //radio = r.Next(1, 10);
                radio = r.Next(1, 5);// Math.Max(2, XMax/(10*n));
                color = r.Next(1, 1);
                estado = false;

                angulo = 90; /* r.Next(90, 90); //angulo de caida de la lluvia (no se cambio el if en X, así que si se cambia
                                                  el angulo, las pelotas rebotaran con los bordes en lugar de traspasar)*/

                sentido = (radio / 2);
            }

            /*
            if (y - radio <= 0 || y + radio >= YMax)
            {
                if (Math.Abs(angulo) == 90) //eliminamos el rebote en Y pero aún no en X
                {
                    sentido = -sentido;
                }
                else if (Math.Abs(angulo) > 45)
                {
                    sentido = -sentido;
                    angulo = -angulo;
                }
                else if (Math.Abs(angulo) <= 45)
                {
                    angulo = -angulo;
                }
            }
            */

            if (x - radio <= 0 || x + radio >= XMax) //no hara nada mientras el angulo se mantenga en vertical
            {
                if (Math.Abs(angulo) > 45)
                {
                    angulo = -angulo;
                }
                else if (Math.Abs(angulo) <= 45)
                {
                    sentido = -sentido;
                    angulo = -angulo;
                }
            }

        }

        private void Desplazarse()
        {
            if (Math.Abs(angulo) == 90)
            {
                y += sentido;
            }
            else if (Math.Abs(angulo) > 45)
            {
                double rad = (Math.PI * angulo) / 180;
                x += (sentido / Math.Tan(rad));
                y += sentido;
            }
            else if (Math.Abs(angulo) <= 45)
            {
                double rad = (Math.PI * angulo) / 180;
                x += sentido;
                y += (sentido * Math.Tan(rad));
            }
        }

        public void Mover()
        {
            Traspasar();
            Desplazarse();
        }

        public bool GetEstado()
        {
            return estado;
        }

        public void CambiaEstado()
        {
            estado = !estado;
        }
    }
}
