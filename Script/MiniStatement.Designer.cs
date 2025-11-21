
namespace ATM_Management_System
{
    partial class MiniStatement
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
            this.pHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAtmManagementSystem = new System.Windows.Forms.Label();
            this.pFotter = new System.Windows.Forms.Panel();
            this.dgvMiniStatement = new System.Windows.Forms.DataGridView();
            this.TransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiniStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.pHeader.Controls.Add(this.panel1);
            this.pHeader.Controls.Add(this.lblAtmManagementSystem);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(800, 102);
            this.pHeader.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(770, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 102);
            this.panel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAtmManagementSystem
            // 
            this.lblAtmManagementSystem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAtmManagementSystem.AutoSize = true;
            this.lblAtmManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtmManagementSystem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAtmManagementSystem.Location = new System.Drawing.Point(248, 35);
            this.lblAtmManagementSystem.Name = "lblAtmManagementSystem";
            this.lblAtmManagementSystem.Size = new System.Drawing.Size(424, 38);
            this.lblAtmManagementSystem.TabIndex = 1;
            this.lblAtmManagementSystem.Text = "ATM Management System";
            // 
            // pFotter
            // 
            this.pFotter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.pFotter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFotter.Location = new System.Drawing.Point(0, 435);
            this.pFotter.Name = "pFotter";
            this.pFotter.Size = new System.Drawing.Size(800, 15);
            this.pFotter.TabIndex = 9;
            // 
            // dgvMiniStatement
            // 
            this.dgvMiniStatement.AllowUserToAddRows = false;
            this.dgvMiniStatement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMiniStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiniStatement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionID,
            this.AccountNumber,
            this.TransactionType,
            this.Amount,
            this.TransactionDate});
            this.dgvMiniStatement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMiniStatement.Location = new System.Drawing.Point(0, 102);
            this.dgvMiniStatement.Name = "dgvMiniStatement";
            this.dgvMiniStatement.RowHeadersVisible = false;
            this.dgvMiniStatement.RowHeadersWidth = 51;
            this.dgvMiniStatement.RowTemplate.Height = 24;
            this.dgvMiniStatement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMiniStatement.Size = new System.Drawing.Size(800, 333);
            this.dgvMiniStatement.TabIndex = 10;
            this.dgvMiniStatement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMiniStatement_CellContentClick);
            // 
            // TransactionID
            // 
            this.TransactionID.HeaderText = "TransactionID";
            this.TransactionID.MinimumWidth = 6;
            this.TransactionID.Name = "TransactionID";
            // 
            // AccountNumber
            // 
            this.AccountNumber.HeaderText = "AccountNumber";
            this.AccountNumber.MinimumWidth = 6;
            this.AccountNumber.Name = "AccountNumber";
            // 
            // TransactionType
            // 
            this.TransactionType.HeaderText = "Transaction Type";
            this.TransactionType.MinimumWidth = 6;
            this.TransactionType.Name = "TransactionType";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "Transaction Date";
            this.TransactionDate.MinimumWidth = 6;
            this.TransactionDate.Name = "TransactionDate";
            // 
            // MiniStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMiniStatement);
            this.Controls.Add(this.pFotter);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniStatement";
            this.Text = "MiniStatement";
            this.Load += new System.EventHandler(this.MiniStatement_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiniStatement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAtmManagementSystem;
        private System.Windows.Forms.Panel pFotter;
        private System.Windows.Forms.DataGridView dgvMiniStatement;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
    }
}