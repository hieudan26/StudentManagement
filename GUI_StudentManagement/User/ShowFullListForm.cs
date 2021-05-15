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
using GUI_StudentManagement.Course;

namespace GUI_StudentManagement.User
{
    public partial class btnAddcourse : Form
    {
        public btnAddcourse()
        {
            InitializeComponent();
        }

        BUS_Contact BUSContact = new BUS_Contact();
        BUS_Group BUSGroup = new BUS_Group();

        void reloadListBoxData()
        {
            this.listBoxGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGroup.DataSource = this.BUSGroup.getGroups(DTO_Global.GlobalUserId);
            this.listBoxGroup.ValueMember = "id";
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

        private void listBoxGroup_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.listBoxGroup.SelectedValue.ToString());
            this.showData(id);
        }
        private void showData(int idGrp)
        {
            try
            {
                DataTable table = this.BUSContact.getContactByGroupId(idGrp);
                if (table != null)
                {
                    this.dataGridViewListContact.RowTemplate.Height = 80;
                    this.dataGridViewListContact.DataSource = table;
                    this.dataGridViewListContact.ReadOnly = true;
                    DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                    picCol = (DataGridViewImageColumn)this.dataGridViewListContact.Columns[7];
                    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                    this.dataGridViewListContact.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCourseForContactForm form = new AddCourseForContactForm();
            form.Show();
        }

        private void dataGridViewListContact_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int contactId = Convert.ToInt32(dataGridViewListContact.CurrentRow.Cells[0].Value.ToString());
            if (this.BUSContact.checkIdContatct(contactId) == true)
                MessageBox.Show("Contact don't have Course");
            else
            {
                CourseGVForm form = new CourseGVForm(contactId);
                form.Show();
            }    
        }
    }
}
