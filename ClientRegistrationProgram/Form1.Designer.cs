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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayOrganizationTable = new TableLayoutPanel();
            DataInteractionPanel = new Panel();
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
            AdminCheckBox = new CheckBox();
            SignedInCheckBocx = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            DisplayOrganizationTable.Name = "DisplayOrganizationTable";
            DisplayOrganizationTable.RowCount = 2;
            DisplayOrganizationTable.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            DisplayOrganizationTable.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            DisplayOrganizationTable.Size = new Size(1464, 590);
            DisplayOrganizationTable.TabIndex = 0;
            // 
            // DataInteractionPanel
            // 
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
            DataInteractionPanel.Location = new Point(3, 3);
            DataInteractionPanel.Name = "DataInteractionPanel";
            DataInteractionPanel.Size = new Size(213, 525);
            DataInteractionPanel.TabIndex = 0;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Top;
            RemoveButton.Location = new Point(0, 310);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(213, 23);
            RemoveButton.TabIndex = 17;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Top;
            AddButton.Location = new Point(0, 287);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(213, 23);
            AddButton.TabIndex = 16;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AccessoriesAddCheckBox
            // 
            AccessoriesAddCheckBox.Dock = DockStyle.Top;
            AccessoriesAddCheckBox.Location = new Point(0, 263);
            AccessoriesAddCheckBox.Margin = new Padding(5);
            AccessoriesAddCheckBox.Name = "AccessoriesAddCheckBox";
            AccessoriesAddCheckBox.Size = new Size(213, 24);
            AccessoriesAddCheckBox.TabIndex = 15;
            AccessoriesAddCheckBox.Text = "Accessories ";
            AccessoriesAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // OfficeToolsAddCheckBox
            // 
            OfficeToolsAddCheckBox.Dock = DockStyle.Top;
            OfficeToolsAddCheckBox.Location = new Point(0, 239);
            OfficeToolsAddCheckBox.Margin = new Padding(5);
            OfficeToolsAddCheckBox.Name = "OfficeToolsAddCheckBox";
            OfficeToolsAddCheckBox.Size = new Size(213, 24);
            OfficeToolsAddCheckBox.TabIndex = 14;
            OfficeToolsAddCheckBox.Text = "Office Tools";
            OfficeToolsAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // GamesAddCheckBox
            // 
            GamesAddCheckBox.Dock = DockStyle.Top;
            GamesAddCheckBox.Location = new Point(0, 215);
            GamesAddCheckBox.Margin = new Padding(5);
            GamesAddCheckBox.Name = "GamesAddCheckBox";
            GamesAddCheckBox.Size = new Size(213, 24);
            GamesAddCheckBox.TabIndex = 13;
            GamesAddCheckBox.Text = "Games";
            GamesAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComputersAddCheckBox
            // 
            ComputersAddCheckBox.Dock = DockStyle.Top;
            ComputersAddCheckBox.Location = new Point(0, 191);
            ComputersAddCheckBox.Margin = new Padding(5);
            ComputersAddCheckBox.Name = "ComputersAddCheckBox";
            ComputersAddCheckBox.Size = new Size(213, 24);
            ComputersAddCheckBox.TabIndex = 12;
            ComputersAddCheckBox.Text = "Computers";
            ComputersAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // SoftwareAddCheckBox
            // 
            SoftwareAddCheckBox.Dock = DockStyle.Top;
            SoftwareAddCheckBox.Location = new Point(0, 167);
            SoftwareAddCheckBox.Margin = new Padding(5);
            SoftwareAddCheckBox.Name = "SoftwareAddCheckBox";
            SoftwareAddCheckBox.Size = new Size(213, 24);
            SoftwareAddCheckBox.TabIndex = 11;
            SoftwareAddCheckBox.Text = "Software ";
            SoftwareAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(0, 152);
            label5.Margin = new Padding(5);
            label5.Name = "label5";
            label5.Size = new Size(213, 15);
            label5.TabIndex = 10;
            label5.Text = "Products:";
            // 
            // EmailInputTxt
            // 
            EmailInputTxt.Dock = DockStyle.Top;
            EmailInputTxt.Location = new Point(0, 129);
            EmailInputTxt.Margin = new Padding(5);
            EmailInputTxt.Name = "EmailInputTxt";
            EmailInputTxt.Size = new Size(213, 23);
            EmailInputTxt.TabIndex = 9;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 114);
            label4.Margin = new Padding(5);
            label4.Name = "label4";
            label4.Size = new Size(213, 15);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // NumberInputTxt
            // 
            NumberInputTxt.Dock = DockStyle.Top;
            NumberInputTxt.Location = new Point(0, 91);
            NumberInputTxt.Margin = new Padding(5);
            NumberInputTxt.Name = "NumberInputTxt";
            NumberInputTxt.Size = new Size(213, 23);
            NumberInputTxt.TabIndex = 7;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 76);
            label3.Margin = new Padding(5);
            label3.Name = "label3";
            label3.Size = new Size(213, 15);
            label3.TabIndex = 6;
            label3.Text = "Phone Number:";
            // 
            // AddressInputTxt
            // 
            AddressInputTxt.Dock = DockStyle.Top;
            AddressInputTxt.Location = new Point(0, 53);
            AddressInputTxt.Margin = new Padding(5);
            AddressInputTxt.Name = "AddressInputTxt";
            AddressInputTxt.Size = new Size(213, 23);
            AddressInputTxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 38);
            label2.Margin = new Padding(5);
            label2.Name = "label2";
            label2.Size = new Size(213, 15);
            label2.TabIndex = 4;
            label2.Text = "Address:";
            // 
            // NameInputTxt
            // 
            NameInputTxt.Dock = DockStyle.Top;
            NameInputTxt.Location = new Point(0, 15);
            NameInputTxt.Margin = new Padding(5);
            NameInputTxt.Name = "NameInputTxt";
            NameInputTxt.Size = new Size(213, 23);
            NameInputTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(5);
            label1.Name = "label1";
            label1.Size = new Size(213, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // CustomerDataGridView
            // 
            CustomerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerDataGridView.Dock = DockStyle.Fill;
            CustomerDataGridView.Location = new Point(222, 3);
            CustomerDataGridView.Name = "CustomerDataGridView";
            CustomerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CustomerDataGridView.Size = new Size(1239, 525);
            CustomerDataGridView.TabIndex = 1;
            CustomerDataGridView.RowValidated += CustomerDataGridView_RowValidated;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.AutoSize = true;
            AdminCheckBox.Location = new Point(3, 3);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.Size = new Size(70, 19);
            AdminCheckBox.TabIndex = 2;
            AdminCheckBox.Text = "IsAdmin";
            AdminCheckBox.UseVisualStyleBackColor = true;
            AdminCheckBox.CheckedChanged += AdminCheckBox_CheckedChanged;
            // 
            // SignedInCheckBocx
            // 
            SignedInCheckBocx.AutoSize = true;
            SignedInCheckBocx.Location = new Point(79, 3);
            SignedInCheckBocx.Name = "SignedInCheckBocx";
            SignedInCheckBocx.Size = new Size(80, 19);
            SignedInCheckBocx.TabIndex = 3;
            SignedInCheckBocx.Text = "IsSignedIn";
            SignedInCheckBocx.UseVisualStyleBackColor = true;
            SignedInCheckBocx.CheckedChanged += SignedInCheckBocx_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(AdminCheckBox);
            flowLayoutPanel1.Controls.Add(SignedInCheckBocx);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 534);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(213, 53);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // CustomerApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 590);
            Controls.Add(DisplayOrganizationTable);
            MaximumSize = new Size(1480, 1000);
            MinimumSize = new Size(1480, 0);
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
        private CheckBox SignedInCheckBocx;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
