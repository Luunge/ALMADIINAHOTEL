namespace Al_Madiina_Hotel
{
    partial class frmCustomero
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomero));
            this.txtCostName = new System.Windows.Forms.TextBox();
            this.txtCostService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostID = new System.Windows.Forms.TextBox();
            this.btnExitDash = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.Label();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgCustomers = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCostName
            // 
            this.txtCostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCostName.Location = new System.Drawing.Point(65, 293);
            this.txtCostName.Name = "txtCostName";
            this.txtCostName.Size = new System.Drawing.Size(306, 39);
            this.txtCostName.TabIndex = 17;
            // 
            // txtCostService
            // 
            this.txtCostService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCostService.Location = new System.Drawing.Point(65, 422);
            this.txtCostService.Name = "txtCostService";
            this.txtCostService.Size = new System.Drawing.Size(306, 39);
            this.txtCostService.TabIndex = 16;
            this.txtCostService.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 41);
            this.label3.TabIndex = 13;
            this.label3.Text = "Service:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 41);
            this.label2.TabIndex = 14;
            this.label2.Text = "Costumer Name:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1133, 644);
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
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 68);
            this.label1.TabIndex = 10;
            this.label1.Text = "COSTUMERS";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(65, 644);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 66);
            this.btnSubmit.TabIndex = 43;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 41);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID:";
            // 
            // txtCostID
            // 
            this.txtCostID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCostID.Location = new System.Drawing.Point(65, 173);
            this.txtCostID.Name = "txtCostID";
            this.txtCostID.Size = new System.Drawing.Size(306, 39);
            this.txtCostID.TabIndex = 44;
            // 
            // btnExitDash
            // 
            this.btnExitDash.FlatAppearance.BorderSize = 0;
            this.btnExitDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitDash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDash.ForeColor = System.Drawing.Color.White;
            this.btnExitDash.Location = new System.Drawing.Point(1226, 2);
            this.btnExitDash.Name = "btnExitDash";
            this.btnExitDash.Size = new System.Drawing.Size(39, 41);
            this.btnExitDash.TabIndex = 45;
            this.btnExitDash.Text = "X";
            this.btnExitDash.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(56, 493);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(76, 41);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.Text = "Price:";
            // 
            // textPrice
            // 
            this.textPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textPrice.Location = new System.Drawing.Point(63, 549);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(306, 39);
            this.textPrice.TabIndex = 16;
            this.textPrice.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvgCustomers);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(417, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 504);
            this.panel1.TabIndex = 46;
            // 
            // dvgCustomers
            // 
            this.dvgCustomers.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dvgCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCustomers.ColumnHeadersHeight = 40;
            this.dvgCustomers.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dvgCustomers.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dvgCustomers.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dvgCustomers.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dvgCustomers.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dvgCustomers.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dvgCustomers.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dvgCustomers.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dvgCustomers.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dvgCustomers.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dvgCustomers.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dvgCustomers.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dvgCustomers.CurrentTheme.Name = null;
            this.dvgCustomers.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dvgCustomers.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dvgCustomers.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dvgCustomers.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dvgCustomers.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvgCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvgCustomers.EnableHeadersVisualStyles = false;
            this.dvgCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dvgCustomers.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dvgCustomers.HeaderBgColor = System.Drawing.Color.Empty;
            this.dvgCustomers.HeaderForeColor = System.Drawing.Color.White;
            this.dvgCustomers.Location = new System.Drawing.Point(19, 69);
            this.dvgCustomers.Name = "dvgCustomers";
            this.dvgCustomers.RowHeadersVisible = false;
            this.dvgCustomers.RowHeadersWidth = 62;
            this.dvgCustomers.RowTemplate.Height = 40;
            this.dvgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCustomers.Size = new System.Drawing.Size(776, 415);
            this.dvgCustomers.TabIndex = 16;
            this.dvgCustomers.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dvgCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCustomers_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Oswald", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 41);
            this.label5.TabIndex = 15;
            this.label5.Text = "Costumer List:";
            // 
            // frmCustomero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(86)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(1268, 790);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExitDash);
            this.Controls.Add(this.txtCostID);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCostName);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCostService);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCostName;
        private System.Windows.Forms.TextBox txtCostService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCostID;
        private System.Windows.Forms.Button btnExitDash;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuDataGridView dvgCustomers;
        private System.Windows.Forms.Label label5;
    }
}