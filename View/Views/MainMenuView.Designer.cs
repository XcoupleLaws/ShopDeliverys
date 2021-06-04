
namespace View
{
    partial class MainMenuView
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
            this.UsrNameLbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.orderOptionsBtn = new System.Windows.Forms.Button();
            this.orderInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsrNameLbl
            // 
            this.UsrNameLbl.AutoSize = true;
            this.UsrNameLbl.Location = new System.Drawing.Point(716, 4);
            this.UsrNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsrNameLbl.Name = "UsrNameLbl";
            this.UsrNameLbl.Size = new System.Drawing.Size(80, 19);
            this.UsrNameLbl.TabIndex = 1;
            this.UsrNameLbl.Text = "Username";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.mainPanel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mainPanel.Location = new System.Drawing.Point(12, 75);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(773, 433);
            this.mainPanel.TabIndex = 12;
            // 
            // orderOptionsBtn
            // 
            this.orderOptionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderOptionsBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.orderOptionsBtn.Location = new System.Drawing.Point(251, 34);
            this.orderOptionsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderOptionsBtn.Name = "orderOptionsBtn";
            this.orderOptionsBtn.Size = new System.Drawing.Size(157, 34);
            this.orderOptionsBtn.TabIndex = 11;
            this.orderOptionsBtn.Text = "Order options";
            this.orderOptionsBtn.UseVisualStyleBackColor = true;
            this.orderOptionsBtn.Click += new System.EventHandler(this.orderOptionsBtn_Click);
            // 
            // orderInfoBtn
            // 
            this.orderInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderInfoBtn.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.orderInfoBtn.Location = new System.Drawing.Point(416, 34);
            this.orderInfoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.orderInfoBtn.Name = "orderInfoBtn";
            this.orderInfoBtn.Size = new System.Drawing.Size(157, 34);
            this.orderInfoBtn.TabIndex = 13;
            this.orderInfoBtn.Text = "Order Info";
            this.orderInfoBtn.UseVisualStyleBackColor = true;
            this.orderInfoBtn.Click += new System.EventHandler(this.orderInfoBtn_Click);
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.ClientSize = new System.Drawing.Size(797, 520);
            this.Controls.Add(this.orderInfoBtn);
            this.Controls.Add(this.orderOptionsBtn);
            this.Controls.Add(this.UsrNameLbl);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenuView";
            this.Text = "Order Menu";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label UsrNameLbl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button orderOptionsBtn;
        private System.Windows.Forms.Button orderInfoBtn;
    }
}

