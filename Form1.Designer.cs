namespace Rtm_Ps3
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.trackBarKnockback = new System.Windows.Forms.TrackBar();
            this.trackBarFov = new System.Windows.Forms.TrackBar();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnockback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFov)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Oxanium Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Oxanium Medium", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(241, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Attach";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(234)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Oxanium Medium", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(141, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "KNOCKBACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(234)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Oxanium Medium", 12F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(141, 143);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 78);
            this.button4.TabIndex = 4;
            this.button4.Text = "GODMODE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(206)))), ((int)(((byte)(234)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(226)))), ((int)(((byte)(234)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Oxanium Medium", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(141, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 78);
            this.button5.TabIndex = 5;
            this.button5.Text = "FOV";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // trackBarKnockback
            // 
            this.trackBarKnockback.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarKnockback.Location = new System.Drawing.Point(340, 237);
            this.trackBarKnockback.Minimum = 1;
            this.trackBarKnockback.Name = "trackBarKnockback";
            this.trackBarKnockback.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarKnockback.Size = new System.Drawing.Size(56, 78);
            this.trackBarKnockback.TabIndex = 6;
            this.trackBarKnockback.Value = 1;
            this.trackBarKnockback.Scroll += new System.EventHandler(this.trackBarKnockback_Scroll);
            // 
            // trackBarFov
            // 
            this.trackBarFov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBarFov.Location = new System.Drawing.Point(340, 331);
            this.trackBarFov.Minimum = 1;
            this.trackBarFov.Name = "trackBarFov";
            this.trackBarFov.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarFov.Size = new System.Drawing.Size(56, 78);
            this.trackBarFov.TabIndex = 7;
            this.trackBarFov.Value = 1;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInfo.BackColor = System.Drawing.SystemColors.Window;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Oxanium Medium", 12F, System.Drawing.FontStyle.Bold);
            this.buttonInfo.Location = new System.Drawing.Point(12, 593);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(55, 48);
            this.buttonInfo.TabIndex = 8;
            this.buttonInfo.Text = "?";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 476);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(458, 82);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.trackBarFov);
            this.Controls.Add(this.trackBarKnockback);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(5000, 7000);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaphirO\'s RTM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKnockback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBarKnockback;
        private System.Windows.Forms.TrackBar trackBarFov;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.TextBox textBox1;
    }
}

