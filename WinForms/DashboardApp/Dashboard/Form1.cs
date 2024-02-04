using System.ComponentModel;

namespace Dashboard
{
    public partial class Form1 : Form
    {

        BindingList<string> messages = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();

            WireUpList();

        }

        private void WireUpList()
        {
            messageListBox.DataSource = messages;
        }

        private void AddMessageButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(messageBox.Text))
            {
                MessageBox.Show("Please enter message before adding it", "Empty field message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageBox.Text);
                messageBox.Text = string.Empty;
            }
            messageBox.Focus();
        }
    }
}