using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaElTrebol.Views.Usuarios
{
    public partial class RegistroUsuarios : Form
    {
        // rols actives: Administrator, Employee, Client, default is Employee
        // Administrator can create Administrators, Employees and  Clients
        // Employee only can create Clients.
        private string rol { get; set; }
        public RegistroUsuarios(string rol)
        {
            this.rol = rol;
            InitializeComponent();
        }


    }
}
