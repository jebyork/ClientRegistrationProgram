using System.Drawing.Text;
using System.Runtime.CompilerServices;

namespace ClientRegistrationProgram
{
    partial class CustomerApp
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

        public void ApplyAuth(bool isAdmin)
        {
            // Make sure _clientManager initialized (constructor runs before Program calls this)
            _clientManager.ChangeAdminState(isAdmin);
            _clientManager.ChangeSignedInState(true);

            // update the UI checkboxes
            AdminCheckBox.Checked = isAdmin;
            SignedInCheckBox.Checked = true;
        }

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayOrganizationTable = new TableLayoutPanel();
            DataInteractionPanel = new Panel();
            SortButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            AccessoriesAddCheckBox = new CheckBox();
            OfficeToolsAddCheckBox = new CheckBox();
            GamesAddCheckBox = new CheckBox();
            ComputersAddCheckBox = new CheckBox();
            SoftwareAddCheckBox = new CheckBox();
            label5 = new Label();
            EmailInputTxt = new TextBox();
            label4 = new Label();
            NumberInputTxt = new TextBox();
            label3 = new Label();
            AddressInputTxt = new TextBox();
            label2 = new Label();
            NameInputTxt = new TextBox();
            label1 = new Label();
            CustomerDataGridView = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AdminCheckBox = new CheckBox();
            SignedInCheckBox = new CheckBox();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            DisplayOrganizationTable.SuspendLayout();
            DataInteractionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayOrganizationTable
            // 
            DisplayOrganizationTable.ColumnCount = 2;
            DisplayOrganizationTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            DisplayOrganizationTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            DisplayOrganizationTable.Controls.Add(DataInteractionPanel, 0, 0);
            DisplayOrganizationTable.Controls.Add(CustomerDataGridView, 1, 0);
            DisplayOrganizationTable.Controls.Add(flowLayoutPanel1, 0, 1);
            DisplayOrganizationTable.Dock = DockStyle.Fill;
            DisplayOrganizationTable.Location = new Point(0, 0);
            DisplayOrganizationTable.Margin = new Padding(6);
            DisplayOrganizationTable.Name = "DisplayOrganizationTable";
            DisplayOrganizationTable.RowCount = 2;
            DisplayOrganizationTable.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            DisplayOrganizationTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            DisplayOrganizationTable.Size = new Size(2700, 1259);
            DisplayOrganizationTable.TabIndex = 0;
            // 
            // DataInteractionPanel
            // 
            DataInteractionPanel.Controls.Add(SortButton);
            DataInteractionPanel.Controls.Add(RemoveButton);
            DataInteractionPanel.Controls.Add(AddButton);
            DataInteractionPanel.Controls.Add(AccessoriesAddCheckBox);
            DataInteractionPanel.Controls.Add(OfficeToolsAddCheckBox);
            DataInteractionPanel.Controls.Add(GamesAddCheckBox);
            DataInteractionPanel.Controls.Add(ComputersAddCheckBox);
            DataInteractionPanel.Controls.Add(SoftwareAddCheckBox);
            DataInteractionPanel.Controls.Add(label5);
            DataInteractionPanel.Controls.Add(EmailInputTxt);
            DataInteractionPanel.Controls.Add(label4);
            DataInteractionPanel.Controls.Add(NumberInputTxt);
            DataInteractionPanel.Controls.Add(label3);
            DataInteractionPanel.Controls.Add(AddressInputTxt);
            DataInteractionPanel.Controls.Add(label2);
            DataInteractionPanel.Controls.Add(NameInputTxt);
            DataInteractionPanel.Controls.Add(label1);
            DataInteractionPanel.Dock = DockStyle.Fill;
            DataInteractionPanel.Location = new Point(6, 6);
            DataInteractionPanel.Margin = new Padding(6);
            DataInteractionPanel.Name = "DataInteractionPanel";
            DataInteractionPanel.Size = new Size(393, 1121);
            DataInteractionPanel.TabIndex = 0;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(0, 753);
            SortButton.Margin = new Padding(6);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(393, 49);
            SortButton.TabIndex = 18;
            SortButton.Text = "Sort by: ID";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Top;
            RemoveButton.Location = new Point(0, 620);
            RemoveButton.Margin = new Padding(6);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(393, 49);
            RemoveButton.TabIndex = 17;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Top;
            AddButton.Location = new Point(0, 571);
            AddButton.Margin = new Padding(6);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(393, 49);
            AddButton.TabIndex = 16;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AccessoriesAddCheckBox
            // 
            AccessoriesAddCheckBox.Dock = DockStyle.Top;
            AccessoriesAddCheckBox.Location = new Point(0, 520);
            AccessoriesAddCheckBox.Margin = new Padding(9, 11, 9, 11);
            AccessoriesAddCheckBox.Name = "AccessoriesAddCheckBox";
            AccessoriesAddCheckBox.Size = new Size(393, 51);
            AccessoriesAddCheckBox.TabIndex = 15;
            AccessoriesAddCheckBox.Text = "Accessories ";
            AccessoriesAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // OfficeToolsAddCheckBox
            // 
            OfficeToolsAddCheckBox.Dock = DockStyle.Top;
            OfficeToolsAddCheckBox.Location = new Point(0, 469);
            OfficeToolsAddCheckBox.Margin = new Padding(9, 11, 9, 11);
            OfficeToolsAddCheckBox.Name = "OfficeToolsAddCheckBox";
            OfficeToolsAddCheckBox.Size = new Size(393, 51);
            OfficeToolsAddCheckBox.TabIndex = 14;
            OfficeToolsAddCheckBox.Text = "Office Tools";
            OfficeToolsAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // GamesAddCheckBox
            // 
            GamesAddCheckBox.Dock = DockStyle.Top;
            GamesAddCheckBox.Location = new Point(0, 418);
            GamesAddCheckBox.Margin = new Padding(9, 11, 9, 11);
            GamesAddCheckBox.Name = "GamesAddCheckBox";
            GamesAddCheckBox.Size = new Size(393, 51);
            GamesAddCheckBox.TabIndex = 13;
            GamesAddCheckBox.Text = "Games";
            GamesAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComputersAddCheckBox
            // 
            ComputersAddCheckBox.Dock = DockStyle.Top;
            ComputersAddCheckBox.Location = new Point(0, 367);
            ComputersAddCheckBox.Margin = new Padding(9, 11, 9, 11);
            ComputersAddCheckBox.Name = "ComputersAddCheckBox";
            ComputersAddCheckBox.Size = new Size(393, 51);
            ComputersAddCheckBox.TabIndex = 12;
            ComputersAddCheckBox.Text = "Computers";
            ComputersAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // SoftwareAddCheckBox
            // 
            SoftwareAddCheckBox.Dock = DockStyle.Top;
            SoftwareAddCheckBox.Location = new Point(0, 316);
            SoftwareAddCheckBox.Margin = new Padding(9, 11, 9, 11);
            SoftwareAddCheckBox.Name = "SoftwareAddCheckBox";
            SoftwareAddCheckBox.Size = new Size(393, 51);
            SoftwareAddCheckBox.TabIndex = 11;
            SoftwareAddCheckBox.Text = "Software ";
            SoftwareAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 284);
            label5.Margin = new Padding(9, 11, 9, 11);
            label5.Name = "label5";
            label5.Size = new Size(393, 32);
            label5.TabIndex = 10;
            label5.Text = "Products:";
            // 
            // EmailInputTxt
            // 
            EmailInputTxt.Dock = DockStyle.Top;
            EmailInputTxt.Location = new Point(0, 245);
            EmailInputTxt.Margin = new Padding(9, 11, 9, 11);
            EmailInputTxt.Name = "EmailInputTxt";
            EmailInputTxt.Size = new Size(393, 39);
            EmailInputTxt.TabIndex = 9;
            EmailInputTxt.TextChanged += EmailInputTxt_TextChanged;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 213);
            label4.Margin = new Padding(9, 11, 9, 11);
            label4.Name = "label4";
            label4.Size = new Size(393, 32);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // NumberInputTxt
            // 
            NumberInputTxt.Dock = DockStyle.Top;
            NumberInputTxt.Location = new Point(0, 174);
            NumberInputTxt.Margin = new Padding(9, 11, 9, 11);
            NumberInputTxt.Name = "NumberInputTxt";
            NumberInputTxt.Size = new Size(393, 39);
            NumberInputTxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 142);
            label3.Margin = new Padding(9, 11, 9, 11);
            label3.Name = "label3";
            label3.Size = new Size(393, 32);
            label3.TabIndex = 6;
            label3.Text = "Phone Number:";
            // 
            // AddressInputTxt
            // 
            AddressInputTxt.Dock = DockStyle.Top;
            AddressInputTxt.Location = new Point(0, 103);
            AddressInputTxt.Margin = new Padding(9, 11, 9, 11);
            AddressInputTxt.Name = "AddressInputTxt";
            AddressInputTxt.Size = new Size(393, 39);
            AddressInputTxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 71);
            label2.Margin = new Padding(9, 11, 9, 11);
            label2.Name = "label2";
            label2.Size = new Size(393, 32);
            label2.TabIndex = 4;
            label2.Text = "Address:";
            // 
            // NameInputTxt
            // 
            NameInputTxt.Dock = DockStyle.Top;
            NameInputTxt.Location = new Point(0, 32);
            NameInputTxt.Margin = new Padding(9, 11, 9, 11);
            NameInputTxt.Name = "NameInputTxt";
            NameInputTxt.Size = new Size(393, 39);
            NameInputTxt.TabIndex = 3;
            NameInputTxt.TextChanged += NameInputTxt_TextChanged;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(9, 11, 9, 11);
            label1.Name = "label1";
            label1.Size = new Size(393, 32);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Dock = DockStyle.Fill;
            CustomerDataGridView.Location = new Point(411, 6);
            CustomerDataGridView.Margin = new Padding(6);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.RowHeadersWidth = 82;
            CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataGridView.Size = new Size(2283, 1121);
            CustomerDataGridView.TabIndex = 1;
            CustomerDataGridView.RowValidated += CustomerDataGridView_RowValidated;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(AdminCheckBox);
            flowLayoutPanel1.Controls.Add(SignedInCheckBox);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(6, 1139);
            flowLayoutPanel1.Margin = new Padding(6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(393, 114);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.AutoSize = true;
            AdminCheckBox.Location = new Point(6, 6);
            AdminCheckBox.Margin = new Padding(6);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.Size = new Size(116, 36);
            AdminCheckBox.TabIndex = 2;
            AdminCheckBox.Text = "Admin";
            AdminCheckBox.UseVisualStyleBackColor = true;
            AdminCheckBox.CheckedChanged += AdminCheckBox_CheckedChanged;
            // 
            // SignedInCheckBox
            // 
            SignedInCheckBox.AutoSize = true;
            SignedInCheckBox.Location = new Point(134, 6);
            SignedInCheckBox.Margin = new Padding(6);
            SignedInCheckBox.Name = "SignedInCheckBox";
            SignedInCheckBox.Size = new Size(94, 36);
            SignedInCheckBox.TabIndex = 3;
            SignedInCheckBox.Text = "Staff";
            SignedInCheckBox.UseVisualStyleBackColor = true;
            SignedInCheckBox.CheckedChanged += SignedInCheckBocx_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 714);
            label6.Name = "label6";
            label6.Size = new Size(73, 32);
            label6.TabIndex = 22;
            label6.Text = "Login";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 1042);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(390, 39);
            textBox4.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(-6, 965);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(390, 39);
            textBox3.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 854);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(390, 39);
            textBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 770);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 39);
            textBox1.TabIndex = 18;
            // 
            // CustomerApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2700, 1259);
            Controls.Add(DisplayOrganizationTable);
            Margin = new Padding(6);
            MaximumSize = new Size(2726, 2053);
            MinimumSize = new Size(2726, 71);
            Name = "CustomerApp";
            Text = "CustomerApp";
            DisplayOrganizationTable.ResumeLayout(false);
            DataInteractionPanel.ResumeLayout(false);
            DataInteractionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerDataGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel DisplayOrganizationTable;
        private Panel DataInteractionPanel;
        private DataGridView CustomerDataGridView;
        private Label label5;
        private TextBox EmailInputTxt;
        private Label label4;
        private TextBox NumberInputTxt;
        private Label label3;
        private TextBox AddressInputTxt;
        private Label label2;
        private TextBox NameInputTxt;
        private Label label1;
        private CheckBox AccessoriesAddCheckBox;
        private CheckBox OfficeToolsAddCheckBox;
        private CheckBox GamesAddCheckBox;
        private CheckBox ComputersAddCheckBox;
        private CheckBox SoftwareAddCheckBox;
        private Button AddButton;
        private CheckBox AdminCheckBox;
        private Button RemoveButton;
        private CheckBox SignedInCheckBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SortButton;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;   
        private Label label12;
        private TextBox textBox1;   
    }
}