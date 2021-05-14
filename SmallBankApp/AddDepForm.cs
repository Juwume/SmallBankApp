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
    public partial class AddDepForm : Form
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public DCFizFaces PtrFiz {get;set;}
        public DCUrFaces PtrUr { get; set; }


        public AddDepForm()
        {
            InitializeComponent();
        }
        public bool isIncorrectInputs()
        {
            return SumTextBox.Text == "                  ," || StartDateTimePicker.Value >= EndDateTimePicker.Value || TarifComboBox.SelectedIndex < 0;
        }

        private void AddDepForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.DicTarifDep". При необходимости она может быть перемещена или удалена.
            this.dicTarifDepTableAdapter.Fill(this.smallBankDataSet.DicTarifDep);
            SurTextBox.Text = Surname;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs() || (PtrFiz == null && PtrUr == null))
            {
                MessageBox.Show("Некоректные данные");
            }
            else
            {
                if (PtrFiz != null)
                {

                    DCFizFaces.DepModel.IdClient = Id;
                    DCFizFaces.DepModel.IdTarif = dicTarifDepTableAdapter.GetData().First(t => t.Name == TarifComboBox.Text).IdTarif;
                    DCFizFaces.DepModel.Sum = Convert.ToDecimal(SumTextBox.Text);
                    DCFizFaces.DepModel.DateStart = StartDateTimePicker.Value;
                    DCFizFaces.DepModel.DateEnd = EndDateTimePicker.Value;
                    PtrFiz.IsReady = true;
                    PtrFiz.IsDep = true;
                    this.Close();
                }
                else
                {
                    DCUrFaces.DepModel.IdClient = Id;
                    DCUrFaces.DepModel.IdTarif = dicTarifDepTableAdapter.GetData().First(t => t.Name == TarifComboBox.Text).IdTarif;
                    DCUrFaces.DepModel.Sum = Convert.ToDecimal(SumTextBox.Text);
                    DCUrFaces.DepModel.DateStart = StartDateTimePicker.Value;
                    DCUrFaces.DepModel.DateEnd = EndDateTimePicker.Value;
                    PtrUr.IsReady = true;
                    PtrUr.IsDep = true;
                    this.Close();
                }

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
