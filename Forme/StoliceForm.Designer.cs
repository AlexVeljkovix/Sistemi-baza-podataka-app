namespace Test3.Forme
{
    partial class StoliceForm
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
            this.listStolice = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listStolice
            // 
            this.listStolice.HideSelection = false;
            this.listStolice.Location = new System.Drawing.Point(12, 12);
            this.listStolice.Name = "listStolice";
            this.listStolice.Size = new System.Drawing.Size(528, 294);
            this.listStolice.TabIndex = 0;
            this.listStolice.UseCompatibleStateImageBehavior = false;
            // 
            // StoliceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 328);
            this.Controls.Add(this.listStolice);
            this.Name = "StoliceForm";
            this.Text = "Pregled stomatoloskih stolica";
            this.Load += new System.EventHandler(this.StoliceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listStolice;
    }
}