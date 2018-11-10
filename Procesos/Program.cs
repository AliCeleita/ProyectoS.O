using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Procesos
{
     
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
        public static void Print(this Process process)
        {
            Console.WriteLine("{0,8}    {1}", process.Id, process.ProcessName);
        }

        public static Process CreateProcess(int c)
        {
            ProcessStartInfo procesoPadre = new ProcessStartInfo();
            switch (c)
            {
                case 0:
                    procesoPadre.FileName = @"C:\Users\AliCeleita\Documents\SistemasOperativos\ProyectosJava\RobinRound\dist\RobinRound.jar";
                    procesoPadre.Arguments = "RobinRound.jar";

                    break;
                case 1:
                    procesoPadre.FileName = @"C:\Users\AliCeleita\Documents\SistemasOperativos\ProyectosJava\JavaApplication1\dist\JavaApplication1.jar";
                    procesoPadre.Arguments = "JavaApplication1.jar";

                    break;
                case 2:
                    procesoPadre.FileName = @"C:\Users\AliCeleita\Documents\SistemasOperativos\ProyectosJava\RobinRound\dist\RobinRound.jar";
                    procesoPadre.Arguments = "RobinRound.jar";

                    break;
                /*case 3:
                    procesoPadre.FileName = @"C:\Users\AliCeleita\Documents\SistemasOperativos\ProyectosJava\RobinRound\dist\RobinRound.jar";
                    procesoPadre.Arguments = "RobinRound.jar";

                    break;
                case 4:
                    break;
                case 5:
                    break;*/
                default:
                    Console.Write("No hay mas procesos para ejecutar");
                    break;
                    Console.Out.Close();   
            }
            
            Process ExecutedProces = new Process();

            ExecutedProces.StartInfo = procesoPadre;
            ExecutedProces.Start();

            Console.WriteLine("PID del proceso JAVA = " + ExecutedProces.Id.ToString());

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
    class Program
    {      

        static void Main(string[] args)
        {

            List<Process> ColaProcesos = new List<Process>();
            Console.WriteLine("\n\n=====================proceso Stufff===================");
            String StringRecv = "";
            int cont = 0;
            do {

                Console.Write("\nCommand = ");
                StringRecv = Console.ReadLine();

                if(StringRecv.Equals("nuevo"))
                {
                    ColaProcesos.Add(Funciones.CreateProcess(cont));
                    cont++;
                }

                if(StringRecv.Equals("buscar"))
                {
                    Console.Write("\t[PID] =");
                    String IdPRoceso = Console.ReadLine();
                    if (ColaProcesos.Count > 0)
                    {
                        int indice = Funciones.SearchProceso(ColaProcesos, int.Parse(IdPRoceso));
                        if (indice != -1)
                        {
                            // realizar acciones sobre el proceso
                            Console.WriteLine("\t[Proceso Encontrado]");
                            Console.Write("\t[Accion] = ");
                            String Accion = Console.ReadLine();

                            // resume
                            if (Accion.Equals("resume"))
                            {
                                Process Temp = Process.GetProcessById(ColaProcesos[indice].Id);
                                Funciones.Resume(Temp);
                                Console.WriteLine("\t[resume] Proceso [" + indice + "]");
                            }
                            // pausarlo
                            if (Accion.Equals("pause"))
                            {
                                Console.WriteLine("\tPausa");
                                Process Temp = Process.GetProcessById(ColaProcesos[indice].Id);
                                Funciones.Suspend(Temp);
                                Console.WriteLine("\t[pause] Proceso [" + indice + "]");
                            }
                            // cerrarlo
                            if(Accion.Equals("kill"))
                            {
                                Process temp = Process.GetProcessById(ColaProcesos[indice].Id);
                                temp.Kill();
                                ColaProcesos.Remove(ColaProcesos[indice]);
                                Console.WriteLine("\t[kill] Proceso muerto ["+indice+"]");
                            }
                            else
                            {
                                Console.WriteLine("\t[Error] Accion no encontrada");
                            }
                        }
                        else
                        {
                            Console.WriteLine("[Error] Indice no encontrado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("[Error] No Existe lista de proceso");
                    }
                }

            }while (!StringRecv.Equals("Salir")) ;
        }
    }
}
