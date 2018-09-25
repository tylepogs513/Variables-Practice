namespace Variables_Practice
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
            this.hockeyButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 249.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(341, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 377);
            this.label1.TabIndex = 0;
            this.label1.Text = "O";
            // 
            // hockeyButton
            // 
            this.hockeyButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyButton.Location = new System.Drawing.Point(86, 36);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(163, 47);
            this.hockeyButton.TabIndex = 1;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetButton.Location = new System.Drawing.Point(86, 258);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(163, 47);
            this.carpetButton.TabIndex = 2;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaButton.Location = new System.Drawing.Point(86, 142);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(163, 47);
            this.areaButton.TabIndex = 2;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(86, 366);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(163, 47);
            this.billButton.TabIndex = 3;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.BackColor = System.Drawing.Color.White;
            this.display.Font = new System.Drawing.Font("Courier New", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(368, 61);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(19, 20);
            this.display.TabIndex = 4;
            this.display.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.display);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.hockeyButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button billButton;
        private System.Windows.Forms.Label display;
    }
}

