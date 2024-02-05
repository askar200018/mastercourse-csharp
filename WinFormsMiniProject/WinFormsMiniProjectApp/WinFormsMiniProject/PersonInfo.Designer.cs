namespace WinFormsMiniProject
{
    partial class PersonInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            ageTextBox = new TextBox();
            ageLabel = new Label();
            submitButton = new Button();
            addAddressButton = new Button();
            addressesListBox = new ListBox();
            addressesLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(203, 94);
            firstNameLabel.Margin = new Padding(5, 0, 5, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(102, 25);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(313, 91);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(224, 33);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(313, 140);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(224, 33);
            lastNameTextBox.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(203, 143);
            lastNameLabel.Margin = new Padding(5, 0, 5, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 25);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(313, 188);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(224, 33);
            ageTextBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(203, 191);
            ageLabel.Margin = new Padding(5, 0, 5, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(45, 25);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age";
            // 
            // submitButton
            // 
            submitButton.Location = new Point(302, 435);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(125, 33);
            submitButton.TabIndex = 5;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // addAddressButton
            // 
            addAddressButton.Location = new Point(412, 236);
            addAddressButton.Name = "addAddressButton";
            addAddressButton.Size = new Size(125, 33);
            addAddressButton.TabIndex = 4;
            addAddressButton.Text = "Add";
            addAddressButton.UseVisualStyleBackColor = true;
            addAddressButton.Click += AddAddressButton_Click;
            // 
            // addressesListBox
            // 
            addressesListBox.FormattingEnabled = true;
            addressesListBox.ItemHeight = 25;
            addressesListBox.Location = new Point(203, 275);
            addressesListBox.Name = "addressesListBox";
            addressesListBox.Size = new Size(334, 154);
            addressesListBox.TabIndex = 8;
            addressesListBox.UseTabStops = false;
            // 
            // addressesLabel
            // 
            addressesLabel.AutoSize = true;
            addressesLabel.Location = new Point(203, 236);
            addressesLabel.Margin = new Padding(5, 0, 5, 0);
            addressesLabel.Name = "addressesLabel";
            addressesLabel.Size = new Size(97, 25);
            addressesLabel.TabIndex = 9;
            addressesLabel.Text = "Addresses";
            // 
            // PersonInfo
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 575);
            Controls.Add(addressesLabel);
            Controls.Add(addressesListBox);
            Controls.Add(addAddressButton);
            Controls.Add(submitButton);
            Controls.Add(ageTextBox);
            Controls.Add(ageLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "PersonInfo";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox ageTextBox;
        private Label ageLabel;
        private Button submitButton;
        private Button addAddressButton;
        private ListBox addressesListBox;
        private Label addressesLabel;
    }
}