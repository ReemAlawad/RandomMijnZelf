namespace RandomMijnZelf
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lstAllStudents = new System.Windows.Forms.ListBox();
            this.lstGroup = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
           
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(540, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(160, 34);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "CreateGroup";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lstAllStudents
            // 
            this.lstAllStudents.FormattingEnabled = true;
            this.lstAllStudents.ItemHeight = 20;
            this.lstAllStudents.Location = new System.Drawing.Point(96, 68);
            this.lstAllStudents.Name = "lstAllStudents";
            this.lstAllStudents.Size = new System.Drawing.Size(201, 304);
            this.lstAllStudents.TabIndex = 2;
           
            // 
            // lstGroup
            // 
            this.lstGroup.FormattingEnabled = true;
            this.lstGroup.ItemHeight = 20;
            this.lstGroup.Location = new System.Drawing.Point(502, 135);
            this.lstGroup.Name = "lstGroup";
            this.lstGroup.Size = new System.Drawing.Size(179, 244);
            this.lstGroup.TabIndex = 3;
           
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(581, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 4;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstGroup);
            this.Controls.Add(this.lstAllStudents);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ListBox lstAllStudents;
        private System.Windows.Forms.ListBox lstGroup;
        private System.Windows.Forms.TextBox textBox1;
    }
}

