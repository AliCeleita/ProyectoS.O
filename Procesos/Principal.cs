using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;

using System.Runtime.InteropServices;

namespace Procesos
{
    public partial class Principal : Form
    {

        List<Process> ColaProcesos;
        List<Info_proceso> pros;
      
        public Principal()
        {
            pros = new List<Info_proceso>();
        
            InitializeComponent();
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            ColaProcesos = new List<Process>();
            string proceso = CB_proceso.SelectedItem.ToString();
            switch (proceso)
            {
                //Aqui es donde metemos todos los proyectos o mas bien iniciamos de acuerdo este switch depende de ese combobox
                case "Cuadro_Magico":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:/Users/rojas/Desktop/Procesos/Procesos/programas/Cuadro_Magico.jar", "Cuadro_Magico.jar", "Cuadro_Magico", pros));
                        CB_proceso.Items.Remove("Cuadro_Magico");
                        CB_iniciado.Items.Add("Cuadro_Magico");
                        break;
                    }
                case "coordenadas_Del_lazo":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:/Users/rojas/Desktop/Procesos/Procesos/programas/knotornot.jar", "knotornot.jar", "coordenadas_Del_lazo", pros));
                        CB_proceso.Items.Remove("coordenadas_Del_lazo");
                        CB_iniciado.Items.Add("coordenadas_Del_lazo");
                        break;
                    }
                case "nombre_de_la_figura":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:/Users/rojas/Desktop/Procesos/Procesos/programas/main.exe", "main.exe", "nombre de la figura", pros));
                        CB_proceso.Items.Remove("nombre_de_la_figura");
                        CB_iniciado.Items.Add("nombre_de_la_figura");
                        break;
                    }
                case "bingo":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:/Users/rojas/Desktop/Procesos/Procesos/programas/ProyectoBingo.jar", "ProyectoBingo.jar", "bingo", pros));
                        CB_proceso.Items.Remove("bingo");
                        CB_iniciado.Items.Add("bingo");
                        break;
                    }
                case "Matriz_Final":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:/Users/rojas/Desktop/Procesos/Procesos/programas/ProyectoMatriz_Final.jar", "ProyectoMatriz_Final.jar", "Matriz_Final", pros));
                        CB_proceso.Items.Remove("Matriz_Final");
                        CB_iniciado.Items.Add("Matriz_Final");
                        break;
                    }
                case "sudoku4por4_ojo":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:/Users/rojas/Desktop/Procesos/Procesos/programas/sudoku4por4.jar", "sudoku4por4.jar", "sudoku4por4_ojo", pros));
                        CB_proceso.Items.Remove("sudoku4por4_ojo");
                        CB_iniciado.Items.Add("sudoku4por4_ojo");
                        break;
                    }
                case "numero_de_pruebas_ojo":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:/Users/rojas/Desktop/Procesos/Procesos/programas/JavaApplication1.jar", "JavaApplication1.jar", "numero_de_pruebas_ojo", pros));
                        CB_proceso.Items.Remove("numero_de_pruebas_ojo");
                        CB_iniciado.Items.Add("numero_de_pruebas_ojo");
                        break;
                    }
            }

        }

        private void B_pause_Click(object sender, EventArgs e)
        {
            CB_pausado.Text = "";
            CB_iniciado.Text = "";
            CB_finalizado.Text = "";
            int columna = pros.Count;
            string proceso = CB_iniciado.SelectedItem.ToString();
            foreach (Info_proceso info in pros)
            {
                Info_proceso informacion = new Info_proceso();
                if (proceso== info.Nombre)
                {
                    int indice = Funciones.SearchProceso(ColaProcesos, int.Parse(info.Indice));

                    Process Temp = Process.GetProcessById(int.Parse(info.Indice));
                    Funciones.Suspend(Temp);
                    informacion.Indice = info.Indice;
                    informacion.Nombre = info.Nombre;
                    informacion.Url = info.Url;
                    CB_iniciado.Items.Remove(info.Nombre);
                    CB_pausado.Items.Add(info.Nombre);
                    
                }
                }
        }

        private void B_finalizar_Click(object sender, EventArgs e)
        {
           
            string proceso = CB_iniciado.SelectedItem.ToString();
            foreach (Info_proceso info in pros)
            {
               
                if (proceso == info.Nombre)
                {
                    int indice = Funciones.SearchProceso(ColaProcesos, int.Parse(info.Indice));
                    Process temp = Process.GetProcessById(int.Parse(info.Indice));
                    temp.Kill();
                    ColaProcesos.Remove(temp);
                  
                    CB_finalizado.Items.Add(info.Nombre);
                    CB_iniciado.Items.Remove(info.Nombre);

                }
            }
            CB_pausado.Text = "";
            CB_iniciado.Text = "";
            CB_finalizado.Text = "";

        }

        private void B_continuar_Click(object sender, EventArgs e)
        {

            string proceso = CB_pausado.SelectedItem.ToString();

            foreach (Info_proceso info in pros)
            {

                if (proceso == info.Nombre)
                {
                    int indice = Funciones.SearchProceso(ColaProcesos, int.Parse(info.Indice));
                    Process Temp = Process.GetProcessById(int.Parse(info.Indice));
                    Funciones.Resume(Temp);

                    CB_pausado.Items.Remove(info.Nombre);
                    CB_iniciado.Items.Add(info.Nombre);

                }
            }
            CB_pausado.Text = "";
            CB_iniciado.Text = "";
            CB_finalizado.Text = "";
        }

      

        private void B_finalizado_Click(object sender, EventArgs e)
        {
            string proceso = CB_pausado.SelectedItem.ToString();

            foreach (Info_proceso info in pros)
            {

                if (proceso == info.Nombre)
                {
                    int indice = Funciones.SearchProceso(ColaProcesos, int.Parse(info.Indice));
                    Process temp = Process.GetProcessById(int.Parse(info.Indice));
                    temp.Kill();
                    ColaProcesos.Remove(temp);

                    CB_finalizado.Items.Add(info.Nombre);
                    CB_pausado.Items.Remove(info.Nombre);

                }
            }
            CB_pausado.Text = "";
            CB_iniciado.Text = "";
            CB_finalizado.Text = "";
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
