using VerduraoDoJao.Melanciometro;
namespace VerduraoDoJoao2._0
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
            new Produto("Melancia Normal", 8.5, 4.5, "Kg");
            new Produto("Melancia Baby", 10.95, 6.75, "kg");
            ApplicationConfiguration.Initialize();
            var Login = new Login();
            Application.Run(Login);
            if (Login.Valido)
            {
                Application.Run(new Form1());
            }
        }

    }
}