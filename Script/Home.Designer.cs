namespace ATM_Management_System
{
    partial class Home
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnFastCash = new System.Windows.Forms.Button();
            this.btnChangePIN = new System.Windows.Forms.Button();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.btnMiniStatement = new System.Windows.Forms.Button();
            this.btnBalnce = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.pHeader.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pHeader.Size = new System.Drawing.Size(876, 102);
            this.pHeader.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(846, 0);
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
            this.lblAtmManagementSystem.Location = new System.Drawing.Point(248, 25);
            this.lblAtmManagementSystem.Name = "lblAtmManagementSystem";
            this.lblAtmManagementSystem.Size = new System.Drawing.Size(424, 38);
            this.lblAtmManagementSystem.TabIndex = 1;
            this.lblAtmManagementSystem.Text = "ATM Management System";
            // 
            // pFotter
            // 
            this.pFotter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.pFotter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pFotter.Location = new System.Drawing.Point(0, 514);
            this.pFotter.Name = "pFotter";
            this.pFotter.Size = new System.Drawing.Size(876, 15);
            this.pFotter.TabIndex = 6;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeposit.Location = new System.Drawing.Point(181, 183);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(143, 41);
            this.btnDeposit.TabIndex = 13;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnFastCash
            // 
            this.btnFastCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFastCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnFastCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastCash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFastCash.Location = new System.Drawing.Point(181, 278);
            this.btnFastCash.Name = "btnFastCash";
            this.btnFastCash.Size = new System.Drawing.Size(143, 41);
            this.btnFastCash.TabIndex = 14;
            this.btnFastCash.Text = "Fast Cash";
            this.btnFastCash.UseVisualStyleBackColor = false;
            this.btnFastCash.Click += new System.EventHandler(this.btnFastCash_Click);
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnChangePIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePIN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePIN.Location = new System.Drawing.Point(181, 366);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(143, 41);
            this.btnChangePIN.TabIndex = 15;
            this.btnChangePIN.Text = "Change PIN";
            this.btnChangePIN.UseVisualStyleBackColor = false;
            this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWithDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnWithDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithDraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWithDraw.Location = new System.Drawing.Point(509, 183);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(147, 41);
            this.btnWithDraw.TabIndex = 16;
            this.btnWithDraw.Text = "WithDraw";
            this.btnWithDraw.UseVisualStyleBackColor = false;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // btnMiniStatement
            // 
            this.btnMiniStatement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMiniStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnMiniStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniStatement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMiniStatement.Location = new System.Drawing.Point(509, 278);
            this.btnMiniStatement.Name = "btnMiniStatement";
            this.btnMiniStatement.Size = new System.Drawing.Size(147, 41);
            this.btnMiniStatement.TabIndex = 17;
            this.btnMiniStatement.Text = "Mini Statement";
            this.btnMiniStatement.UseVisualStyleBackColor = false;
            this.btnMiniStatement.Click += new System.EventHandler(this.btnMiniStatement_Click);
            // 
            // btnBalnce
            // 
            this.btnBalnce.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBalnce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnBalnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalnce.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBalnce.Location = new System.Drawing.Point(509, 366);
            this.btnBalnce.Name = "btnBalnce";
            this.btnBalnce.Size = new System.Drawing.Size(147, 41);
            this.btnBalnce.TabIndex = 18;
            this.btnBalnce.Text = "Balance";
            this.btnBalnce.UseVisualStyleBackColor = false;
            this.btnBalnce.Click += new System.EventHandler(this.btnBalnce_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(56)))), ((int)(((byte)(60)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(336, 440);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(143, 41);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAccountNumber.Location = new System.Drawing.Point(331, 121);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(172, 25);
            this.lblAccountNumber.TabIndex = 20;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 529);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBalnce);
            this.Controls.Add(this.btnMiniStatement);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.btnFastCash);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.pFotter);
            this.Controls.Add(this.pHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAtmManagementSystem;
        private System.Windows.Forms.Panel pFotter;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnFastCash;
        private System.Windows.Forms.Button btnChangePIN;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Button btnMiniStatement;
        private System.Windows.Forms.Button btnBalnce;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblAccountNumber;
    }
}