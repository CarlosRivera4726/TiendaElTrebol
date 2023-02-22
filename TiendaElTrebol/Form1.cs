using TiendaElTrebol.Models.Usuarios;

namespace TiendaElTrebol
{
    public partial class Form1 : Form
    {
        private string defaultUser = "administrator";
        private string defaultPassword = "1234";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            AdministradorModel admin = new AdministradorModel();
            MessageBox.Show(admin.Id.ToString(), "Hola");
            admin.Usuario = this.txtUsuario.Text;

            if (admin.Usuario == defaultUser)
            {
                admin.Clave = this.txtPassword.Text;
                if(admin.Clave == defaultPassword)
                {
                    MessageBox.Show("Has Iniciado sesion", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblError.Visible = false;
                    lblError.Text = "";
                }
                else
                {
                    lblError.Text = "La contraseña no corresponde con el usuario escrito!";
                    lblError.Visible = true;
                }
            }
            else
            {
                var result = MessageBox.Show("No has podido iniciar sesión", "Incorrecto", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                lblError.Text = "Usuario no registrado o escrito incorrectamente";
                lblError.Visible = true;
            }
        }
    }
}