using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreria_tabla;
namespace ventana_tabla
{
    public partial class frmTabla : Form
    {
        public frmTabla()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Tabla algo = new Tabla();
            algo.p_numero = Convert.ToInt32(txtTabla.Text);
            lstTablita.Items.Clear();
            algo.multiplicar(lstTablita);
        }
    }
}
