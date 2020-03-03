namespace Week0701
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
            this.btnRand = new System.Windows.Forms.Button();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRand
            // 
            this.btnRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRand.Location = new System.Drawing.Point(12, 12);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(186, 57);
            this.btnRand.TabIndex = 0;
            this.btnRand.Text = "Generate Random Numbers";
            this.btnRand.UseVisualStyleBackColor = true;
            this.btnRand.Click += new System.EventHandler(this.btnRand_Click);
            // 
            // btnSmall
            // 
            this.btnSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmall.Location = new System.Drawing.Point(107, 76);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(91, 39);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "Smallest";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLarge.Location = new System.Drawing.Point(12, 75);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(92, 40);
            this.btnLarge.TabIndex = 2;
            this.btnLarge.Text = "Largest";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(12, 131);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(185, 264);
            this.lstDisplay.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 40);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(107, 402);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 39);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.btnRand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Button btnLarge;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

