



namespace Procesos
{

    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CB_iniciado = new System.Windows.Forms.ComboBox();
            this.CB_pausado = new System.Windows.Forms.ComboBox();
            this.CB_finalizado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.B_continuar = new System.Windows.Forms.Button();
            this.B_pause = new System.Windows.Forms.Button();
            this.B_finalizar = new System.Windows.Forms.Button();
            this.B_finalizado = new System.Windows.Forms.Button();
            this.CB_proceso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(361, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROCESOS SO";
            // 
            // CB_iniciado
            // 
            this.CB_iniciado.FormattingEnabled = true;
            this.CB_iniciado.Location = new System.Drawing.Point(276, 243);
            this.CB_iniciado.Name = "CB_iniciado";
            this.CB_iniciado.Size = new System.Drawing.Size(305, 33);
            this.CB_iniciado.TabIndex = 1;
            // 
            // CB_pausado
            // 
            this.CB_pausado.FormattingEnabled = true;
            this.CB_pausado.Location = new System.Drawing.Point(276, 299);
            this.CB_pausado.Name = "CB_pausado";
            this.CB_pausado.Size = new System.Drawing.Size(305, 33);
            this.CB_pausado.TabIndex = 2;
            // 
            // CB_finalizado
            // 
            this.CB_finalizado.FormattingEnabled = true;
            this.CB_finalizado.Location = new System.Drawing.Point(276, 367);
            this.CB_finalizado.Name = "CB_finalizado";
            this.CB_finalizado.Size = new System.Drawing.Size(305, 33);
            this.CB_finalizado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Procesos iniciados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Procesos pausados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Procesos Finalizados";
            // 
            // B_continuar
            // 
            this.B_continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.B_continuar.Location = new System.Drawing.Point(612, 299);
            this.B_continuar.Name = "B_continuar";
            this.B_continuar.Size = new System.Drawing.Size(120, 32);
            this.B_continuar.TabIndex = 7;
            this.B_continuar.Text = "Continuar";
            this.B_continuar.UseVisualStyleBackColor = false;
            this.B_continuar.Click += new System.EventHandler(this.B_continuar_Click);
            // 
            // B_pause
            // 
            this.B_pause.BackColor = System.Drawing.Color.Fuchsia;
            this.B_pause.Location = new System.Drawing.Point(612, 240);
            this.B_pause.Name = "B_pause";
            this.B_pause.Size = new System.Drawing.Size(95, 33);
            this.B_pause.TabIndex = 8;
            this.B_pause.Text = "Pausar";
            this.B_pause.UseVisualStyleBackColor = false;
            this.B_pause.Click += new System.EventHandler(this.B_pause_Click);
            // 
            // B_finalizar
            // 
            this.B_finalizar.BackColor = System.Drawing.Color.Red;
            this.B_finalizar.Location = new System.Drawing.Point(741, 241);
            this.B_finalizar.Name = "B_finalizar";
            this.B_finalizar.Size = new System.Drawing.Size(98, 32);
            this.B_finalizar.TabIndex = 9;
            this.B_finalizar.Text = "Finalizar";
            this.B_finalizar.UseVisualStyleBackColor = false;
            this.B_finalizar.Click += new System.EventHandler(this.B_finalizar_Click);
            // 
            // B_finalizado
            // 
            this.B_finalizado.BackColor = System.Drawing.Color.Red;
            this.B_finalizado.Location = new System.Drawing.Point(751, 299);
            this.B_finalizado.Name = "B_finalizado";
            this.B_finalizado.Size = new System.Drawing.Size(98, 32);
            this.B_finalizado.TabIndex = 10;
            this.B_finalizado.Text = "Finalizar";
            this.B_finalizado.UseVisualStyleBackColor = false;
            this.B_finalizado.Click += new System.EventHandler(this.B_finalizado_Click);
            // 
            // CB_proceso
            // 
            this.CB_proceso.FormattingEnabled = true;
            this.CB_proceso.Items.AddRange(new object[] {
            "Cuadro_Magico",
            "coordenadas_Del_lazo",
            "nombre_de_la_figura",
            "bingo",
            "Matriz_Final",
            "domino",
            "sudoku4por4",
            "numero_de_pruebas"});
            this.CB_proceso.Location = new System.Drawing.Point(264, 126);
            this.CB_proceso.Name = "CB_proceso";
            this.CB_proceso.Size = new System.Drawing.Size(317, 33);
            this.CB_proceso.TabIndex = 11;
            //this.CB_proceso.SelectedIndexChanged += new System.EventHandler(this.CB_proceso_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Procesos ";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(669, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 31);
            this.button5.TabIndex = 13;
            this.button5.Text = "Iniciar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(895, 463);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CB_proceso);
            this.Controls.Add(this.B_finalizado);
            this.Controls.Add(this.B_finalizar);
            this.Controls.Add(this.B_pause);
            this.Controls.Add(this.B_continuar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_finalizado);
            this.Controls.Add(this.CB_pausado);
            this.Controls.Add(this.CB_iniciado);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_iniciado;
        private System.Windows.Forms.ComboBox CB_pausado;
        private System.Windows.Forms.ComboBox CB_finalizado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button B_continuar;
        private System.Windows.Forms.Button B_pause;
        private System.Windows.Forms.Button B_finalizar;
        private System.Windows.Forms.Button B_finalizado;
        private System.Windows.Forms.ComboBox CB_proceso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
    }
}