namespace bkColorChange
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
            this.btnBkClrChange = new System.Windows.Forms.Button();
            this.panelClr = new System.Windows.Forms.Panel();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnOliveDrab = new System.Windows.Forms.Button();
            this.btnTeal = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnDSGray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelClr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBkClrChange
            // 
            this.btnBkClrChange.Location = new System.Drawing.Point(713, 33);
            this.btnBkClrChange.Name = "btnBkClrChange";
            this.btnBkClrChange.Size = new System.Drawing.Size(75, 23);
            this.btnBkClrChange.TabIndex = 0;
            this.btnBkClrChange.Text = "Color Change";
            this.btnBkClrChange.UseVisualStyleBackColor = true;
            this.btnBkClrChange.Click += new System.EventHandler(this.btnBkClrChange_Click);
            // 
            // panelClr
            // 
            this.panelClr.BackColor = System.Drawing.Color.Snow;
            this.panelClr.Controls.Add(this.btnDSGray);
            this.panelClr.Controls.Add(this.button1);
            this.panelClr.Controls.Add(this.btnBlack);
            this.panelClr.Location = new System.Drawing.Point(-2, -1);
            this.panelClr.Name = "panelClr";
            this.panelClr.Size = new System.Drawing.Size(802, 452);
            this.panelClr.TabIndex = 1;
            // 
            // btnBlack
            // 
            this.btnBlack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBlack.FlatAppearance.BorderSize = 0;
            this.btnBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlack.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlack.Location = new System.Drawing.Point(731, 87);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(50, 50);
            this.btnBlack.TabIndex = 31;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOliveDrab
            // 
            this.btnOliveDrab.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnOliveDrab.BackColor = System.Drawing.Color.OliveDrab;
            this.btnOliveDrab.FlatAppearance.BorderSize = 0;
            this.btnOliveDrab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOliveDrab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOliveDrab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOliveDrab.Location = new System.Drawing.Point(729, 147);
            this.btnOliveDrab.Name = "btnOliveDrab";
            this.btnOliveDrab.Size = new System.Drawing.Size(50, 50);
            this.btnOliveDrab.TabIndex = 32;
            this.btnOliveDrab.UseVisualStyleBackColor = false;
            this.btnOliveDrab.Click += new System.EventHandler(this.btnOliveDrab_Click);
            // 
            // btnTeal
            // 
            this.btnTeal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTeal.BackColor = System.Drawing.Color.Teal;
            this.btnTeal.FlatAppearance.BorderSize = 0;
            this.btnTeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTeal.Location = new System.Drawing.Point(729, 207);
            this.btnTeal.Name = "btnTeal";
            this.btnTeal.Size = new System.Drawing.Size(50, 50);
            this.btnTeal.TabIndex = 33;
            this.btnTeal.UseVisualStyleBackColor = false;
            this.btnTeal.Click += new System.EventHandler(this.btnTeal_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPurple.BackColor = System.Drawing.Color.Purple;
            this.btnPurple.FlatAppearance.BorderSize = 0;
            this.btnPurple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurple.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurple.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPurple.Location = new System.Drawing.Point(729, 267);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(50, 50);
            this.btnPurple.TabIndex = 34;
            this.btnPurple.UseVisualStyleBackColor = false;
            this.btnPurple.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDSGray
            // 
            this.btnDSGray.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDSGray.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDSGray.FlatAppearance.BorderSize = 0;
            this.btnDSGray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSGray.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSGray.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDSGray.Location = new System.Drawing.Point(732, 327);
            this.btnDSGray.Name = "btnDSGray";
            this.btnDSGray.Size = new System.Drawing.Size(50, 50);
            this.btnDSGray.TabIndex = 35;
            this.btnDSGray.UseVisualStyleBackColor = false;
            this.btnDSGray.Click += new System.EventHandler(this.btnDSGray_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnTeal);
            this.Controls.Add(this.btnOliveDrab);
            this.Controls.Add(this.btnBkClrChange);
            this.Controls.Add(this.panelClr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelClr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBkClrChange;
        private System.Windows.Forms.Panel panelClr;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnOliveDrab;
        private System.Windows.Forms.Button btnTeal;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnDSGray;
        private System.Windows.Forms.Button button1;
    }
}

