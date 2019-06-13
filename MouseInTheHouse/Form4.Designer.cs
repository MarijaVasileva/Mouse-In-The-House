namespace MouseInTheHouse
{
    partial class Congratulations_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Congratulations_Form));
            this.btn_YES = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_YES
            // 
            this.btn_YES.Location = new System.Drawing.Point(35, 227);
            this.btn_YES.Name = "btn_YES";
            this.btn_YES.Size = new System.Drawing.Size(88, 37);
            this.btn_YES.TabIndex = 0;
            this.btn_YES.Text = "YES";
            this.btn_YES.UseVisualStyleBackColor = true;
            this.btn_YES.Click += new System.EventHandler(this.btn_YES_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(159, 227);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 37);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Congratulations_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MouseInTheHouse.Properties.Resources.Winner;
            this.ClientSize = new System.Drawing.Size(559, 359);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_YES);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Congratulations_Form";
            this.Text = "You Won!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_YES;
        private System.Windows.Forms.Button btn_Exit;
    }
}