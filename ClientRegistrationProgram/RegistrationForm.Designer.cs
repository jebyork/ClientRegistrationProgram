namespace ClientRegistrationProgram
{
    partial class RegistrationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            buttonreg2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 45);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 93);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 182);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 269);
            label4.Name = "label4";
            label4.Size = new Size(204, 32);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(566, 39);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(566, 39);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(41, 304);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(566, 39);
            textBox3.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(41, 380);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 36);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Admin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(182, 384);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(94, 36);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Staff";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // buttonreg2
            // 
            buttonreg2.BackColor = SystemColors.ControlDark;
            buttonreg2.Location = new Point(633, 390);
            buttonreg2.Name = "buttonreg2";
            buttonreg2.Size = new Size(150, 46);
            buttonreg2.TabIndex = 9;
            buttonreg2.Text = "Register";
            buttonreg2.UseVisualStyleBackColor = false;
            buttonreg2.Click += buttonreg2_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 496);
            Controls.Add(buttonreg2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button buttonreg2;
    }
}