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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrizDifusa = new FAMDistancia[5, 3];
                }
            }


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
