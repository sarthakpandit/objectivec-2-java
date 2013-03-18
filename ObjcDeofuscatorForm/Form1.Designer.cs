namespace ObjcDeofuscatorForm
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
            this.tbIn = new System.Windows.Forms.TextBox();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIn
            // 
            this.tbIn.Location = new System.Drawing.Point(34, 74);
            this.tbIn.Multiline = true;
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(391, 519);
            this.tbIn.TabIndex = 0;
            this.tbIn.TextChanged += new System.EventHandler(this.tbIn_TextChanged);
            // 
            // tbOut
            // 
            this.tbOut.Location = new System.Drawing.Point(561, 74);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(391, 519);
            this.tbOut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usage: Just paste your Objective C code in the left-side text box and profit!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 679);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOut);
            this.Controls.Add(this.tbIn);
            this.Name = "Form1";
            this.Text = "[BETA] Objective C to Java";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIn;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Label label1;
    }
}

