namespace MouseInTheHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Instructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(276, 125);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(167, 44);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "PLAY >>";
            this.btn_Play.UseVisualStyleBackColor = true;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Instructions
            // 
            this.btn_Instructions.Location = new System.Drawing.Point(276, 199);
            this.btn_Instructions.Name = "btn_Instructions";
            this.btn_Instructions.Size = new System.Drawing.Size(167, 44);
            this.btn_Instructions.TabIndex = 1;
            this.btn_Instructions.Text = "<< How To Play This Game";
            this.btn_Instructions.UseVisualStyleBackColor = true;
            this.btn_Instructions.Click += new System.EventHandler(this.btn_Instructions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MouseInTheHouse.Properties.Resources.Welcome;
            this.ClientSize = new System.Drawing.Size(502, 419);
            this.Controls.Add(this.btn_Instructions);
            this.Controls.Add(this.btn_Play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome and Play";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Instructions;
    }
}

