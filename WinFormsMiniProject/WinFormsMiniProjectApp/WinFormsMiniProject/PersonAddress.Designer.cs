namespace WinFormsMiniProject
{
    partial class PersonAddress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            streetAddressTextBox = new TextBox();
            streetAddressLabel = new Label();
            cityLabel = new Label();
            zipCodeLabel = new Label();
            cityTextBox = new TextBox();
            zipCodeTextBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(343, 67);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(224, 33);
            streetAddressTextBox.TabIndex = 3;
            // 
            // streetAddressLabel
            // 
            streetAddressLabel.AutoSize = true;
            streetAddressLabel.Location = new Point(203, 70);
            streetAddressLabel.Margin = new Padding(5, 0, 5, 0);
            streetAddressLabel.Name = "streetAddressLabel";
            streetAddressLabel.Size = new Size(132, 25);
            streetAddressLabel.TabIndex = 2;
            streetAddressLabel.Text = "Street Address";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(203, 109);
            cityLabel.Margin = new Padding(5, 0, 5, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(44, 25);
            cityLabel.TabIndex = 4;
            cityLabel.Text = "City";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(203, 148);
            zipCodeLabel.Margin = new Padding(5, 0, 5, 0);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(88, 25);
            zipCodeLabel.TabIndex = 8;
            zipCodeLabel.Text = "Zip Code";
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(343, 109);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(224, 33);
            cityTextBox.TabIndex = 9;
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(343, 148);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(224, 33);
            zipCodeTextBox.TabIndex = 10;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(297, 202);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(110, 41);
            saveButton.TabIndex = 11;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // PersonAddress
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 494);
            Controls.Add(saveButton);
            Controls.Add(zipCodeTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(zipCodeLabel);
            Controls.Add(cityLabel);
            Controls.Add(streetAddressTextBox);
            Controls.Add(streetAddressLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "PersonAddress";
            Text = "PersonAddress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox streetAddressTextBox;
        private Label streetAddressLabel;
        private TextBox textBox1;
        private Label cityLabel;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label zipCodeLabel;
        private TextBox cityTextBox;
        private TextBox zipCodeTextBox;
        private Button saveButton;
    }
}