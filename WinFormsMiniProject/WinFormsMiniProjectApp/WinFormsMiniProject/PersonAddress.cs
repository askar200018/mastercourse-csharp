using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoLibrary;

namespace WinFormsMiniProject
{
    public partial class PersonAddress : Form
    {
        private ISaveAddress _parent;
        public PersonAddress(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = streetAddressTextBox.Text,
                City = cityTextBox.Text,
                ZipCode = zipCodeTextBox.Text,
            };
            _parent.SaveAddress(address);
            this.Close();
        }
    }
}
