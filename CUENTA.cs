using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cajero
{
    public class CUENTA:USUARIO
    {
        //atributos
        public int puntos;
        public double saldo;
        public double tope;

        public int Puntos { get => puntos; set => puntos = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Tope { get => tope; set => tope = value; }

        public bool validar_Cuenta(string cuenta)
        {
            bool r = false;
            if (Cuenta == cuenta)
            {
                r = true;
            }
            return r;
        }
        public void Retirar(double retiro)
        {
            if (tope - retiro >= 0)
            {
                if (retiro <= saldo)
                {
                    saldo = saldo - retiro;
                    tope = tope - retiro;
                    MessageBox.Show("\n\t\tRETIRO APROBADO!!!\n");
                }
                else
                    MessageBox.Show("\n\t\t<!> FALLO... no tiene saldo suficiente <!>\n");
            }
            else
            {
                MessageBox.Show("\n\t\t<!> FALLO... alcanzo el tope diario para retirar <!>\n");
            }
        }
        public double Transferir(double monto)
        {
            double t = 0;
            if (monto <= saldo)
            {
                saldo = saldo - monto;
                MessageBox.Show("\n\t\tTRANSFERENCIA REALIZADA!!\n");
                t = monto;
            }
            else
            {
                MessageBox.Show("\n\t\t<!> FALLO... no tiene saldo suficiente <!>\n");
            }
            return t;
        }
        public void Canjear_Puntos(int canje)
        {
            if (canje <= Puntos)
            {
                puntos = puntos - canje;
                MessageBox.Show("\n\t\tCange de puntos realizado!!\n");
            }
            else
                MessageBox.Show("\n\t\t<!> FALLO... no tiene puntos suficientes <!>\n");
        }

        internal bool validar_Cuenta(Func<string> toString)
        {
            throw new NotImplementedException();
        }
    }
}
