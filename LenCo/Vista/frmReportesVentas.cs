using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LenCo.Vista
{
    public partial class frmReportesVentas : Form
    {
        public frmReportesVentas(DataTable dt)
        {
            InitializeComponent();
            dgvReporte.DataSource = dt;
        }
    }
}
