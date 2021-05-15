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
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }
        BUS_Contact BUSContact = new BUS_Contact();

        public void loadData()
        {
            this.dataGridViewListContact.ReadOnly = true;

            DataGridViewImageColumn picol = new DataGridViewImageColumn();

            this.dataGridViewListContact.RowTemplate.Height = 80;
            this.dataGridViewListContact.DataSource = BUSContact.getContactByUserId(DTO_Global.GlobalUserId);
            picol = (DataGridViewImageColumn)dataGridViewListContact.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            this.dataGridViewListContact.AllowUserToAddRows = false;
        }

        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            this.loadData();
        }

        private void dataGridViewListContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Close();
        }
    }
}
