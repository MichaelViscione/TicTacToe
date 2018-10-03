namespace WindowsFormsApp2
{
    partial class TicTacToe
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
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Gainsboro;
            this.A1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A1.Location = new System.Drawing.Point(12, 52);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(70, 70);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Gainsboro;
            this.A2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A2.Location = new System.Drawing.Point(88, 52);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(70, 70);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Gainsboro;
            this.A3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A3.Location = new System.Drawing.Point(164, 52);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(70, 70);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Gainsboro;
            this.B1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B1.Location = new System.Drawing.Point(12, 128);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(70, 70);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Gainsboro;
            this.B2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B2.Location = new System.Drawing.Point(88, 128);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(70, 70);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Gainsboro;
            this.B3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B3.Location = new System.Drawing.Point(164, 128);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(70, 70);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Gainsboro;
            this.C1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C1.Location = new System.Drawing.Point(12, 204);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(70, 70);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Gainsboro;
            this.C2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C2.Location = new System.Drawing.Point(88, 204);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(70, 70);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Gainsboro;
            this.C3.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C3.Location = new System.Drawing.Point(164, 204);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(70, 70);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(88, 12);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(70, 24);
            this.reset.TabIndex = 9;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 286);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(262, 325);
            this.MinimumSize = new System.Drawing.Size(262, 325);
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button reset;
    }
}

