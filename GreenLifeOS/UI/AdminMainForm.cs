using GreenLifeOS.UI;
using System;
using System.Windows.Forms;

namespace GreenLifeOS
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private UserControl activeControl = null;

        private void LoadChildForm(UserControl rightContent)
        {
            activeControl = rightContent;
            rightContent.Dock = DockStyle.Fill;

            panelRightControl.Controls.Clear();
            panelRightControl.Controls.Add(rightContent);
            panelRightControl.Tag = rightContent;

            rightContent.BringToFront();
            rightContent.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductCategoryForm productCategoryForm = new ProductCategoryForm();
            productCategoryForm.Show();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminInventoryControl());
        }

        private void panel1_Resize(object sender, EventArgs e)
        {

            base.OnResize(e);

            // Adjust the width of the panel to match the width of the parent form
            if (Parent != null)
            {
                Width = Parent.ClientSize.Width;
                Height = Parent.ClientSize.Height;

            }
        }

        private void btnAdminReports_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminReportControl());

        }

        private void btnAdminOrders_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminOrderControl());

        }

        private void btnAdminUsers_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminUserControl());

        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            LoadChildForm(new AdminProfileControl());

        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            LoadChildForm(new AdminDashboardControl());

        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            //LoadChildForm(new AdminDashboardControl());
            LoadChildForm(new AdminDashboardControl());
        }

        private void btnUserLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = ShowConfirmationDialog("Logout", "Are you sure you want to Logout?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private DialogResult ShowConfirmationDialog(string title, string message, MessageBoxButtons buttons)
        {
            return MessageBox.Show(this, message, title,
                buttons, MessageBoxIcon.Question);
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
