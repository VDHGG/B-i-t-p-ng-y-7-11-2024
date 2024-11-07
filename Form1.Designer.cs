namespace SimTge
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
            this.dgvSimThe = new System.Windows.Forms.DataGridView();
            this.TaiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimThe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSimThe
            // 
            this.dgvSimThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimThe.Location = new System.Drawing.Point(26, 32);
            this.dgvSimThe.Name = "dgvSimThe";
            this.dgvSimThe.RowHeadersWidth = 51;
            this.dgvSimThe.RowTemplate.Height = 24;
            this.dgvSimThe.Size = new System.Drawing.Size(913, 207);
            this.dgvSimThe.TabIndex = 0;
            // 
            // TaiButton
            // 
            this.TaiButton.Location = new System.Drawing.Point(408, 292);
            this.TaiButton.Name = "TaiButton";
            this.TaiButton.Size = new System.Drawing.Size(163, 38);
            this.TaiButton.TabIndex = 1;
            this.TaiButton.Text = "tải";
            this.TaiButton.UseVisualStyleBackColor = true;
            this.TaiButton.Click += new System.EventHandler(this.TaiButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.TaiButton);
            this.Controls.Add(this.dgvSimThe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimThe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSimThe;
        private System.Windows.Forms.Button TaiButton;
    }
}

