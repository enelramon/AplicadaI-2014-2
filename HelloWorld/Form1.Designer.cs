namespace HelloWorld
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
            this.label1 = new System.Windows.Forms.Label();
            this.Saludarbutton = new System.Windows.Forms.Button();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hola Mundo";
            // 
            // Saludarbutton
            // 
            this.Saludarbutton.Location = new System.Drawing.Point(44, 136);
            this.Saludarbutton.Name = "Saludarbutton";
            this.Saludarbutton.Size = new System.Drawing.Size(75, 23);
            this.Saludarbutton.TabIndex = 1;
            this.Saludarbutton.Text = "Saludar";
            this.Saludarbutton.UseVisualStyleBackColor = true;
            this.Saludarbutton.Click += new System.EventHandler(this.Saludarbutton_Click);
            // 
            // Salirbutton
            // 
            this.Salirbutton.Location = new System.Drawing.Point(190, 227);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(75, 23);
            this.Salirbutton.TabIndex = 2;
            this.Salirbutton.Text = "S&alir";
            this.Salirbutton.UseVisualStyleBackColor = true;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.Saludarbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Saludarbutton;
        private System.Windows.Forms.Button Salirbutton;
    }
}

