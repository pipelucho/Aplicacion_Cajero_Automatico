namespace cajero
{
    public partial class OPERACIONES
    {
        private CUENTA[] banco2;

        public void setBanco2()
        {
            CUENTA[] banco;
            int i;
            banco = new CUENTA[2];
            for (i = 0; i < banco.Length; i++)
            {
                banco[i] = new CUENTA();
            }
            //llena los datos de las cuentas existentes
            banco[0].Titular = "Rosa";
            banco[0].Cuenta = "12345";
            banco[0].Contra = "123";
            banco[0].Saldo = 50000000;
            banco[0].Puntos = 12;
            banco[0].Tope = 2000000;

            banco[1].Titular = "Pepito";
            banco[1].Cuenta = "67890";
            banco[1].Contra = "123";
            banco[1].Saldo = 500;
            banco[1].Puntos = 1000;
            banco[1].Tope = 2000000;
            this.banco2 = banco;
        }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnCangear = new System.Windows.Forms.Button();
            this.btnPuntos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWelcome = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.txtScreem = new System.Windows.Forms.Label();
            this.btnOKRetiro = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt4 = new System.Windows.Forms.Label();
            this.btnOkEnvio = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt8 = new System.Windows.Forms.TextBox();
            this.txt7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaldo
            // 
            this.btnSaldo.BackColor = System.Drawing.Color.Lime;
            this.btnSaldo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaldo.FlatAppearance.BorderSize = 0;
            this.btnSaldo.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaldo.Location = new System.Drawing.Point(37, 64);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(153, 43);
            this.btnSaldo.TabIndex = 1;
            this.btnSaldo.Text = "Ver saldo";
            this.btnSaldo.UseVisualStyleBackColor = false;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.Lime;
            this.btnRetirar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetirar.FlatAppearance.BorderSize = 0;
            this.btnRetirar.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetirar.Location = new System.Drawing.Point(37, 122);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(153, 43);
            this.btnRetirar.TabIndex = 2;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.BackColor = System.Drawing.Color.Lime;
            this.btnTransferir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransferir.Location = new System.Drawing.Point(37, 221);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(153, 43);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = false;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnCangear
            // 
            this.btnCangear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCangear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCangear.FlatAppearance.BorderSize = 0;
            this.btnCangear.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCangear.Location = new System.Drawing.Point(424, 221);
            this.btnCangear.Name = "btnCangear";
            this.btnCangear.Size = new System.Drawing.Size(153, 43);
            this.btnCangear.TabIndex = 4;
            this.btnCangear.Text = "Cangear Puntos";
            this.btnCangear.UseVisualStyleBackColor = false;
            this.btnCangear.Click += new System.EventHandler(this.btnCangear_Click);
            // 
            // btnPuntos
            // 
            this.btnPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPuntos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPuntos.FlatAppearance.BorderSize = 0;
            this.btnPuntos.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPuntos.Location = new System.Drawing.Point(424, 141);
            this.btnPuntos.Name = "btnPuntos";
            this.btnPuntos.Size = new System.Drawing.Size(153, 43);
            this.btnPuntos.TabIndex = 5;
            this.btnPuntos.Text = "Consultar Puntos";
            this.btnPuntos.UseVisualStyleBackColor = false;
            this.btnPuntos.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(444, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 37);
            this.label8.TabIndex = 14;
            this.label8.Text = "Puntos ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(529, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(584, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Colombia";
            // 
            // txtWelcome
            // 
            this.txtWelcome.AutoSize = true;
            this.txtWelcome.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWelcome.Location = new System.Drawing.Point(76, 9);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(123, 40);
            this.txtWelcome.TabIndex = 17;
            this.txtWelcome.Text = "label1";
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.DarkRed;
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnd.Location = new System.Drawing.Point(584, 367);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(166, 43);
            this.btnEnd.TabIndex = 18;
            this.btnEnd.Text = "Cerrar Sesion";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // txtScreem
            // 
            this.txtScreem.AutoSize = true;
            this.txtScreem.Font = new System.Drawing.Font("Segoe UI Emoji", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScreem.Location = new System.Drawing.Point(171, 367);
            this.txtScreem.Name = "txtScreem";
            this.txtScreem.Size = new System.Drawing.Size(86, 30);
            this.txtScreem.TabIndex = 19;
            this.txtScreem.Text = "Screem";
            // 
            // btnOKRetiro
            // 
            this.btnOKRetiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOKRetiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOKRetiro.FlatAppearance.BorderSize = 0;
            this.btnOKRetiro.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOKRetiro.Location = new System.Drawing.Point(288, 181);
            this.btnOKRetiro.Name = "btnOKRetiro";
            this.btnOKRetiro.Size = new System.Drawing.Size(80, 28);
            this.btnOKRetiro.TabIndex = 20;
            this.btnOKRetiro.Text = "Aceptar";
            this.btnOKRetiro.UseVisualStyleBackColor = false;
            this.btnOKRetiro.Click += new System.EventHandler(this.btnOKRetiro_Click);
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt1.Location = new System.Drawing.Point(12, 185);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(103, 19);
            this.txt1.TabIndex = 21;
            this.txt1.Text = "Monto a retirar";
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt3.Location = new System.Drawing.Point(12, 276);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(103, 19);
            this.txt3.TabIndex = 22;
            this.txt3.Text = "Monto a enviar";
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt4.Location = new System.Drawing.Point(12, 311);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(104, 19);
            this.txt4.TabIndex = 23;
            this.txt4.Text = "Cuenta Destino";
            // 
            // btnOkEnvio
            // 
            this.btnOkEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOkEnvio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOkEnvio.FlatAppearance.BorderSize = 0;
            this.btnOkEnvio.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOkEnvio.Location = new System.Drawing.Point(288, 291);
            this.btnOkEnvio.Name = "btnOkEnvio";
            this.btnOkEnvio.Size = new System.Drawing.Size(80, 28);
            this.btnOkEnvio.TabIndex = 24;
            this.btnOkEnvio.Text = "Aceptar";
            this.btnOkEnvio.UseVisualStyleBackColor = false;
            this.btnOkEnvio.Click += new System.EventHandler(this.btnOkEnvio_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(125, 185);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(132, 23);
            this.txt2.TabIndex = 25;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(121, 307);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(132, 23);
            this.txt6.TabIndex = 26;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(121, 272);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(132, 23);
            this.txt5.TabIndex = 27;
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(542, 276);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(85, 23);
            this.txt8.TabIndex = 30;
            // 
            // txt7
            // 
            this.txt7.AutoSize = true;
            this.txt7.Font = new System.Drawing.Font("Segoe UI Emoji", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt7.Location = new System.Drawing.Point(429, 276);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(102, 19);
            this.txt7.TabIndex = 29;
            this.txt7.Text = "Putos a canjear";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Rockwell Extra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(646, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 28;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OPERACIONES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt8);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.btnOkEnvio);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnOKRetiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScreem);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPuntos);
            this.Controls.Add(this.btnCangear);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnSaldo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "OPERACIONES";
            this.Text = "OPERACIONES";
            this.Load += new System.EventHandler(this.OPERACIONES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSaldo;
        private Button btnRetirar;
        private Button btnTransferir;
        private Button btnCangear;
        private Button btnPuntos;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label txtWelcome;
        private Button btnEnd;
        private Label txtScreem;
        private Button btnOKRetiro;
        private Label txt1;
        private Label txt3;
        private Label txt4;
        private Button btnOkEnvio;
        private TextBox txt2;
        private TextBox txt6;
        private TextBox txt5;
        private TextBox txt8;
        private Label txt7;
        private Button button1;
    }
}