
namespace Project_5
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
            this.butAddProp = new System.Windows.Forms.Button();
            this.butShowProp = new System.Windows.Forms.Button();
            this.butSearchProp = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Real State Agency";
            // 
            // butAddProp
            // 
            this.butAddProp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAddProp.Location = new System.Drawing.Point(8, 86);
            this.butAddProp.Margin = new System.Windows.Forms.Padding(2);
            this.butAddProp.Name = "butAddProp";
            this.butAddProp.Size = new System.Drawing.Size(172, 40);
            this.butAddProp.TabIndex = 1;
            this.butAddProp.Text = "Add Property";
            this.butAddProp.UseVisualStyleBackColor = true;
            this.butAddProp.Click += new System.EventHandler(this.butAddProp_Click);
            // 
            // butShowProp
            // 
            this.butShowProp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butShowProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowProp.Location = new System.Drawing.Point(317, 86);
            this.butShowProp.Margin = new System.Windows.Forms.Padding(2);
            this.butShowProp.Name = "butShowProp";
            this.butShowProp.Size = new System.Drawing.Size(178, 40);
            this.butShowProp.TabIndex = 2;
            this.butShowProp.Text = "Show All Properties";
            this.butShowProp.UseVisualStyleBackColor = true;
            this.butShowProp.Click += new System.EventHandler(this.butShowProp_Click);
            // 
            // butSearchProp
            // 
            this.butSearchProp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSearchProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearchProp.Location = new System.Drawing.Point(162, 148);
            this.butSearchProp.Margin = new System.Windows.Forms.Padding(2);
            this.butSearchProp.Name = "butSearchProp";
            this.butSearchProp.Size = new System.Drawing.Size(173, 46);
            this.butSearchProp.TabIndex = 3;
            this.butSearchProp.Text = "Search Properties";
            this.butSearchProp.UseVisualStyleBackColor = true;
            this.butSearchProp.Click += new System.EventHandler(this.butSearchProp_Click);
            // 
            // butExit
            // 
            this.butExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(161, 210);
            this.butExit.Margin = new System.Windows.Forms.Padding(2);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(173, 42);
            this.butExit.TabIndex = 4;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(5, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "team: Coders";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(503, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butSearchProp);
            this.Controls.Add(this.butShowProp);
            this.Controls.Add(this.butAddProp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAddProp;
        private System.Windows.Forms.Button butShowProp;
        private System.Windows.Forms.Button butSearchProp;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label label2;
    }
}

