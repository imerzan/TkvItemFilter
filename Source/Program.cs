using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace TkvItemFilter
{
    internal static class Program
    {
        private static Mutex _Mutex;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                _Mutex = new Mutex(true, "05990EBB-74E7-4D3A-B5C9-A5E5446B2C47", out bool singleton);
                if (singleton) // Program is singular instance, begin startup
                {
                    AppDomain.CurrentDomain.AssemblyResolve += FindAssembly; // Register event
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                else // Program is additional instance, abort startup
                {
                    throw new Exception("The Application Is Already Running!");
                }
            }
            catch (Exception ex) // Catch singleton/cert exceptions in particular
            {
                MessageBox.Show(ex.ToString(), "TkvItemFilter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Assembly FindAssembly(object sender, ResolveEventArgs args) // Dynamically load assembly
        {
            var name = new AssemblyName(args.Name).Name;
            if (name.Equals("Newtonsoft.Json", StringComparison.OrdinalIgnoreCase))
            {
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("TkvItemFilter.Resources.Newtonsoft.Json.dll")) // Open from resources
                {
                    var assem = new byte[stream.Length]; // Allocate buffer
                    stream.Read(assem, 0, assem.Length); // Read into memory buffer
                    return Assembly.Load(assem); // Load assembly from Memory
                }
            }
            else return null;
        }
    }
}
