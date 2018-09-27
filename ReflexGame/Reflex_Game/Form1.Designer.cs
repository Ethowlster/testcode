namespace Reflex_Game
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.checkBoxCsharp = new System.Windows.Forms.CheckBox();
            this.checkBoxJavaScript = new System.Windows.Forms.CheckBox();
            this.checkBoxCplusplus = new System.Windows.Forms.CheckBox();
            this.checkBoxphp = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 72);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(125, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.Items.AddRange(new object[] {
            "London",
            "Paris",
            "Stockholm",
            "Madrid",
            "Madeira",
            "Rome"});
            this.lstCity.Location = new System.Drawing.Point(47, 251);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(196, 95);
            this.lstCity.TabIndex = 2;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.Location = new System.Drawing.Point(510, 118);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonmale.TabIndex = 3;
            this.radioButtonmale.TabStop = true;
            this.radioButtonmale.Text = "Male";
            this.radioButtonmale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(392, 118);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 4;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(392, 154);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(103, 17);
            this.radioButtonPlus.TabIndex = 5;
            this.radioButtonPlus.TabStop = true;
            this.radioButtonPlus.Text = "I\'d rather not say";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // checkBoxCsharp
            // 
            this.checkBoxCsharp.AutoSize = true;
            this.checkBoxCsharp.Location = new System.Drawing.Point(392, 251);
            this.checkBoxCsharp.Name = "checkBoxCsharp";
            this.checkBoxCsharp.Size = new System.Drawing.Size(40, 17);
            this.checkBoxCsharp.TabIndex = 6;
            this.checkBoxCsharp.Text = "C#";
            this.checkBoxCsharp.UseVisualStyleBackColor = true;
            // 
            // checkBoxJavaScript
            // 
            this.checkBoxJavaScript.AutoSize = true;
            this.checkBoxJavaScript.Location = new System.Drawing.Point(510, 251);
            this.checkBoxJavaScript.Name = "checkBoxJavaScript";
            this.checkBoxJavaScript.Size = new System.Drawing.Size(76, 17);
            this.checkBoxJavaScript.TabIndex = 7;
            this.checkBoxJavaScript.Text = "JavaScript";
            this.checkBoxJavaScript.UseVisualStyleBackColor = true;
            // 
            // checkBoxCplusplus
            // 
            this.checkBoxCplusplus.AutoSize = true;
            this.checkBoxCplusplus.Location = new System.Drawing.Point(392, 291);
            this.checkBoxCplusplus.Name = "checkBoxCplusplus";
            this.checkBoxCplusplus.Size = new System.Drawing.Size(45, 17);
            this.checkBoxCplusplus.TabIndex = 8;
            this.checkBoxCplusplus.Text = "C++";
            this.checkBoxCplusplus.UseVisualStyleBackColor = true;
            // 
            // checkBoxphp
            // 
            this.checkBoxphp.AutoSize = true;
            this.checkBoxphp.Location = new System.Drawing.Point(510, 291);
            this.checkBoxphp.Name = "checkBoxphp";
            this.checkBoxphp.Size = new System.Drawing.Size(48, 17);
            this.checkBoxphp.TabIndex = 9;
            this.checkBoxphp.Text = "PHP";
            this.checkBoxphp.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(510, 366);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 10;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.checkBoxphp);
            this.Controls.Add(this.checkBoxCplusplus);
            this.Controls.Add(this.checkBoxJavaScript);
            this.Controls.Add(this.checkBoxCsharp);
            this.Controls.Add(this.radioButtonPlus);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonmale);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.CheckBox checkBoxCsharp;
        private System.Windows.Forms.CheckBox checkBoxJavaScript;
        private System.Windows.Forms.CheckBox checkBoxCplusplus;
        private System.Windows.Forms.CheckBox checkBoxphp;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

