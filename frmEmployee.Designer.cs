namespace Al_Madiina_Hotel
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.btnEditEm = new System.Windows.Forms.Button();
            this.btnDeleteEm = new System.Windows.Forms.Button();
            this.btnSaveEm = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.txtEmType = new System.Windows.Forms.TextBox();
            this.txtEmName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtEmID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditEm
            // 
            this.btnEditEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnEditEm.Location = new System.Drawing.Point(796, 535);
            this.btnEditEm.Name = "btnEditEm";
            this.btnEditEm.Size = new System.Drawing.Size(118, 66);
            this.btnEditEm.TabIndex = 19;
            this.btnEditEm.Text = "Edit";
            this.btnEditEm.UseVisualStyleBackColor = true;
            this.btnEditEm.Click += new System.EventHandler(this.btnEditEm_Click);
            // 
            // btnDeleteEm
            // 
            this.btnDeleteEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEm.Location = new System.Drawing.Point(638, 535);
            this.btnDeleteEm.Name = "btnDeleteEm";
            this.btnDeleteEm.Size = new System.Drawing.Size(118, 66);
            this.btnDeleteEm.TabIndex = 20;
            this.btnDeleteEm.Text = "Delete";
            this.btnDeleteEm.UseVisualStyleBackColor = true;
            this.btnDeleteEm.Click += new System.EventHandler(this.btnDeleteEm_Click);
            // 
            // btnSaveEm
            // 
            this.btnSaveEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSaveEm.Location = new System.Drawing.Point(485, 535);
            this.btnSaveEm.Name = "btnSaveEm";
            this.btnSaveEm.Size = new System.Drawing.Size(105, 66);
            this.btnSaveEm.TabIndex = 21;
            this.btnSaveEm.Text = "Save";
            this.btnSaveEm.UseVisualStyleBackColor = true;
            this.btnSaveEm.Click += new System.EventHandler(this.btnSaveEm_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(485, 134);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 62;
            this.dgvEmployee.RowTemplate.Height = 28;
            this.dgvEmployee.Size = new System.Drawing.Size(663, 363);
            this.dgvEmployee.TabIndex = 18;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // txtEmType
            // 
            this.txtEmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEmType.Location = new System.Drawing.Point(53, 323);
            this.txtEmType.Name = "txtEmType";
            this.txtEmType.Size = new System.Drawing.Size(354, 39);
            this.txtEmType.TabIndex = 17;
            // 
            // txtEmName
            // 
            this.txtEmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEmName.Location = new System.Drawing.Point(56, 458);
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.Size = new System.Drawing.Size(351, 39);
            this.txtEmName.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(46, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 41);
            this.label2.TabIndex = 14;
            this.label2.Text = "Employee Type:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(46, 134);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(145, 41);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Employee ID:";
            // 
            // txtEmID
            // 
            this.txtEmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmID.Location = new System.Drawing.Point(53, 189);
            this.txtEmID.Name = "txtEmID";
            this.txtEmID.Size = new System.Drawing.Size(354, 39);
            this.txtEmID.TabIndex = 12;
            this.txtEmID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1043, 535);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 66);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 68);
            this.label1.TabIndex = 10;
            this.label1.Text = "EMPLOYEE REGISTRATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(478, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 41);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search";
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textSearch.Location = new System.Drawing.Point(568, 81);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(580, 39);
            this.textSearch.TabIndex = 22;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(50)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1194, 629);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.btnEditEm);
            this.Controls.Add(this.btnDeleteEm);
            this.Controls.Add(this.btnSaveEm);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.txtEmType);
            this.Controls.Add(this.txtEmName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtEmID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditEm;
        private System.Windows.Forms.Button btnDeleteEm;
        private System.Windows.Forms.Button btnSaveEm;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtEmType;
        private System.Windows.Forms.TextBox txtEmName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtEmID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSearch;
    }
}