using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace LogicaDifusaGra
{
    public partial class logicaDifusa
    {
        private int alfa { get; set; }
        private int beta { get; set; }
        private int gamma { get; set; }
        public string valorLinguistico { get; set; }


        public logicaDifusa(string valorLinguistico, int alfa, int beta, int gamma)
        {
            this.valorLinguistico = valorLinguistico;
            this.alfa = alfa;
            this.beta = beta;
            this.gamma = gamma;            
        }
        public logicaDifusa(string valorLinguistico, int alfa, int beta)
        {
            this.valorLinguistico = valorLinguistico;
            this.alfa = alfa;
            this.beta = beta;            
        }

        public double calcularFuncionTriangular(double tiempo)
        {
            int alfa = this.alfa, beta = this.beta, gamma = this.gamma;            
            double y = 0;
            
            if (tiempo < alfa)
            {
                y = 0;
            }
            else if (alfa <= tiempo && tiempo <= beta)
            {
                y = (tiempo - alfa) / (beta - alfa);
            }
            else if (beta <= tiempo && tiempo <= gamma)
            {
                y = (gamma - tiempo) / (gamma - beta);
            }
            else if (tiempo > gamma)
            {
                y = 0;
            }
            return y;            
        }
        public double calcularFuncionSaturacion(double x)
        {
            double y = 0;
            int alfa = this.alfa;
            int beta = this.beta;

            if (x <= alfa)
            {
                y = 0;
            }
            if (x > alfa && x < beta)
            {
                y = (x - alfa) / (beta - alfa);
            }
            if (x >= beta)
            {
                y = 1;
            }
            return y;

        }
        public double calcularFuncionHombro(double x)
        {
            double y = 0;
            int alfa = this.alfa;
            int beta = this.beta;

            if (x <= alfa)
            {
                y = 1;
            }
            if (x > alfa && x < beta)
            {
                y = 1 - (x - alfa) / (beta - alfa);
            }
            if (x >= beta)
            {
                y = 0;
            }

            return y;
        }
    }
}
