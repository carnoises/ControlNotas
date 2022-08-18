using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlNotas
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            #region Validar Controles
            //Validar campo alumno
            if (txtAlumno.Text == String.Empty)
            {
                epError.SetError(txtAlumno, "El campo ALUMNO es obligatorio.");
                return;
            }
            if (Information.IsNumeric(txtAlumno.Text))
            {
                epError.SetError(txtAlumno, "El campo ALUMNO solo permite letras.");
                return;
            }
            else
            {
                epError.Clear();
            }

            //Validar campo nota 1
            if (txtNota1.Text == String.Empty)
            {
                epError.SetError(txtNota1, "El campo NOTA 1 es obligatorio.");
                return;
            }
            if (!Information.IsNumeric(txtNota1.Text))
            {
                epError.SetError(txtNota1, "El campo NOTA 1 solo permite numeros.");
                return;
            }
            double nota1 = double.Parse(txtNota1.Text);
            if (nota1 > 15)
            {
                epError.SetError(txtNota1, "Solo es permitido numeros menor de 15.");
                return;
            }
            else
            {
                epError.Clear();
            }

            //Validar campo nota 2
            if (txtNota2.Text == String.Empty)
            {
                epError.SetError(txtNota2, "El campo NOTA 2 es obligatorio.");
                return;
            }
            if (!Information.IsNumeric(txtNota2.Text))
            {
                epError.SetError(txtNota2, "El campo NOTA 2 solo permite numeros.");
                return;
            }
            double nota2 = double.Parse(txtNota2.Text);
            if (nota2 > 15)
            {
                epError.SetError(txtNota2, "Solo es permitido numeros menor de 15.");
                return;
            }
            else
            {
                epError.Clear();
            }

            //Validar campo nota 3
            if (txtNota3.Text == String.Empty)
            {
                epError.SetError(txtNota3, "El campo NOTA 3 es obligatorio.");
                return;
            }
            if (!Information.IsNumeric(txtNota3.Text))
            {
                epError.SetError(txtNota3, "El campo NOTA 3 solo permite numeros.");
                return;
            }
            double nota3 = double.Parse(txtNota3.Text);
            if (nota3 > 15)
            {
                epError.SetError(txtNota3, "Solo es permitido numeros menor de 15.");
                return;
            }
            else
            {
                epError.Clear();
            }

            //Validar campo nota 4
            if (txtNota4.Text == String.Empty)
            {
                epError.SetError(txtNota4, "El campo NOTA 4 es obligatorio.");
                return;
            }
            if (!Information.IsNumeric(txtNota4.Text))
            {
                epError.SetError(txtNota4, "El campo NOTA 4 solo permite numeros.");
                return;
            }
            double nota4 = double.Parse(txtNota4.Text);
            if (nota4 > 15)
            {
                epError.SetError(txtNota4, "Solo es permitido numeros menor de 15.");
                return;
            }
            else
            {
                epError.Clear();
            }
            #endregion
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Salir", "Esta seguro de salir?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarControles();
            }
        }

        private void LimpiarControles()
        {
            txtAlumno.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            epError.Clear();
            txtAlumno.Focus();
        }

    }
}
