using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPecas
{
    public partial class frmControlePecaProduzidas : Form
    {
        public frmControlePecaProduzidas()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void mtxtData_Leave(object sender, EventArgs e)
        {
            if (DateTime.Parse(mtxtData.Text) > System.DateTime.Now)
            {
                MessageBox.Show("A data não pode ser futura!");
                mtxtData.ResetText();
                mtxtData.Focus();
            }
        }

        private void frmControlePecaProduzidas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCheckPecasDataSet.tblPecas' table. You can move, or remove it, as needed.
            this.tblPecasTableAdapter.Fill(this.dbCheckPecasDataSet.tblPecas);
            mtxtData.Focus();
        }
    }
}
