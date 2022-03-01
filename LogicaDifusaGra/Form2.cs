using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicaDifusaGra
{
    public partial class Form2 : Form
    {
        FAMDistancia[,] matrizDifusa;
        logicaDifusa[] logicaDifusas;
        public Form2()
        {
            InitializeComponent();

            logicaDifusas = new logicaDifusa[3];
            logicaDifusas[0] = new logicaDifusa("Mañana", 3, 7);
            logicaDifusas[1] = new logicaDifusa("Dia", 4, 12, 18);
            logicaDifusas[2] = new logicaDifusa("Noche", 15, 18);

            

            for (int i = 0; i < 24; i++)
            {
                double y = logicaDifusas[0].calcularFuncionHombro(i);
                grafica2.Series[0].Points.AddXY(i,y);              

                double y2 = logicaDifusas[1].calcularFuncionTriangular(i);
                grafica2.Series[1].Points.AddXY(i,y2);

                double y3 = logicaDifusas[2].calcularFuncionSaturacion(i);
                grafica2.Series[2].Points.AddXY(i,y3);
            }

            matrizDifusa = new FAMDistancia[5, 3];

            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    matrizDifusa[columna,fila]= new FAMDistancia();
                }
            }

            /*Llenado de matriz */

            // ------------------
            //matrizDifusa[0, 0].ledIntensidad1 = "MEDIO";
            //matrizDifusa[0, 0].ledIntensidad2= "BAJO";

            //matrizDifusa[0, 1].ledIntensidad1 = "ALTO";
            //matrizDifusa[0, 1].ledIntensidad2 = "BAJO";

            //matrizDifusa[0, 2].ledIntensidad1 = "ALTO";
            //matrizDifusa[0, 2].ledIntensidad2 = "MEDIO";

            //matrizDifusa[0, 3].ledIntensidad1 = "MEDIO";
            //matrizDifusa[0, 3].ledIntensidad2 = "ALTO";

            //matrizDifusa[0, 4].ledIntensidad1 = "ALTO";
            //matrizDifusa[0, 4].ledIntensidad2= "BAJO";

            //// ------------------
            //matrizDifusa[1, 0].ledIntensidad1 = "ALTO";
            //matrizDifusa[1, 0].ledIntensidad2 = "MEDIO";

            //matrizDifusa[1, 1].ledIntensidad1 = "BAJO";
            //matrizDifusa[1, 1].ledIntensidad2 = "BAJO";

            //matrizDifusa[1, 2].ledIntensidad1 = "ALTO";
            //matrizDifusa[1, 2].ledIntensidad2 = "MEDIO";

            //matrizDifusa[1, 3].ledIntensidad1 = "BAJO";
            //matrizDifusa[1, 3].ledIntensidad2 = "ALTO";

            //matrizDifusa[1, 4].ledIntensidad1 = "ALTO";
            //matrizDifusa[1, 4].ledIntensidad2 = "BAJO";
            //// ------------------
            //matrizDifusa[2, 0].ledIntensidad1 = "ALTO";
            //matrizDifusa[2, 0].ledIntensidad2 = "ALTO";

            //matrizDifusa[2, 1].ledIntensidad1 = "ALTO";
            //matrizDifusa[2, 1].ledIntensidad2 = "MEDIO";

            //matrizDifusa[2, 2].ledIntensidad1 = "MEDIO";
            //matrizDifusa[2, 2].ledIntensidad2 = "BAJO";

            //matrizDifusa[2, 3].ledIntensidad1 = "MEDIO";
            //matrizDifusa[2, 3].ledIntensidad2 = "MEDIO";

            //matrizDifusa[2, 4].ledIntensidad1 = "ALTO";
            //matrizDifusa[2, 4].ledIntensidad2 = "MEDIO";




        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double x = hScrollBar1.Value;
                        
            double[] yA = new double[3];

            grafica2.Series[3].Color = Color.GreenYellow;
            grafica2.Series[3].Points.Clear();

            for (int i = 0; i < 5; i++)
            {
                grafica2.Series[3].Points.AddXY(x, 1.5);
                grafica2.Series[3].Points.AddXY(x, 0);
            }

            yA[0] = logicaDifusas[0].calcularFuncionHombro(x);
            yA[1] = logicaDifusas[1].calcularFuncionTriangular(x);
            yA[2] = logicaDifusas[2].calcularFuncionTriangular(x);

            //double newX = yA.Max();

            //grafica2.Series[6].Points.Clear();
            //grafica2.Series[6].Color = Color.GreenYellow;
            //grafica2.Series[6].Points.AddXY(0, yA.Max());
            //grafica2.Series[6].Points.AddXY(150, yA.Max());

            //lblValorLinguistico.Text = valoresL[yA.ToList().IndexOf(yA.Max())].valorLinguistico;

        }
    }
}
