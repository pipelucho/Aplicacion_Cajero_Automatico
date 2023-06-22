namespace cajero
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            int i, j, salir = 1, salir2 = 1, respuesta, respuesta2, SiHay = 0, SiHay2 = 0, Auxiliar;
            double aux, nuevoMonto;
            
            //autenticacion
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}