using System.ComponentModel;

namespace View.Views
{
    partial class OrderInfoView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedGoodsLbx = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedWarehouseLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.estimateProcessTimeLbl = new System.Windows.Forms.Label();
            this.orderSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectedGoodsLbx
            // 
            this.selectedGoodsLbx.FormattingEnabled = true;
            this.selectedGoodsLbx.ItemHeight = 14;
            this.selectedGoodsLbx.Location = new System.Drawing.Point(-1, 53);
            this.selectedGoodsLbx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectedGoodsLbx.Name = "selectedGoodsLbx";
            this.selectedGoodsLbx.Size = new System.Drawing.Size(221, 102);
            this.selectedGoodsLbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(-1, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected goods list:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(0, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected warehouse Info:";
            // 
            // selectedWarehouseLbl
            // 
            this.selectedWarehouseLbl.AutoSize = true;
            this.selectedWarehouseLbl.Location = new System.Drawing.Point(-1, 213);
            this.selectedWarehouseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedWarehouseLbl.Name = "selectedWarehouseLbl";
            this.selectedWarehouseLbl.Size = new System.Drawing.Size(110, 14);
            this.selectedWarehouseLbl.TabIndex = 5;
            this.selectedWarehouseLbl.Text = "Not yet selected";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(440, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "General info";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.totalCostLbl.Location = new System.Drawing.Point(440, 79);
            this.totalCostLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(179, 25);
            this.totalCostLbl.TabIndex = 7;
            this.totalCostLbl.Text = "Total Cost:";
            // 
            // estimateProcessTimeLbl
            // 
            this.estimateProcessTimeLbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.estimateProcessTimeLbl.Location = new System.Drawing.Point(440, 130);
            this.estimateProcessTimeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estimateProcessTimeLbl.Name = "estimateProcessTimeLbl";
            this.estimateProcessTimeLbl.Size = new System.Drawing.Size(179, 25);
            this.estimateProcessTimeLbl.TabIndex = 8;
            this.estimateProcessTimeLbl.Text = "Estimate process time: ";
            // 
            // orderSubmit
            // 
            this.orderSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderSubmit.Location = new System.Drawing.Point(440, 185);
            this.orderSubmit.Name = "orderSubmit";
            this.orderSubmit.Size = new System.Drawing.Size(107, 23);
            this.orderSubmit.TabIndex = 9;
            this.orderSubmit.Text = "Submit order";
            this.orderSubmit.UseVisualStyleBackColor = true;
            this.orderSubmit.Click += orderSubmit_Click;
            // 
            // OrderInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orderSubmit);
            this.Controls.Add(this.estimateProcessTimeLbl);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedWarehouseLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedGoodsLbx);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OrderInfoView";
            this.Size = new System.Drawing.Size(744, 267);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button orderSubmit;

        private System.Windows.Forms.Label estimateProcessTimeLbl;
        private System.Windows.Forms.Label totalCostLbl;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label selectedWarehouseLbl;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ListBox selectedGoodsLbx;

        #endregion
    }
}