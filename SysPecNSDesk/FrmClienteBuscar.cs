using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmClienteBuscar : Form
    {
        public FrmClienteBuscar()
        {
            InitializeComponent();
        }

        private void dgvItensPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Close();
        }

        private void FrmClienteBuscar_Load(object sender, EventArgs e)
        {

        }
    }
}
