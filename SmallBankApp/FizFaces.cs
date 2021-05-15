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
    public partial class FizFaces : Form, ICRUDForm
    {
        public static bool IsReady = false;
        public static bool IsEdit = false;

        public static class ClientModel
        {
            public static int id { get; set; }
            public static string Name { get; set; }
            public static string Surname { get; set; }
            public static string Patronymic { get; set; }
            public static string Adress { get; set; }
            public static string INN { get; set; }
            public static bool IsResident { get; set; }
            public static int idType { get; set; }

            public static void Reset()
            {
                id = -1;
                Name = "";
                Surname = "";
                Patronymic = "";
                Adress = "";
                INN = "";
                idType = -1;
            }
        }
        private static class OldClientModel
        {
            public static int id { get; set; }
            public static string Name { get; set; }
            public static string Surname { get; set; }
            public static string Patronymic { get; set; }
            public static string Adress { get; set; }
            public static string INN { get; set; }
            public static bool IsResident { get; set; }
            public static int idType { get; set; }

            public static void Reset()
            {
                id = -1;
                Name = "";
                Surname = "";
                Patronymic = "";
                Adress = "";
                INN = "";
                idType = -1;
            }
        }

        public FizFaces()
        {
            InitializeComponent();
            
        }


     

        private void FizFaces_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.FizFaces". При необходимости она может быть перемещена или удалена.
            this.fizFacesTableAdapter.Fill(this.smallBankDataSet.FizFaces);
            SurComboBox.SelectedIndex = -1;
            OldClientModel.Reset();
            ClientModel.Reset();
        }

        private void AdressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SurComboBox.SelectedIndex < 0)
            {

                string query = "SELECT * FROM FizFaces WHERE Adress Like \"" + AdressTextBox.Text+"%\"";
                FizFacesGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            }
            else
            {
                string query = "SELECT * FROM FizFaces WHERE Adress Like \"" + AdressTextBox.Text + "%\" AND Surname = \"" + SurComboBox.Text+"\"";
                FizFacesGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            }
            
        }

        private void SurComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurComboBox.SelectedIndex != -1)
            {
                string query = "SELECT * FROM FizFaces WHERE Adress Like \"" + AdressTextBox.Text + "%\" AND Surname = \"" + SurComboBox.Text + "\"";
                FizFacesGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            }
            else
            {
                string query = "SELECT * FROM FizFaces WHERE Adress Like \"" + AdressTextBox.Text + "%\"";
                FizFacesGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            }
        }

        private void FizFacesGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            OldClientModel.id = Convert.ToInt32(FizFacesGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            OldClientModel.Surname = FizFacesGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            OldClientModel.Name = FizFacesGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            OldClientModel.Patronymic = FizFacesGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            OldClientModel.INN = FizFacesGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            OldClientModel.Adress = FizFacesGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            OldClientModel.IsResident = clientsTableAdapter1.GetData().FirstOrDefault(t => t.Id == OldClientModel.id).Resident;
            OldClientModel.idType = clientsTableAdapter1.GetData().FirstOrDefault(t => t.Id == OldClientModel.id).TypeClient;
        }

        private void AddDepButton_Click(object sender, EventArgs e)
        {
            AddClientForm addClient = new AddClientForm();
            addClient.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectOldModel())
            {
                MessageBox.Show("Выберите клиента");
            }
            else
            {
                AddClientForm addClient = new AddClientForm();
                AddClientForm.ClientModel.id = OldClientModel.id;
                AddClientForm.ClientModel.Surname = OldClientModel.Surname;
                AddClientForm.ClientModel.Name = OldClientModel.Name;
                AddClientForm.ClientModel.Patronymic = OldClientModel.Patronymic;
                AddClientForm.ClientModel.INN = OldClientModel.INN;
                AddClientForm.ClientModel.Adress = OldClientModel.Adress;
                addClient.IsEdit = true;
                addClient.ShowDialog();
            }
        }

        private void FizFaces_Activated(object sender, EventArgs e)
        {
            if (IsReady)
            {
                if (IsEdit)
                {
                    updateRow();
                }
                else
                    insertRow();
                IsReady = false;
            }
        }

        public void insertRow()
        {
            fizFacesTableAdapter.Insert(ClientModel.id, ClientModel.Surname, ClientModel.Name, ClientModel.Patronymic, ClientModel.INN, ClientModel.Adress);
            updateView();
        }

        public void deleteRow()
        {
            
            fizFacesTableAdapter.Delete(OldClientModel.id, OldClientModel.Surname, OldClientModel.Name, OldClientModel.Patronymic, OldClientModel.INN, OldClientModel.Adress);
            clientsTableAdapter1.Delete(OldClientModel.id, OldClientModel.IsResident, OldClientModel.idType);
            updateView();
        }

        public void updateRow()
        {
            fizFacesTableAdapter.Update(ClientModel.Surname, ClientModel.Name, ClientModel.Patronymic, ClientModel.INN, ClientModel.Adress,
                OldClientModel.id, OldClientModel.Surname, OldClientModel.Name, OldClientModel.Patronymic, OldClientModel.INN, OldClientModel.Adress);
            updateView();
        }

        public void updateInputs()
        {
            
        }

        public void clearInputs()
        {
            SurComboBox.SelectedIndex = -1;
            AdressTextBox.Text = " ";
            AdressTextBox.Text = "";

        }

        public bool isIncorrectModel()
        {
            return ClientModel.id < 0 || ClientModel.Adress == "" || ClientModel.Name == "" || ClientModel.Patronymic == "" || ClientModel.Surname == "";
        }
        public bool isIncorrectOldModel()
        {
            return OldClientModel.id < 0 || OldClientModel.Adress == "" || OldClientModel.Name == "" || OldClientModel.Patronymic == "" || OldClientModel.Surname == "";
        }

        public bool isIncorrectInputs()
        {
            throw new NotImplementedException();
        }

        public void updateView()
        {
            clearInputs();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectOldModel())
            
                MessageBox.Show("Выберите клиента");
           
            else
                deleteRow();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FormsForm form = new FormsForm();
            form.Show();
            this.Close();
        }
    }
}
