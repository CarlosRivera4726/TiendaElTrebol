using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElTrebol.Models.Usuarios
{
    internal class AdministradorModel : EmpleadoModel
    {
        public AdministradorModel()
        {

        }

        public AdministradorModel(int id, string nombre, string apellido, string usuario, string clave)
        {
            _id = id;
            _iniciaSesion = true;
            _registraFactura = true;
            _nombre = nombre;
            _apellido = apellido;
            _usuario = usuario;
            _clave = clave;
        }

    }
}
