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

        public DCFizFaces()
        {
            InitializeComponent();
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
            ClientModel.Name = ClientsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ClientModel.Surname = ClientsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ClientModel.Patronymic = ClientsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            string query = "SELECT * FROM Deposits WHERE IdClient = " + ClientModel.id;
            DepGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);

            query = "SELECT * FROM Credits WHERE IdClient = " + ClientModel.id;
            CredGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);

            updateInputs();
        }
    }
}
