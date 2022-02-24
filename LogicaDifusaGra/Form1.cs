using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HTTPupt;

namespace LogicaDifusaGra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        Form2 form;
        logicaDifusa[] valoresL;
        bool consultaApiBool = false;

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            form = new Form2();
            form.Show();

            hScrollBar1.Enabled = true;                   
            btnGraficar.Enabled = false;
            btnActualizar.Enabled = true;

            valoresL = new logicaDifusa[4];
            valoresL[0] = new logicaDifusa("muy cercas", 30, 40);
            valoresL[1] = new logicaDifusa("cercas", 30, 60, 90);
            valoresL[2] = new logicaDifusa("lejos", 80, 110, 140);
            valoresL[3] = new logicaDifusa("muy lejos", 130, 140);

            double ySaturacion = 0, yHombro = 0;

            for (int i = 0; i < 2; i++)
            {
                for (double x = 0; x <= 150; x++)
                {
                    double y = valoresL[i+1].calcularFuncionTriangular(x);
                    grafica.Series[i+1].Points.AddXY(x, y);
                }

            }
            for (double x = 0; x < 150; x++)
            {
                yHombro = valoresL[0].calcularFuncionHombro(x);
                grafica.Series[0].Points.AddXY(x, yHombro);                

                ySaturacion = valoresL[3].calcularFuncionSaturacion(x);
                grafica.Series[3].Points.AddXY(x, ySaturacion);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double x = hScrollBar1.Value;
                        
            double[] yA = new double[4];

            grafica.Series[4].Color = Color.GreenYellow;
            grafica.Series[4].Points.Clear();

            for (int i = 0; i < 5; i++)
            {
                grafica.Series[4].Points.AddXY(x, 1.5);
                grafica.Series[4].Points.AddXY(x, 0);
            }
            
            yA[0] = valoresL[0].calcularFuncionHombro(x);
            yA[1] = valoresL[1].calcularFuncionTriangular(x);
            yA[2] = valoresL[2].calcularFuncionTriangular(x);
            yA[3] = valoresL[3].calcularFuncionSaturacion(x);


            double newX = yA.Max();

            grafica.Series[6].Points.Clear();
            grafica.Series[6].Color = Color.GreenYellow;
            grafica.Series[6].Points.AddXY(0, yA.Max());
            grafica.Series[6].Points.AddXY(150, yA.Max());

            lblValorLinguistico.Text = valoresL[yA.ToList().IndexOf(yA.Max())].valorLinguistico;


        }

        public void consultarAPIESP()
        {
            var url = "http://192.168.4.1/sensor";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";

            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            Arduino esp32 = JsonConvertidor.Json_Objeto<Arduino>(responseBody);
                            Console.WriteLine(esp32.distancia);
                            double x = 0;
                            if (esp32.distancia > 150)
                            {
                                x = 150;
                            }
                            else
                            {
                                x = esp32.distancia;
                            }
                            lblDistancia.Text = Math.Round(x, 2).ToString() + " cm";
                            grafica.Series[5].Points.Clear();
                            grafica.Series[5].Color = Color.MediumVioletRed;

                            for (int i = 0; i < 5; i++)
                            {
                                grafica.Series[5].Points.AddXY(x, 1.5);
                                grafica.Series[5].Points.AddXY(x, 0);
                            }
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                btnActualizar.Text = "Error API";
            }
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {

            consultarAPIESP();
        }
        private void f(object sender, KeyPressEventArgs e)
        {
            //comentario prueba
            consultarAPIESP();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            double x = hScrollBar1.Value;

            double[] yA = new double[4];

            grafica.Series[4].Color = Color.GreenYellow;
            grafica.Series[4].Points.Clear();

            for (int i = 0; i < 5; i++)
            {
                grafica.Series[4].Points.AddXY(x, 1.5);
                grafica.Series[4].Points.AddXY(x, 0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            consultarAPIESP();
            timer1.Start();
        }
    }
}
