using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TiendaElTrebol.Models.Usuarios
{
    internal class EmpleadoModel : UsuarioModel
    {
        public EmpleadoModel()
        {
            _iniciaSesion = true;
            _registraFactura = true;
        }

        public EmpleadoModel(string nombre, string apellido, string usuario, string clave)
        {
            _iniciaSesion = true;
            _registraFactura = true;
            _nombre = nombre;
            _apellido = apellido;
            _usuario = usuario;
            _clave = clave;
        }
    }
}
