namespace HappyFeetApp
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.txt_DogName = new System.Windows.Forms.TextBox();
            this.lbl_Dog_Name = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_File_from_details = new System.Windows.Forms.Button();
            this.btn_details_from_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(78, 83);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(119, 80);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(149, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(119, 118);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(149, 20);
            this.txt_Surname.TabIndex = 3;
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(64, 121);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(49, 13);
            this.lbl_Surname.TabIndex = 2;
            this.lbl_Surname.Text = "Surname";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(119, 157);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(149, 20);
            this.txt_Phone.TabIndex = 7;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(64, 160);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(38, 13);
            this.lbl_Phone.TabIndex = 6;
            this.lbl_Phone.Text = "Phone";
            // 
            // txt_DogName
            // 
            this.txt_DogName.Location = new System.Drawing.Point(119, 48);
            this.txt_DogName.Name = "txt_DogName";
            this.txt_DogName.Size = new System.Drawing.Size(149, 20);
            this.txt_DogName.TabIndex = 5;
            // 
            // lbl_Dog_Name
            // 
            this.lbl_Dog_Name.AutoSize = true;
            this.lbl_Dog_Name.Location = new System.Drawing.Point(55, 51);
            this.lbl_Dog_Name.Name = "lbl_Dog_Name";
            this.lbl_Dog_Name.Size = new System.Drawing.Size(58, 13);
            this.lbl_Dog_Name.TabIndex = 4;
            this.lbl_Dog_Name.Text = "Dog Name";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(328, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 160);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(203, 293);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(438, 134);
            this.listBox2.TabIndex = 9;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(193, 209);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add details";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_File_from_details
            // 
            this.btn_File_from_details.Location = new System.Drawing.Point(328, 209);
            this.btn_File_from_details.Name = "btn_File_from_details";
            this.btn_File_from_details.Size = new System.Drawing.Size(97, 23);
            this.btn_File_from_details.TabIndex = 11;
            this.btn_File_from_details.Text = "File from details";
            this.btn_File_from_details.UseVisualStyleBackColor = true;
            this.btn_File_from_details.Click += new System.EventHandler(this.btn_File_from_details_Click);
            // 
            // btn_details_from_file
            // 
            this.btn_details_from_file.Location = new System.Drawing.Point(97, 293);
            this.btn_details_from_file.Name = "btn_details_from_file";
            this.btn_details_from_file.Size = new System.Drawing.Size(100, 23);
            this.btn_details_from_file.TabIndex = 12;
            this.btn_details_from_file.Text = "details from file";
            this.btn_details_from_file.UseVisualStyleBackColor = true;
            this.btn_details_from_file.Click += new System.EventHandler(this.btn_details_from_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_details_from_file);
            this.Controls.Add(this.btn_File_from_details);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.lbl_Phone);
            this.Controls.Add(this.txt_DogName);
            this.Controls.Add(this.lbl_Dog_Name);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_DogName;
        private System.Windows.Forms.Label lbl_Dog_Name;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_File_from_details;
        private System.Windows.Forms.Button btn_details_from_file;
    }
}

