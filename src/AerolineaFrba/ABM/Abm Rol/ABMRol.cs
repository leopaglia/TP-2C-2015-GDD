﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AerolineaFrba.Models;
using AerolineaFrba.Services;
using AerolineaFrba.ABM.Abm_Rol;

namespace AerolineaFrba.Abm_Rol{
    
    public sealed partial class ABMRol : Form{

        private static ABMRol _instance = null;

        private ABMRol() {
            this.InitializeComponent();
        }

        public static ABMRol getInstance() {

            if (_instance == null) {
                _instance = new ABMRol();
            }

            return _instance;

        }

        private void Nuevo_Click(object sender, EventArgs e) {

            RolDialog rolDialog = new RolDialog("", Enums.tipoDialog.nuevo);
            rolDialog.ShowDialog();

            if (rolDialog.dr == DialogResult.Cancel) return;

            String nuevaDescripcion = rolDialog.descripcion;

            DAO.connect();

            Rol rol = new Rol();
            rol.Descripcion = nuevaDescripcion;
            rol.Activo = true;
            int affected = DAO.insert<Rol>(rol);

            DAO.closeConnection();

            this.rolTableAdapter.Fill(this.dataSetRol.Rol);
            rolDataGrid.Update(); 

        }

        private void Modificar_Click(object sender, EventArgs e){

            if (this.rolDataGrid.SelectedRows.Count == 0) {
                MessageBox.Show("Debe elegir un rol a modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.rolDataGrid.SelectedRows.Count > 1) {
                MessageBox.Show("Solo puede elegir un rol a modificar a la vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataGridViewRow row = this.rolDataGrid.SelectedRows[0];

            int id = (int)row.Cells[0].Value;
            String descripcion = (String)row.Cells[1].Value;

            RolDialog rolDialog = new RolDialog(descripcion, Enums.tipoDialog.modificar);
            var dr = rolDialog.ShowDialog();

            String nuevaDescripcion = rolDialog.descripcion;

            DAO.connect();

            Rol rol = DAO.selectOne<Rol>(new[] { "id = " + id });
            rol.Descripcion = nuevaDescripcion;
            int affected = DAO.update<Rol>(rol);

            DAO.closeConnection();

            this.rolTableAdapter.Fill(this.dataSetRol.Rol); 
            rolDataGrid.Update(); 

        }

        private void Eliminar_Click(object sender, EventArgs e) {

            if (this.rolDataGrid.SelectedRows.Count == 0) {
                MessageBox.Show("Debe elegir al menos un rol a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (this.rolDataGrid.SelectedRows.Count == 1) { 
                if(MessageBox.Show("Seguro desea eliminar el rol seleccionado?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            }

            if (this.rolDataGrid.SelectedRows.Count > 1) {
                if (MessageBox.Show("Seguro desea eliminar los " + this.rolDataGrid.SelectedRows.Count + " roles seleccionados?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            }


            foreach (DataGridViewRow item in rolDataGrid.SelectedRows) {

                int id = (int)item.Cells[0].Value;

                DAO.connect();

                Rol rol = DAO.selectOne<Rol>( new[] {"id = "+id} );
                rol.Activo = false;
                int affected = DAO.update<Rol>(rol);

                DAO.closeConnection();

                this.rolTableAdapter.Fill(this.dataSetRol.Rol); 
                rolDataGrid.Update(); 

            }

        }

        private void ABMRol_Load(object sender, EventArgs e) {
            this.rolTableAdapter.Fill(this.dataSetRol.Rol);
        }

          
    }
}
