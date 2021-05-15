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
    public partial class DepForm : Form, ICRUDForm
    {
        public DepForm()
        {
            InitializeComponent();
        }

        private void DepForm_Load(object sender, EventArgs e)
        {
           
            
            this.fizFacesTableAdapter1.Fill(this.smallBankDataSet.FizFaces);
            this.dicTarifDepTableAdapter.Fill(this.smallBankDataSet.DicTarifDep);
            this.urFacesTableAdapter1.Fill(this.smallBankDataSet.UrFaces);
            this.depositsTableAdapter.Fill(this.smallBankDataSet.Deposits);
            IdComboBox.SelectedIndex = -1;
            TarifComboBox.SelectedIndex = -1;
            DepModel.Reset();


        }
        public static class DepModel
        {
            public static int IdDep { get; set; }
            public static int IdClient { get; set; }
            public static decimal Sum { get; set; }

            public static DateTime DateStart { get; set; }
            public static DateTime DateEnd { get; set; }
            public static int IdTarif { get; set; }


            public static void Reset()
            {
                IdClient = -1;
                Sum = -1;
                
                DateStart = DateTime.Now;
                DateEnd = DateTime.Now;
                IdTarif = -1;
            }
        }

        
    
        private void CancelButton_Click(object sender, EventArgs e)
            {
                FormsForm form = new FormsForm();
                form.Show();
                this.Close();
            }

        private void IdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IdComboBox.SelectedIndex != -1)
            {
                DepModel.IdDep = Convert.ToInt32(IdComboBox.Text);
                DepModel.IdClient = depositsTableAdapter.GetData().First(t => t.IdDep == Convert.ToInt32(IdComboBox.Text)).IdClient;
                DepModel.IdTarif = depositsTableAdapter.GetData().First(t => t.IdDep == Convert.ToInt32(IdComboBox.Text)).IdTarif;
                DepModel.Sum = depositsTableAdapter.GetData().First(t => t.IdDep == Convert.ToInt32(IdComboBox.Text)).Summ;
                DepModel.DateStart = depositsTableAdapter.GetData().First(t => t.IdDep == Convert.ToInt32(IdComboBox.Text)).DateStart;
                DepModel.DateEnd = depositsTableAdapter.GetData().First(t => t.IdDep == Convert.ToInt32(IdComboBox.Text)).DateExp;
  
                updateInputs();

            }
        }

        public void updateView()
        {
            throw new NotImplementedException();
        }

        public void insertRow()
        {
            throw new NotImplementedException();
        }

        public void deleteRow()
        {
            throw new NotImplementedException();
        }

        public void updateRow()
        {
            depositsTableAdapter.Update(DepModel.IdClient, Convert.ToDecimal(SumTextBox.Text),  StartDateTimePicker.Value, EndDateTimePicker.Value, dicTarifDepTableAdapter.GetData().First(t => t.Name == TarifComboBox.Text).IdTarif,
                DepModel.IdDep, DepModel.IdClient, DepModel.Sum,  DepModel.DateStart, DepModel.DateEnd, DepModel.IdTarif);
        }

        public void updateInputs()
        {
            if (isIncorrectModel())
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                if (fizFacesTableAdapter1.GetData().FirstOrDefault(t => t.IdClient == DepModel.IdClient) != null)
                    SurTextBox.Text = fizFacesTableAdapter1.GetData().First(t => t.IdClient == DepModel.IdClient).Surname + " "
                            + fizFacesTableAdapter1.GetData().First(t => t.IdClient == DepModel.IdClient).Name + " "
                            + fizFacesTableAdapter1.GetData().First(t => t.IdClient == DepModel.IdClient).Patronymic;
                else
                    SurTextBox.Text = urFacesTableAdapter1.GetData().First(t => t.IdClient == DepModel.IdClient).Name;
                SumTextBox.Text = DepModel.Sum.ToString();
                StartDateTimePicker.Value = DepModel.DateStart;
                EndDateTimePicker.Value = DepModel.DateEnd;
                TarifComboBox.SelectedIndex = TarifComboBox.FindString(dicTarifDepTableAdapter.GetData().First(t => t.IdTarif == DepModel.IdTarif).Name);
            }


        }

        public void clearInputs()
        {
            throw new NotImplementedException();
        }

        public bool isIncorrectModel()
        {
            return DepModel.IdClient < 0 || DepModel.IdDep < 0 || DepModel.IdTarif < 0 || DepModel.Sum < 0;
        }

        public bool isIncorrectInputs()
        {
            return SumTextBox.Text == "" || SumTextBox.Text == "" ||  StartDateTimePicker.Value >= EndDateTimePicker.Value || TarifComboBox.SelectedIndex < 0 || IdComboBox.SelectedIndex < 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            updateRow();
            var temp = IdComboBox.SelectedIndex;
            IdComboBox.SelectedIndex = -1;
            IdComboBox.SelectedIndex = temp;
            MessageBox.Show("Данные сохранены");
        }
    }
}
