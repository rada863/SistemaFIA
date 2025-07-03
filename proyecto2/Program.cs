using System;
using System.Windows.Forms;
using proyecto2.Modelos;
using proyecto2.Forms;

//Apellido y Nombre: Franco david Carrizo
//lamento entregar tarde esto realmente me complico pero logre dominar ahora 
namespace proyecto2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();

            // Instancia del sistema
            var sistemaFIA = new SistemaFIA();
            sistemaFIA.CargarDatosPrueba(); //  testing

            // Abrir el formulario principal de navegación (podés cambiarlo)
            Application.Run(new MainForm(sistemaFIA));

            
        }
    }
}