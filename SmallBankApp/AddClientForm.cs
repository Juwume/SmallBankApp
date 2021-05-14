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
    public partial class AddClientForm : Form
    {
        public bool IsEdit = false;
        private bool OrigRes { get; set; }
        private int OrigType { get; set; }
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
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "smallBankDataSet.DicTypeClient". При необходимости она может быть перемещена или удалена.
            this.dicTypeClientTableAdapter.Fill(this.smallBankDataSet.DicTypeClient);
            this.clientsTableAdapter1.Fill(this.smallBankDataSet.Clients);
            TypeComboBox.SelectedIndex = -1;
            ClientModel.Reset();

        }
        private bool IsIncorrectInputs()
        {
            return NameTextBox.Text == "" || SurTextBox.Text == "" || PatTextBox.Text == "" || INNTextBox.Text == "" || AdressTextBox.Text == "" || TypeComboBox.SelectedIndex < 0;
        }

        private void AddClientForm_Activated(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.dicTypeClientTableAdapter.Fill(this.smallBankDataSet.DicTypeClient);
                NameTextBox.Text = ClientModel.Name;
                SurTextBox.Text = ClientModel.Surname;
                PatTextBox.Text = ClientModel.Patronymic;
                INNTextBox.Text = ClientModel.INN;
                AdressTextBox.Text = ClientModel.Adress;
                
                TypeComboBox.SelectedIndex = dicTypeClientTableAdapter.GetData().First(x => x.IdType == clientsTableAdapter1.GetData().First(t => t.Id == ClientModel.id).TypeClient).IdType;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (IsIncorrectInputs())
            {
                MessageBox.Show("Неправильный ввод");
            }
            else
            {
                FizFaces.IsEdit = IsEdit;
                if (IsEdit)
                {
                    OrigRes = clientsTableAdapter1.GetData().FirstOrDefault(t => t.Id == ClientModel.id).Resident;
                    OrigType = clientsTableAdapter1.GetData().FirstOrDefault(t => t.Id == ClientModel.id).TypeClient;
                    FizFaces.ClientModel.id = AddClientForm.ClientModel.id;
                    FizFaces.ClientModel.Surname = SurTextBox.Text;
                    FizFaces.ClientModel.Name = NameTextBox.Text;
                    FizFaces.ClientModel.Patronymic = PatTextBox.Text;
                    FizFaces.ClientModel.INN = INNTextBox.Text;
                    FizFaces.ClientModel.Adress = AdressTextBox.Text;
                    clientsTableAdapter1.Update(ResidentCheckBox.Checked, dicTypeClientTableAdapter.GetData().First(t=>t.Name == TypeComboBox.Text).IdType,ClientModel.id,OrigRes,OrigType);
                }
                else
                {
                    clientsTableAdapter1.Insert(ResidentCheckBox.Checked, dicTypeClientTableAdapter.GetData().First(t => t.Name == TypeComboBox.Text).IdType);
                    FizFaces.ClientModel.id = clientsTableAdapter1.GetData().Last().Id;
                    FizFaces.ClientModel.Surname = SurTextBox.Text;
                    FizFaces.ClientModel.Name = NameTextBox.Text;
                    FizFaces.ClientModel.Patronymic = PatTextBox.Text;
                    FizFaces.ClientModel.INN = INNTextBox.Text;
                    FizFaces.ClientModel.Adress = AdressTextBox.Text;
                }
                FizFaces.IsReady = true;
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
