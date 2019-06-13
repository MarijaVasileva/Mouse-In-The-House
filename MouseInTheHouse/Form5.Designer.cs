namespace MouseInTheHouse
{
    partial class YouLost_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouLost_Form));
            this.btn_yes = new System.Windows.Forms.Button();
            this.btn_NO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_yes
            // 
            this.btn_yes.Location = new System.Drawing.Point(12, 226);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(102, 45);
            this.btn_yes.TabIndex = 0;
            this.btn_yes.Text = "YES";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // btn_NO
            // 
            this.btn_NO.Location = new System.Drawing.Point(177, 226);
            this.btn_NO.Name = "btn_NO";
            this.btn_NO.Size = new System.Drawing.Size(99, 45);
            this.btn_NO.TabIndex = 1;
            this.btn_NO.Text = "NO";
            this.btn_NO.UseVisualStyleBackColor = true;
            this.btn_NO.Click += new System.EventHandler(this.btn_NO_Click);
            // 
            // YouLost_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MouseInTheHouse.Properties.Resources.Lose;
            this.ClientSize = new System.Drawing.Size(662, 358);
            this.Controls.Add(this.btn_NO);
            this.Controls.Add(this.btn_yes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YouLost_Form";
            this.Text = "Better luck next time :)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_NO;
    }
}