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
                case "Matriz":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:Users/rojas/Downloads/sistemas operativos/Notacion_Infija_Postfija-master/dist/NotacionPolaca.jar", "NotacionPolaca.jar","Matriz",pros));
                        CB_proceso.Items.Remove("Matriz");
                        CB_iniciado.Items.Add("Matriz");
                        break;
                    }
                case "suma":
                    {
                        ColaProcesos.Add(Funciones.CreateProcess("D:/Users/rojas/Downloads/sistemas operativos/suma/dist/suma.jar", "suma.jar", "suma", pros));
                        CB_proceso.Items.Remove("suma");
                        CB_iniciado.Items.Add("suma");
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
