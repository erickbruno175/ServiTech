using ServiTech.DbConection;
using System.Linq.Expressions;

namespace ServiTech
{
    public static class Program
    {
        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DbConectionPdv db = new DbConectionPdv();
            Application.Run(new Gerenciador(db));
        }
    }
}