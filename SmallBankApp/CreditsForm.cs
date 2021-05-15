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
    public partial class CreditsForm : Form, ICRUDForm
    {
        public CreditsForm()
        {
            InitializeComponent();
        }

        private void CreditsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.DicTarifCred". При необходимости она может быть перемещена или удалена.
            this.dicTarifCredTableAdapter.Fill(this.smallBankDataSet.DicTarifCred);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.Credits". При необходимости она может быть перемещена или удалена.
            this.creditsTableAdapter.Fill(this.smallBankDataSet.Credits);
            this.fizFacesTableAdapter1.Fill(this.smallBankDataSet.FizFaces);
            this.urFacesTableAdapter1.Fill(this.smallBankDataSet.UrFaces);
            IdComboBox.SelectedIndex = -1;
            TarifComboBox.SelectedIndex = -1;
            CreditModel.Reset();


        }
        public static class CreditModel
        {
            public static int IdCred { get; set; }
            public static int IdClient { get; set; }
            public static decimal Sum { get; set; }
            public static decimal Rest { get; set; }
            public static DateTime DateStart { get; set; }
            public static DateTime DateEnd { get; set; }
            public static int IdTarif { get; set; }


            public static void Reset()
            {
                IdClient = -1;
                Sum = -1;
                Rest = -1;
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
                CreditModel.IdCred = Convert.ToInt32(IdComboBox.Text);
                CreditModel.IdClient = creditsTableAdapter.GetData().First(t => t.IdCred == Convert.ToInt32(IdComboBox.Text)).IdClient;
                CreditModel.IdTarif = creditsTableAdapter.GetData().First(t => t.IdCred == Convert.ToInt32(IdComboBox.Text)).IdTarif;
                CreditModel.Sum = creditsTableAdapter.GetData().First(t => t.IdCred == Convert.ToInt32(IdComboBox.Text)).Summ;
                CreditModel.DateStart = creditsTableAdapter.GetData().First(t => t.IdCred == Convert.ToInt32(IdComboBox.Text)).DateStart;
                CreditModel.DateEnd = creditsTableAdapter.GetData().First(t => t.IdCred == Convert.ToInt32(IdComboBox.Text)).DateExp;
                CreditModel.Rest = creditsTableAdapter.GetData().First(t => t.IdCred == Convert.ToInt32(IdComboBox.Text)).Rest;
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
            creditsTableAdapter.Update(CreditModel.IdClient, Convert.ToDecimal(SumTextBox.Text), Convert.ToDecimal(RestTextBox.Text), StartDateTimePicker.Value, EndDateTimePicker.Value, dicTarifCredTableAdapter.GetData().First(t => t.Name == TarifComboBox.Text).IdTarif,
                CreditModel.IdCred, CreditModel.IdClient, CreditModel.Sum, CreditModel.Rest, CreditModel.DateStart, CreditModel.DateEnd, CreditModel.IdTarif);
        }

        public void updateInputs()
        {
            if (isIncorrectModel())
            {
                MessageBox.Show("Ошибка");
            }
            else
            {
                if (fizFacesTableAdapter1.GetData().FirstOrDefault(t => t.IdClient == CreditModel.IdClient) != null)
                    SurTextBox.Text = fizFacesTableAdapter1.GetData().First(t => t.IdClient == CreditModel.IdClient).Surname + " "
                            + fizFacesTableAdapter1.GetData().First(t => t.IdClient == CreditModel.IdClient).Name + " "
                            + fizFacesTableAdapter1.GetData().First(t => t.IdClient == CreditModel.IdClient).Patronymic;
                else
                    SurTextBox.Text = urFacesTableAdapter1.GetData().First(t => t.IdClient == CreditModel.IdClient).Name;
                SumTextBox.Text = CreditModel.Sum.ToString();
                RestTextBox.Text = CreditModel.Rest.ToString();
                StartDateTimePicker.Value = CreditModel.DateStart;
                EndDateTimePicker.Value = CreditModel.DateEnd;
                TarifComboBox.SelectedIndex = TarifComboBox.FindString(dicTarifCredTableAdapter.GetData().First(t => t.IdTarif == CreditModel.IdTarif).Name);
            }
               

        }

        public void clearInputs()
        {
            throw new NotImplementedException();
        }

        public bool isIncorrectModel()
        {
            return CreditModel.IdClient < 0 || CreditModel.IdCred < 0 || CreditModel.IdTarif < 0 || CreditModel.Rest < 0 || CreditModel.Sum < 0;
        }

        public bool isIncorrectInputs()
        {
            return SumTextBox.Text == "" ||  SumTextBox.Text == "" || RestTextBox.Text == "" || StartDateTimePicker.Value >= EndDateTimePicker.Value || TarifComboBox.SelectedIndex < 0 || IdComboBox.SelectedIndex < 0;
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
