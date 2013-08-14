namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.openBttn = new System.Windows.Forms.Button();
            this.saveBttn = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.modelBttn = new System.Windows.Forms.RadioButton();
            this.textureBttn = new System.Windows.Forms.RadioButton();
            this.soundBttn = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBttn
            // 
            this.openBttn.Location = new System.Drawing.Point(12, 12);
            this.openBttn.Name = "openBttn";
            this.openBttn.Size = new System.Drawing.Size(75, 23);
            this.openBttn.TabIndex = 0;
            this.openBttn.Text = "Open";
            this.openBttn.UseVisualStyleBackColor = true;
            this.openBttn.Click += new System.EventHandler(this.openBttn_Click);
            // 
            // saveBttn
            // 
            this.saveBttn.Location = new System.Drawing.Point(413, 370);
            this.saveBttn.Name = "saveBttn";
            this.saveBttn.Size = new System.Drawing.Size(122, 36);
            this.saveBttn.TabIndex = 1;
            this.saveBttn.Text = "Save";
            this.saveBttn.UseVisualStyleBackColor = true;
            this.saveBttn.Click += new System.EventHandler(this.saveBttn_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "Valve Map File|*.vmf";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(104, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 47);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(524, 317);
            this.textBox2.TabIndex = 3;
            this.textBox2.WordWrap = false;
            // 
            // sfd
            // 
            this.sfd.Filter = "Text file| *.txt";
            // 
            // modelBttn
            // 
            this.modelBttn.AutoSize = true;
            this.modelBttn.Checked = true;
            this.modelBttn.Location = new System.Drawing.Point(6, 19);
            this.modelBttn.Name = "modelBttn";
            this.modelBttn.Size = new System.Drawing.Size(59, 17);
            this.modelBttn.TabIndex = 4;
            this.modelBttn.TabStop = true;
            this.modelBttn.Text = "Models";
            this.modelBttn.UseVisualStyleBackColor = true;
            // 
            // textureBttn
            // 
            this.textureBttn.AutoSize = true;
            this.textureBttn.Location = new System.Drawing.Point(71, 19);
            this.textureBttn.Name = "textureBttn";
            this.textureBttn.Size = new System.Drawing.Size(66, 17);
            this.textureBttn.TabIndex = 5;
            this.textureBttn.Text = "Textures";
            this.textureBttn.UseVisualStyleBackColor = true;
            // 
            // soundBttn
            // 
            this.soundBttn.AutoSize = true;
            this.soundBttn.Location = new System.Drawing.Point(141, 19);
            this.soundBttn.Name = "soundBttn";
            this.soundBttn.Size = new System.Drawing.Size(56, 17);
            this.soundBttn.TabIndex = 6;
            this.soundBttn.Text = "Sound";
            this.soundBttn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modelBttn);
            this.groupBox1.Controls.Add(this.soundBttn);
            this.groupBox1.Controls.Add(this.textureBttn);
            this.groupBox1.Location = new System.Drawing.Point(12, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 40);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.saveBttn);
            this.Controls.Add(this.openBttn);
            this.Name = "Form1";
            this.Text = "VMF Asset Reporter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openBttn;
        private System.Windows.Forms.Button saveBttn;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.RadioButton modelBttn;
        private System.Windows.Forms.RadioButton textureBttn;
        private System.Windows.Forms.RadioButton soundBttn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

