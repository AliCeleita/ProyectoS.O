using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Procesos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }
    }
    static class Funciones
    {

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, uint dwThreadId);
        [DllImport("kernel32.dll")]
        static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        static extern int ResumeThread(IntPtr hThread);

        public static void Suspend(this Process process)
        {
            foreach (ProcessThread thread in process.Threads)
            {
                var pOpenThread = OpenThread(0x0002, false, (uint)thread.Id);
                if (pOpenThread == IntPtr.Zero)
                {
                    break;
                }
                SuspendThread(pOpenThread);
            }
        }

        public static void Resume(this Process process)
        {
            foreach (ProcessThread thread in process.Threads)
            {
                var pOpenThread = OpenThread(0x0002, false, (uint)thread.Id);
                if (pOpenThread == IntPtr.Zero)
                {
                    break;
                }
                ResumeThread(pOpenThread);
            }
        }
       

        public static Process CreateProcess(string url, string proces, string nombre,List<Info_proceso> pros)
        {
            Info_proceso informacion = new Info_proceso();  
            ProcessStartInfo procesoPadre = new ProcessStartInfo();
            procesoPadre.FileName = @url;            
            procesoPadre.Arguments = proces;
            Process ExecutedProces = new Process();

            ExecutedProces.StartInfo = procesoPadre;
            ExecutedProces.Start();

            informacion.Indice = ExecutedProces.Id.ToString();
            informacion.Nombre = nombre;
            informacion.Url = url;
            pros.Add(informacion);
            return ExecutedProces;
        }

        public static int SearchProceso(List<Process> listaTemp, int IdProceso)
        {
            int indice = -1;

            for (int i = 0; i < listaTemp.Count; i++)
            {
                if (listaTemp[i].Id == IdProceso)
                {
                    indice = i;
                }
            }

            return indice;
        }
    }

   
}
