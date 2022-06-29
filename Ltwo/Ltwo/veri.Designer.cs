namespace Ltwo
{
    partial class veri
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
            this.info = new System.Windows.Forms.DataGridView();
            this.lname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.hiredate = new System.Windows.Forms.Label();
            this.personalıd = new System.Windows.Forms.Label();
            this.pıd = new System.Windows.Forms.TextBox();
            this.hdate = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.dosya = new System.Windows.Forms.OpenFileDialog();
            this.filepath = new System.Windows.Forms.TextBox();
            this.gözat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info.Location = new System.Drawing.Point(37, 33);
            this.info.Name = "info";
            this.info.RowHeadersWidth = 51;
            this.info.RowTemplate.Height = 24;
            this.info.Size = new System.Drawing.Size(682, 211);
            this.info.TabIndex = 0;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(144, 277);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(162, 22);
            this.lname.TabIndex = 1;
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(34, 280);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(75, 16);
            this.lastname.TabIndex = 2;
            this.lastname.Text = "Last Name:";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(34, 327);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(75, 16);
            this.firstname.TabIndex = 3;
            this.firstname.Text = "First Name:";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(144, 321);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(162, 22);
            this.fname.TabIndex = 4;
            // 
            // hiredate
            // 
            this.hiredate.AutoSize = true;
            this.hiredate.Location = new System.Drawing.Point(47, 400);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(67, 16);
            this.hiredate.TabIndex = 5;
            this.hiredate.Text = "Hire Date:";
            // 
            // personalıd
            // 
            this.personalıd.AutoSize = true;
            this.personalıd.Location = new System.Drawing.Point(34, 361);
            this.personalıd.Name = "personalıd";
            this.personalıd.Size = new System.Drawing.Size(80, 16);
            this.personalıd.TabIndex = 6;
            this.personalıd.Text = "Personal ID:";
            // 
            // pıd
            // 
            this.pıd.Location = new System.Drawing.Point(144, 358);
            this.pıd.Name = "pıd";
            this.pıd.Size = new System.Drawing.Size(162, 22);
            this.pıd.TabIndex = 7;
            // 
            // hdate
            // 
            this.hdate.Location = new System.Drawing.Point(144, 394);
            this.hdate.Name = "hdate";
            this.hdate.Size = new System.Drawing.Size(162, 22);
            this.hdate.TabIndex = 8;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(387, 276);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(117, 45);
            this.view.TabIndex = 9;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(536, 276);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(117, 45);
            this.create.TabIndex = 10;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(387, 347);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(117, 45);
            this.update.TabIndex = 11;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(536, 347);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(117, 45);
            this.delete.TabIndex = 12;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(361, 416);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(143, 43);
            this.import.TabIndex = 13;
            this.import.Text = "import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(536, 416);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(143, 43);
            this.export.TabIndex = 14;
            this.export.Text = "export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // dosya
            // 
            this.dosya.FileName = "dosya";
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(23, 437);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(187, 22);
            this.filepath.TabIndex = 15;
            // 
            // gözat
            // 
            this.gözat.Location = new System.Drawing.Point(230, 439);
            this.gözat.Name = "gözat";
            this.gözat.Size = new System.Drawing.Size(106, 36);
            this.gözat.TabIndex = 16;
            this.gözat.Text = "gözat";
            this.gözat.UseVisualStyleBackColor = true;
            this.gözat.Click += new System.EventHandler(this.button1_Click);
            // 
            // veri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 495);
            this.Controls.Add(this.gözat);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.export);
            this.Controls.Add(this.import);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.create);
            this.Controls.Add(this.view);
            this.Controls.Add(this.hdate);
            this.Controls.Add(this.pıd);
            this.Controls.Add(this.personalıd);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.info);
            this.Name = "veri";
            this.Text = "veri";
            this.Load += new System.EventHandler(this.veri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView info;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label hiredate;
        private System.Windows.Forms.Label personalıd;
        private System.Windows.Forms.TextBox pıd;
        private System.Windows.Forms.TextBox hdate;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.OpenFileDialog dosya;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Button gözat;
    }
}