﻿namespace TL_OOP_Projekt_KTA_23E
{
    partial class TL_Form_Main
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
            this.TL_btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TL_btn1
            // 
            this.TL_btn1.BackColor = System.Drawing.Color.ForestGreen;
            this.TL_btn1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TL_btn1.Location = new System.Drawing.Point(28, 27);
            this.TL_btn1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TL_btn1.Name = "TL_btn1";
            this.TL_btn1.Size = new System.Drawing.Size(195, 68);
            this.TL_btn1.TabIndex = 0;
            this.TL_btn1.Text = "25.01.2024";
            this.TL_btn1.UseVisualStyleBackColor = false;
            this.TL_btn1.Click += new System.EventHandler(this.TL_btn1_Click);
            // 
            // TL_Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 316);
            this.Controls.Add(this.TL_btn1);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TL_Form_Main";
            this.Text = "TL_KTA-23E";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TL_btn1;
    }
}

