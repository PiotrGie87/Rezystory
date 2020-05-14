namespace Rezystory
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
            this.butSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.pan1 = new System.Windows.Forms.Panel();
            this.pan2 = new System.Windows.Forms.Panel();
            this.pan3 = new System.Windows.Forms.Panel();
            this.pan4 = new System.Windows.Forms.Panel();
            this.butRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butSet
            // 
            this.butSet.Location = new System.Drawing.Point(205, 231);
            this.butSet.Name = "butSet";
            this.butSet.Size = new System.Drawing.Size(91, 21);
            this.butSet.TabIndex = 1;
            this.butSet.Text = "SET";
            this.butSet.UseVisualStyleBackColor = true;
            this.butSet.Click += new System.EventHandler(this.butSet_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(19, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 66);
            this.label1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(156, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(43, 20);
            this.panel1.TabIndex = 3;
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.SystemColors.Window;
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "Czarny",
            "Brązowy",
            "Czerwony",
            "Pomarańczowy",
            "Żółty",
            "Zielony",
            "Niebieski",
            "Fioletowy",
            "Szary",
            "Biały",
            "Złoty",
            "Srebrny"});
            this.colorBox.Location = new System.Drawing.Point(29, 230);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 21);
            this.colorBox.TabIndex = 4;
            this.colorBox.SelectedIndexChanged += new System.EventHandler(this.colorBox_SelectedIndexChanged);
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.Color.White;
            this.pan1.Location = new System.Drawing.Point(29, 54);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(24, 117);
            this.pan1.TabIndex = 5;
            // 
            // pan2
            // 
            this.pan2.BackColor = System.Drawing.Color.White;
            this.pan2.Location = new System.Drawing.Point(59, 54);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(24, 117);
            this.pan2.TabIndex = 6;
            // 
            // pan3
            // 
            this.pan3.BackColor = System.Drawing.Color.White;
            this.pan3.Location = new System.Drawing.Point(90, 54);
            this.pan3.Name = "pan3";
            this.pan3.Size = new System.Drawing.Size(24, 117);
            this.pan3.TabIndex = 7;
            // 
            // pan4
            // 
            this.pan4.BackColor = System.Drawing.Color.White;
            this.pan4.Location = new System.Drawing.Point(124, 54);
            this.pan4.Name = "pan4";
            this.pan4.Size = new System.Drawing.Size(24, 117);
            this.pan4.TabIndex = 8;
            this.pan4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // butRes
            // 
            this.butRes.Location = new System.Drawing.Point(171, 54);
            this.butRes.Name = "butRes";
            this.butRes.Size = new System.Drawing.Size(131, 117);
            this.butRes.TabIndex = 9;
            this.butRes.Text = "RESULT";
            this.butRes.UseVisualStyleBackColor = true;
            this.butRes.Click += new System.EventHandler(this.butRes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 330);
            this.Controls.Add(this.butRes);
            this.Controls.Add(this.pan4);
            this.Controls.Add(this.pan3);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Panel pan2;
        private System.Windows.Forms.Panel pan3;
        private System.Windows.Forms.Panel pan4;
        private System.Windows.Forms.Button butRes;
    }
}

