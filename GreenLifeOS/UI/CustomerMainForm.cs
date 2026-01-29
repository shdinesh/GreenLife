using GreenLifeOS.UI;
using System;
using System.Windows.Forms;

namespace GreenLifeOS
{
    public partial class CustomerMainForm : Form
    {
        public CustomerMainForm()
        {
            InitializeComponent();
        }

        private UserControl activeControl = null;

        private void LoadChildForm(UserControl rightContent)
        {
            activeControl = rightContent;
            rightContent.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(rightContent);
            panel1.Tag = rightContent;

            rightContent.BringToFront();
            rightContent.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliersForm = new SuppliersForm();
            suppliersForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CustomerOrderControl orderControl = new CustomerOrderControl();
            LoadChildForm(orderControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CustomerProfileControl profileControl = new CustomerProfileControl();
            LoadChildForm(profileControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadChildForm(new InventoryControl());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
