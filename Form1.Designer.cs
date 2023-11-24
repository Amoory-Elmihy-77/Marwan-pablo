namespace task
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.oper = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.show);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.oper);
            this.groupBox1.Controls.Add(this.fileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(76, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 536);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files\' Operations APP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(60, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "File\'s Name: ";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(160, 60);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(280, 20);
            this.fileName.TabIndex = 1;
            // 
            // oper
            // 
            this.oper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.oper.Location = new System.Drawing.Point(245, 104);
            this.oper.Name = "oper";
            this.oper.Size = new System.Drawing.Size(115, 36);
            this.oper.TabIndex = 2;
            this.oper.Text = "Operation";
            this.oper.UseVisualStyleBackColor = true;
            this.oper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oper_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(60, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "File\'s Content: ";
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.show.Location = new System.Drawing.Point(63, 217);
            this.show.Multiline = true;
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(536, 260);
            this.show.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 607);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button oper;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label1;
    }
}

