using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaElTrebol.Models.Usuarios
{
    internal class UsuarioModel
    {

        protected bool _iniciaSesion { get; set; }
        protected bool _registraFactura { get; set; }
        protected int _id { get; set; }
        protected string _nombre { get; set; }
        protected string _apellido { get; set; }
        protected string _usuario { get; set; }
        protected string _clave { get; set; }
        protected string _rol { get; set; }

        // Constructor
        public UsuarioModel()
        {
            _iniciaSesion = false;
            _registraFactura = false;
            _id = 0;
            _nombre = "Default";
            _apellido = "User";
            _usuario = "Default";
            _clave = "1234";
        }

        protected UsuarioModel(int id, string nombre, string apellido, string usuario, string clave, string rol)
        {
            _iniciaSesion = false;
            _registraFactura = false;
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _usuario = usuario;
            _clave = clave;
            _rol = rol;
        }


        protected int GetNextID() => ++_id;

        //getters and setters
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }
        public string Apellido
        {
            get => _apellido;
            set => _apellido = value;
        }
        public string Usuario
        {
            get => _usuario;
            set => _usuario = value;
        }
        public string Clave
        {
            get => _clave;
            set => _clave = value;
        }

        protected bool IniciarSesion
        {
            get => _iniciaSesion;
            set => _iniciaSesion = value;
        }
        protected bool RegistrarFactura
        {
            get => _registraFactura;
            set => _registraFactura = value;
        }


    }
}
