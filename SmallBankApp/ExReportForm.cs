using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallBankApp
{
    public partial class ExReportForm : Form
    {
        public ExReportForm()
        {
            InitializeComponent();
        }

        private void ExReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "SmallBankDataSet.FizFaces". При необходимости она может быть перемещена или удалена.
            this.FizFacesTableAdapter.Fill(this.SmallBankDataSet.FizFaces);

            this.reportViewer1.RefreshReport();
        }
    }
}
