﻿namespace AerolineaFrba.Forms.Devolucion {
    partial class Devolucion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dniLabel = new System.Windows.Forms.Label();
            this.dniTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.apellidoTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pasajesDatagrid = new System.Windows.Forms.DataGridView();
            this.buscarButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.devolucionPasajeButton = new System.Windows.Forms.Button();
            this.devolucionEncomiendaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pasajesDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.Location = new System.Drawing.Point(23, 43);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(29, 13);
            this.dniLabel.TabIndex = 0;
            this.dniLabel.Text = "DNI:";
            // 
            // dniTextbox
            // 
            this.dniTextbox.Location = new System.Drawing.Point(58, 40);
            this.dniTextbox.Name = "dniTextbox";
            this.dniTextbox.Size = new System.Drawing.Size(149, 20);
            this.dniTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // nombreTextbox
            // 
            this.nombreTextbox.Location = new System.Drawing.Point(288, 40);
            this.nombreTextbox.Name = "nombreTextbox";
            this.nombreTextbox.Size = new System.Drawing.Size(149, 20);
            this.nombreTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellido:";
            // 
            // apellidoTextbox
            // 
            this.apellidoTextbox.Location = new System.Drawing.Point(522, 40);
            this.apellidoTextbox.Name = "apellidoTextbox";
            this.apellidoTextbox.Size = new System.Drawing.Size(149, 20);
            this.apellidoTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pasajes";
            // 
            // pasajesDatagrid
            // 
            this.pasajesDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pasajesDatagrid.Location = new System.Drawing.Point(27, 112);
            this.pasajesDatagrid.Name = "pasajesDatagrid";
            this.pasajesDatagrid.Size = new System.Drawing.Size(707, 150);
            this.pasajesDatagrid.TabIndex = 7;
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(714, 26);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(119, 47);
            this.buscarButton.TabIndex = 8;
            this.buscarButton.Text = "Buscar pasajes y encomiendas";
            this.buscarButton.UseVisualStyleBackColor = true;
            this.buscarButton.Click += new System.EventHandler(this.buscarButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Encomiendas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 150);
            this.dataGridView1.TabIndex = 10;
            // 
            // devolucionPasajeButton
            // 
            this.devolucionPasajeButton.Location = new System.Drawing.Point(740, 166);
            this.devolucionPasajeButton.Name = "devolucionPasajeButton";
            this.devolucionPasajeButton.Size = new System.Drawing.Size(96, 39);
            this.devolucionPasajeButton.TabIndex = 11;
            this.devolucionPasajeButton.Text = "Devolución";
            this.devolucionPasajeButton.UseVisualStyleBackColor = true;
            this.devolucionPasajeButton.Click += new System.EventHandler(this.devolucionPasajeButton_Click);
            // 
            // devolucionEncomiendaButton
            // 
            this.devolucionEncomiendaButton.Location = new System.Drawing.Point(740, 371);
            this.devolucionEncomiendaButton.Name = "devolucionEncomiendaButton";
            this.devolucionEncomiendaButton.Size = new System.Drawing.Size(96, 40);
            this.devolucionEncomiendaButton.TabIndex = 12;
            this.devolucionEncomiendaButton.Text = "Devolución";
            this.devolucionEncomiendaButton.UseVisualStyleBackColor = true;
            this.devolucionEncomiendaButton.Click += new System.EventHandler(this.devolucionEncomiendaButton_Click);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 518);
            this.Controls.Add(this.devolucionEncomiendaButton);
            this.Controls.Add(this.devolucionPasajeButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.pasajesDatagrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apellidoTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dniTextbox);
            this.Controls.Add(this.dniLabel);
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            ((System.ComponentModel.ISupportInitialize)(this.pasajesDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.TextBox dniTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidoTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView pasajesDatagrid;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button devolucionPasajeButton;
        private System.Windows.Forms.Button devolucionEncomiendaButton;
    }
}