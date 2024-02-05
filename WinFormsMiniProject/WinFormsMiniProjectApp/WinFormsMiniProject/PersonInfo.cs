using System.ComponentModel;
using DemoLibrary;

namespace WinFormsMiniProject
{
    public partial class PersonInfo : Form, ISaveAddress
    {
        private BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonInfo()
        {
            InitializeComponent();

            addressesListBox.DataSource = addresses;
            addressesListBox.DisplayMember = nameof(AddressModel.DisplayValue);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool isValidAge = int.TryParse(ageTextBox.Text, out int age);

            if (!isValidAge)
            {
                MessageBox.Show(
                "Please enter a valid age. Before submitting the form.",
                "Not valid Age Field",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Age = age,
                Addresses = addresses.ToList(),
            };

            Console.WriteLine(person.FirstName);

        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            PersonAddress addressForm = new PersonAddress(this);
            addressForm.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }
    }
}