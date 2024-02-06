namespace States_AnnaStefanacci_CPT206
{
    partial class StateInfoForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxStateInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(13, 13);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(119, 38);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close Form";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxStateInfo
            // 
            this.textBoxStateInfo.BackColor = System.Drawing.Color.MidnightBlue;
            this.textBoxStateInfo.ForeColor = System.Drawing.Color.White;
            this.textBoxStateInfo.Location = new System.Drawing.Point(124, 71);
            this.textBoxStateInfo.Multiline = true;
            this.textBoxStateInfo.Name = "textBoxStateInfo";
            this.textBoxStateInfo.Size = new System.Drawing.Size(445, 278);
            this.textBoxStateInfo.TabIndex = 1;
            this.textBoxStateInfo.TabStop = false;
            // 
            // StateInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(694, 380);
            this.Controls.Add(this.textBoxStateInfo);
            this.Controls.Add(this.buttonClose);
            this.Font = new System.Drawing.Font("Complex_IV25", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StateInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxStateInfo;
    }
}