using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero
{
    public partial class OPERACIONES : Form
    {
        private string mensaje;
        private int i;
        private Button True;

        //private CUENTA[] banco;
        public OPERACIONES(string mensaje, int i)
        {
            this.mensaje = mensaje;
            InitializeComponent();
            this.i = i;
        }
        public void ocultarTodo()
        {
            this.txt1.Visible = false;
            this.txt2.Visible = false;
            this.btnOKRetiro.Visible = false;
            this.txt3.Visible = false;
            this.txt4.Visible = false;
            this.txt5.Visible = false;
            this.txt6.Visible = false;
            this.btnOkEnvio.Visible = false;
            this.txt7.Visible = false;
            this.txt8.Visible = false;
            this.button1.Visible = false;
            this.txtScreem.Visible = false;
        }
        
        private void OPERACIONES_Load(object sender, EventArgs e)
        {
            txtWelcome.Text = mensaje;
            ocultarTodo();

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesion terminada");
            this.Close();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            //MessageBox.Show("Tu saldo es " + banco2[i].Saldo );
            txtScreem.Text = "Tu saldo es " + banco2[i].Saldo;
            this.txtScreem.Visible = true;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            this.txt1.Visible = true;
            this.txt2.Visible = true;
            this.btnOKRetiro.Visible = true;
            //txtScreem.Text = "retiro  " + ;
        }

        private void btnPuntos_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            txtScreem.Text = "Tus puntos son: " + banco2[i].Puntos;
            this.txtScreem.Visible = true;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            this.txt4.Visible = true;
            this.txt3.Visible = true;
            this.txt5.Visible = true;
            this.txt6.Visible = true;
            this.btnOkEnvio.Visible = true;
        }
        private void btnCangear_Click(object sender, EventArgs e)
        {
            ocultarTodo();
            this.txt7.Visible = true;
            this.txt8.Visible = true;
            this.button1.Visible = true;
        }

        private void btnOKRetiro_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.txt2.Text) <= 0)
                MessageBox.Show("El monto debe ser positivo");
            else
                banco2[i].Retirar(int.Parse(this.txt2.Text));
            
        }

        private void btnOkEnvio_Click(object sender, EventArgs e)
        {
            int si = 0;
            double nuevoMonto;
            int j;
            if (int.Parse(this.txt5.Text) <= 0)
                MessageBox.Show("El monto debe ser positivo");
            else
            {
                for (j = 0; j < banco2.Length; j++)
                {
                    if (banco2[j].Cuenta == this.txt6.Text)
                    {
                        si = 1;
                        banco2[i].Transferir(int.Parse(this.txt5.Text));
                        if (banco2[i].Saldo - int.Parse(this.txt5.Text) >= 0 && banco2[i].Tope - int.Parse(this.txt5.Text) >= 0)
                        {
                            nuevoMonto = banco2[j].Saldo;
                            banco2[j].Saldo = nuevoMonto + int.Parse(this.txt5.Text);
                        }
                    }
                }
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(this.txt8.Text) <= 0)
                MessageBox.Show("El monto debe ser positivo");
            else
                banco2[i].Canjear_Puntos(int.Parse(this.txt8.Text));
        }

        
    }
}
