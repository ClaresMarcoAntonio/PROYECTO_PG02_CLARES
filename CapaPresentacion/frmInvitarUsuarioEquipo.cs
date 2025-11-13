using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmInvitarUsuarioEquipo : Form
    {
        //VARIABLE GLOBAL PARA USARLA EN TODO EL FORMULARIO
        private string IDEquipo_;

        //INICIAMOS EL FORMULARIO PASANDO EL VALOR DEL IDEQUIPO
        public frmInvitarUsuarioEquipo(string IDEquipo)
        {
            InitializeComponent();
            IDEquipo_ = IDEquipo;
            txtEquipo.Text = IDEquipo_;
        }

        private void frmInvitarUsuarioEquipo_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string NombreUsuario = txtNomUsuario.Text;
        }
    }
}
