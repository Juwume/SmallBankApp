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
    public partial class DCFizFaces : Form, ICRUDForm
    {
        private static class ClientModel
        {
            public static int id { get; set; }
            public static string Name { get; set; }
            public static string Surname { get; set; }
            public static string Patronymic { get; set; }

            public static void reset()
            {
                id = -1;
                Name = "";
                Surname = "";
                Patronymic = "";
            }
        }

        public bool IsDep { get; set; }
        public bool IsReady { get; set; }

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
                Sum = 0;
                Rest = 0;
                DateStart = DateTime.Now;
                DateEnd = DateTime.Now;
                IdTarif = -1;
            }
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
                Sum = 0;
                DateStart = DateTime.Now;
                DateEnd = DateTime.Now;
                IdTarif = -1;
            }
        }


        public DCFizFaces()
        {
            InitializeComponent();
            CreditModel.Reset();
            DepModel.Reset();
            ClientModel.reset();

        }

        private void DCFizFaces_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.FizFaces". При необходимости она может быть перемещена или удалена.
            this.fizFacesTableAdapter.Fill(this.smallBankDataSet.FizFaces);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.Credits". При необходимости она может быть перемещена или удалена.
            //this.creditsTableAdapter.Fill(this.smallBankDataSet.Credits);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.Deposits". При необходимости она может быть перемещена или удалена.
            //this.depositsTableAdapter.Fill(this.smallBankDataSet.Deposits);

        }

        public void updateView()
        {
            depositsTableAdapter.Fill(smallBankDataSet.Deposits);
            depositsBindingSource.ResetBindings(false);
            DepGridView.Update();

            creditsTableAdapter.Fill(smallBankDataSet.Credits);
            creditsBindingSource.ResetBindings(false);
            CredGridView.Update();
        }

        public void insertRow()
        {
            
        }

        public void deleteRow()
        {
            
        }

        public void updateRow()
        {
            
        }

        public void updateInputs()
        {
            NameTextBox.Text = ClientModel.Name;
            SurTextBox.Text = ClientModel.Surname;
            PatTextBox.Text = ClientModel.Patronymic;
                
        }

        public void clearInputs()
        {
            NameTextBox.Text = "";
            SurTextBox.Text = "";
            PatTextBox.Text = "";
        }

        public bool isIncorrectModel()
        {
            return ClientModel.id < 0 || ClientModel.Name == "" || ClientModel.Surname == "" || ClientModel.Patronymic == "";
        }

        public bool isIncorrectInputs()
        {
            return NameTextBox.Text == "" || SurTextBox.Text == "" || PatTextBox.Text == "";
        }


        private void ClientsGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClientModel.id = Convert.ToInt32(ClientsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            ClientModel.Surname = ClientsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ClientModel.Name = ClientsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();      
            ClientModel.Patronymic = ClientsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            string query = "SELECT * FROM Deposits WHERE IdClient = " + ClientModel.id;
            DepGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);

            query = "SELECT * FROM Credits WHERE IdClient = " + ClientModel.id;
            CredGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);

            updateInputs();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void AddDepButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs() || isIncorrectModel())
            {
                MessageBox.Show("Некоректные данные");
            }
            else
            {
                AddDepForm addDepForm = new AddDepForm();
                addDepForm.Id = ClientModel.id;
                addDepForm.Surname = ClientModel.Surname;
                addDepForm.ptr = this;
                addDepForm.ShowDialog();
            }

            
        }

 

        private void DCFizFaces_Click(object sender, EventArgs e)
        {
            ClientModel.reset();
            DepModel.Reset();
            CreditModel.Reset();
            clearInputs();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FormsForm form = new FormsForm();
            form.Show();
            this.Close();

        }

        private void DCFizFaces_Activated(object sender, EventArgs e)
        {
            if (IsReady)
            {
                if (IsDep)
                {
                    this.depositsTableAdapter.Fill(this.smallBankDataSet.Deposits);
                    depositsTableAdapter.Insert(DepModel.IdClient, DepModel.Sum, DepModel.DateStart.Date, DepModel.DateEnd.Date, DepModel.IdTarif);
                    string query = "SELECT * FROM Deposits WHERE IdClient = " + ClientModel.id;
                    DepGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
                    updateView();

                    IsReady = false;
                }
                else
                {
                    
                    this.creditsTableAdapter.Fill(this.smallBankDataSet.Credits);
                    creditsTableAdapter.Insert(CreditModel.IdClient, CreditModel.Sum, CreditModel.Rest, CreditModel.DateStart.Date, CreditModel.DateEnd.Date, CreditModel.IdTarif);
                    string query = "SELECT * FROM Credits WHERE IdClient = " + ClientModel.id;
                    CredGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
                    updateView();

                    IsReady = false;
                }
            }
        }
        private bool IsIncorrectDepModel()
        {
            return DepModel.IdDep < 0 || DepModel.IdClient < 0 || DepModel.Sum < 0 || DepModel.IdTarif < 0;
        }
        private bool IsIncorrectCredModel()
        {
            return CreditModel.IdCred < 0 || CreditModel.IdClient < 0 || CreditModel.Sum < 0 || CreditModel.Rest < 0 || CreditModel.IdTarif < 0;
        }
        private void DelDepButton_Click(object sender, EventArgs e)
        {
            if (IsIncorrectDepModel())
                MessageBox.Show("Выберите вклад");
            else
            {
                depositsTableAdapter.Fill(smallBankDataSet.Deposits);
                depositsTableAdapter.Delete(DepModel.IdDep, DepModel.IdClient, DepModel.Sum, DepModel.DateStart, DepModel.DateEnd, DepModel.IdTarif);
                string query = "SELECT * FROM Deposits WHERE IdClient = " + ClientModel.id;
                DepGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
                updateView();
            }    
               
        }

        private void DepGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DepModel.IdDep =  Convert.ToInt32(DepGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            DepModel.IdClient = Convert.ToInt32(DepGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            DepModel.Sum = Convert.ToDecimal(DepGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            DepModel.DateStart = Convert.ToDateTime(DepGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            DepModel.DateEnd = Convert.ToDateTime(DepGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            DepModel.IdTarif = Convert.ToInt32(DepGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            
        }

        private void AddCredButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs() || isIncorrectModel())
            {
                MessageBox.Show("Некоректные данные");
            }
            else
            {
                AddCreditForm addCredForm = new AddCreditForm();
                addCredForm.Id = ClientModel.id;
                addCredForm.Surname = ClientModel.Surname;
                addCredForm.ptr = this;
                addCredForm.ShowDialog();
            }
        }

        private void CredGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CreditModel.IdCred = Convert.ToInt32(CredGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            CreditModel.IdClient = Convert.ToInt32(CredGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            CreditModel.Sum = Convert.ToDecimal(CredGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            CreditModel.Rest = Convert.ToDecimal(CredGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            CreditModel.DateStart = Convert.ToDateTime(CredGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            CreditModel.DateEnd = Convert.ToDateTime(CredGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            CreditModel.IdTarif = Convert.ToInt32(CredGridView.Rows[e.RowIndex].Cells[6].Value.ToString());
        }

        private void DelCredButton_Click(object sender, EventArgs e)
        {
            if (IsIncorrectCredModel())
                MessageBox.Show("Выберите кредит");
            else
            {
                creditsTableAdapter.Fill(smallBankDataSet.Credits);
                creditsTableAdapter.Delete(CreditModel.IdCred, CreditModel.IdClient, CreditModel.Sum, CreditModel.Rest, CreditModel.DateStart, CreditModel.DateEnd, CreditModel.IdTarif);
                string query = "SELECT * FROM Credits WHERE IdClient = " + ClientModel.id;
                CredGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
                updateView();
            }
            }
    }
}
