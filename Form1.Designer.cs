namespace cajero
{
    public partial class Form1
    {
        private CUENTA[] banco;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        
        public void setBanco()
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
            this.banco = banco;
        }
        public CUENTA[] getBanco()
        {
            return this.banco;
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private TextBox txtUser;
        private TextBox txtPass;
        private Label label;
        private Label label1;
        private Button btnLogin;
        private Button btnEnd;
        private LinkLabel linkRemember;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
    }
}