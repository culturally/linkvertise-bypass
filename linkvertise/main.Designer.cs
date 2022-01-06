
namespace linktree
{
    partial class bypass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bypass));
            this.input = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.bypassb = new System.Windows.Forms.Button();
            this.bypassedtext = new System.Windows.Forms.TextBox();
            this.bypassedlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input.ForeColor = System.Drawing.Color.Gray;
            this.input.Location = new System.Drawing.Point(12, 85);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(184, 21);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.Control;
            this.text.Location = new System.Drawing.Point(8, 33);
            this.text.MinimumSize = new System.Drawing.Size(90, 13);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(213, 28);
            this.text.TabIndex = 1;
            this.text.Text = "Input Linkvertise Link";
            // 
            // bypassb
            // 
            this.bypassb.Location = new System.Drawing.Point(12, 136);
            this.bypassb.Name = "bypassb";
            this.bypassb.Size = new System.Drawing.Size(89, 29);
            this.bypassb.TabIndex = 2;
            this.bypassb.Text = "bypass";
            this.bypassb.UseVisualStyleBackColor = true;
            this.bypassb.Click += new System.EventHandler(this.bypassb_Click);
            // 
            // bypassedtext
            // 
            this.bypassedtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bypassedtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bypassedtext.ForeColor = System.Drawing.Color.Gray;
            this.bypassedtext.Location = new System.Drawing.Point(12, 320);
            this.bypassedtext.Name = "bypassedtext";
            this.bypassedtext.Size = new System.Drawing.Size(623, 20);
            this.bypassedtext.TabIndex = 3;
            this.bypassedtext.Visible = false;
            // 
            // bypassedlabel
            // 
            this.bypassedlabel.AutoSize = true;
            this.bypassedlabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bypassedlabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bypassedlabel.Location = new System.Drawing.Point(12, 268);
            this.bypassedlabel.Name = "bypassedlabel";
            this.bypassedlabel.Size = new System.Drawing.Size(159, 27);
            this.bypassedlabel.TabIndex = 4;
            this.bypassedlabel.Text = "Bypassed URL:";
            this.bypassedlabel.Visible = false;
            // 
            // bypass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bypassedlabel);
            this.Controls.Add(this.bypassedtext);
            this.Controls.Add(this.bypassb);
            this.Controls.Add(this.text);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bypass";
            this.Text = "detective#0001";
            this.Load += new System.EventHandler(this.bypass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button bypassb;
        private System.Windows.Forms.TextBox bypassedtext;
        private System.Windows.Forms.Label bypassedlabel;
    }
}

