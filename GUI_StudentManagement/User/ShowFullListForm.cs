using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_StudentManagement;
using BUS_StudentManagement;
using System.IO;
using System.Data.SqlClient;

namespace GUI_StudentManagement.User
{
    public partial class ShowFullListForm : Form
    {
        public ShowFullListForm()
        {
            InitializeComponent();
        }

        BUS_Contact BUSContact = new BUS_Contact();
        BUS_Group BUSGroup = new BUS_Group();

        void reloadListBoxData()
        {
            this.listBoxGroup.DataSource = BUSGroup.getGroups(DTO_Global.GlobalUserId);
            this.listBoxGroup.ValueMember = "Id";
            this.listBoxGroup.DisplayMember = "name";
            this.listBoxGroup.SelectedItem = null;

        }

        public void loadDataGridView(SqlCommand command)
        {
            this.dataGridViewListContact.ReadOnly = true;

            DataGridViewImageColumn picol = new DataGridViewImageColumn();

            this.dataGridViewListContact.RowTemplate.Height = 80;
            this.dataGridViewListContact.DataSource = BUSContact.getContactByUserId(DTO_Global.GlobalUserId);
            picol = (DataGridViewImageColumn)dataGridViewListContact.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewListContact.AllowUserToAddRows = false;


        }

        private void buttonShow_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last Name', MyGroup.name as 'Group', phone,email,address,pic FROM Contact INNER JOIN MyGroup ON Contact.group_id = MyGroup.Id WHERE Contact.userid = " + DTO_Global.GlobalUserId);
            this.loadDataGridView(command);
        }

        private void ShowFullListForm_Load(object sender, EventArgs e)
        {
            this.reloadListBoxData();
            SqlCommand command = new SqlCommand("SELECT fname as 'First Name', lname as 'Last Name', MyGroup.name as 'Group', phone,email,address,pic FROM Contact INNER JOIN MyGroup ON Contact.group_id = MyGroup.Id WHERE Contact.userid = " + DTO_Global.GlobalUserId);
            this.loadDataGridView(command);
        }
    }
}
