
using System;

namespace Reporting_Interface
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
            this.buton_cautare = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buton_afisare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPiese = new System.Windows.Forms.Label();
            this.buton_report = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buton_cautare
            // 
            this.buton_cautare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buton_cautare.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_cautare.Location = new System.Drawing.Point(12, 365);
            this.buton_cautare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buton_cautare.Name = "buton_cautare";
            this.buton_cautare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buton_cautare.Size = new System.Drawing.Size(151, 48);
            this.buton_cautare.TabIndex = 0;
            this.buton_cautare.Text = "Search";
            this.buton_cautare.UseVisualStyleBackColor = false;
            this.buton_cautare.Click += new System.EventHandler(this.buton_cautare_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxID.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxID.Location = new System.Drawing.Point(194, 11);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(201, 39);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxID_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tested Data:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 456);
            this.dataGridView1.TabIndex = 5;
            // 
            // buton_afisare
            // 
            this.buton_afisare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buton_afisare.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_afisare.Location = new System.Drawing.Point(12, 446);
            this.buton_afisare.Name = "buton_afisare";
            this.buton_afisare.Size = new System.Drawing.Size(151, 47);
            this.buton_afisare.TabIndex = 6;
            this.buton_afisare.Text = "Open";
            this.buton_afisare.UseVisualStyleBackColor = false;
            this.buton_afisare.Click += new System.EventHandler(this.buton_afisare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 27);
            this.label3.TabIndex = 7;
            // 
            // totalPiese
            // 
            this.totalPiese.AutoSize = true;
            this.totalPiese.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPiese.Location = new System.Drawing.Point(7, 177);
            this.totalPiese.Name = "totalPiese";
            this.totalPiese.Size = new System.Drawing.Size(243, 26);
            this.totalPiese.TabIndex = 8;
            this.totalPiese.Text = "Total number of pieces";
            // 
            // buton_report
            // 
            this.buton_report.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buton_report.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton_report.Location = new System.Drawing.Point(12, 297);
            this.buton_report.Name = "buton_report";
            this.buton_report.Size = new System.Drawing.Size(151, 42);
            this.buton_report.TabIndex = 9;
            this.buton_report.Text = "Report";
            this.buton_report.UseVisualStyleBackColor = false;
            this.buton_report.Click += new System.EventHandler(this.buton_report_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1437, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buton_report);
            this.Controls.Add(this.totalPiese);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buton_afisare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.buton_cautare);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "open excel file and filter data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buton_cautare;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buton_afisare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPiese;
        private System.Windows.Forms.Button buton_report;
        private System.Windows.Forms.Label label4;
    }
}