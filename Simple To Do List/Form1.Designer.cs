namespace Simple_To_Do_List
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel0 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textNewTask = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete1 = new System.Windows.Forms.Button();
            this.done1 = new System.Windows.Forms.Button();
            this.edit1 = new System.Windows.Forms.Button();
            this.ok1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delete2 = new System.Windows.Forms.Button();
            this.done2 = new System.Windows.Forms.Button();
            this.edit2 = new System.Windows.Forms.Button();
            this.ok2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.delete3 = new System.Windows.Forms.Button();
            this.done3 = new System.Windows.Forms.Button();
            this.edit3 = new System.Windows.Forms.Button();
            this.ok3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.delete4 = new System.Windows.Forms.Button();
            this.done4 = new System.Windows.Forms.Button();
            this.edit4 = new System.Windows.Forms.Button();
            this.ok4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.delete5 = new System.Windows.Forms.Button();
            this.done5 = new System.Windows.Forms.Button();
            this.edit5 = new System.Windows.Forms.Button();
            this.ok5 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple To Do List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Task :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "1.";
            // 
            // panel0
            // 
            this.panel0.Controls.Add(this.button1);
            this.panel0.Controls.Add(this.textNewTask);
            this.panel0.Controls.Add(this.label2);
            this.panel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel0.Location = new System.Drawing.Point(17, 108);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(938, 57);
            this.panel0.TabIndex = 3;
            this.panel0.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNewTask
            // 
            this.textNewTask.Location = new System.Drawing.Point(135, 16);
            this.textNewTask.Name = "textNewTask";
            this.textNewTask.Size = new System.Drawing.Size(489, 30);
            this.textNewTask.TabIndex = 2;
            this.textNewTask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.delete1);
            this.panel1.Controls.Add(this.done1);
            this.panel1.Controls.Add(this.edit1);
            this.panel1.Controls.Add(this.ok1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(17, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 56);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(827, 7);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(102, 42);
            this.delete1.TabIndex = 7;
            this.delete1.Text = "Delete";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // done1
            // 
            this.done1.Location = new System.Drawing.Point(724, 7);
            this.done1.Name = "done1";
            this.done1.Size = new System.Drawing.Size(97, 42);
            this.done1.TabIndex = 6;
            this.done1.Text = "Done";
            this.done1.UseVisualStyleBackColor = true;
            this.done1.Click += new System.EventHandler(this.done1_Click);
            // 
            // edit1
            // 
            this.edit1.Location = new System.Drawing.Point(616, 7);
            this.edit1.Name = "edit1";
            this.edit1.Size = new System.Drawing.Size(102, 42);
            this.edit1.TabIndex = 5;
            this.edit1.Text = "Edit";
            this.edit1.UseVisualStyleBackColor = true;
            this.edit1.Click += new System.EventHandler(this.edit1_Click);
            // 
            // ok1
            // 
            this.ok1.Location = new System.Drawing.Point(506, 8);
            this.ok1.Name = "ok1";
            this.ok1.Size = new System.Drawing.Size(104, 41);
            this.ok1.TabIndex = 4;
            this.ok1.Text = "Ok";
            this.ok1.UseVisualStyleBackColor = true;
            this.ok1.Visible = false;
            this.ok1.Click += new System.EventHandler(this.ok1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(450, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.delete2);
            this.panel2.Controls.Add(this.done2);
            this.panel2.Controls.Add(this.edit2);
            this.panel2.Controls.Add(this.ok2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(17, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 56);
            this.panel2.TabIndex = 8;
            this.panel2.Visible = false;
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(827, 7);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(102, 42);
            this.delete2.TabIndex = 7;
            this.delete2.Text = "Delete";
            this.delete2.UseVisualStyleBackColor = true;
            this.delete2.Click += new System.EventHandler(this.delete2_Click);
            // 
            // done2
            // 
            this.done2.Location = new System.Drawing.Point(724, 7);
            this.done2.Name = "done2";
            this.done2.Size = new System.Drawing.Size(97, 42);
            this.done2.TabIndex = 6;
            this.done2.Text = "Done";
            this.done2.UseVisualStyleBackColor = true;
            this.done2.Click += new System.EventHandler(this.done2_Click);
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(616, 7);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(102, 42);
            this.edit2.TabIndex = 5;
            this.edit2.Text = "Edit";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // ok2
            // 
            this.ok2.Location = new System.Drawing.Point(506, 8);
            this.ok2.Name = "ok2";
            this.ok2.Size = new System.Drawing.Size(104, 41);
            this.ok2.TabIndex = 4;
            this.ok2.Text = "Ok";
            this.ok2.UseVisualStyleBackColor = true;
            this.ok2.Visible = false;
            this.ok2.Click += new System.EventHandler(this.ok2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(450, 30);
            this.textBox2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "2.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.delete3);
            this.panel3.Controls.Add(this.done3);
            this.panel3.Controls.Add(this.edit3);
            this.panel3.Controls.Add(this.ok3);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(17, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 56);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // delete3
            // 
            this.delete3.Location = new System.Drawing.Point(827, 7);
            this.delete3.Name = "delete3";
            this.delete3.Size = new System.Drawing.Size(102, 42);
            this.delete3.TabIndex = 7;
            this.delete3.Text = "Delete";
            this.delete3.UseVisualStyleBackColor = true;
            this.delete3.Click += new System.EventHandler(this.delete3_Click);
            // 
            // done3
            // 
            this.done3.Location = new System.Drawing.Point(724, 7);
            this.done3.Name = "done3";
            this.done3.Size = new System.Drawing.Size(97, 42);
            this.done3.TabIndex = 6;
            this.done3.Text = "Done";
            this.done3.UseVisualStyleBackColor = true;
            this.done3.Click += new System.EventHandler(this.done3_Click);
            // 
            // edit3
            // 
            this.edit3.Location = new System.Drawing.Point(616, 7);
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(102, 42);
            this.edit3.TabIndex = 5;
            this.edit3.Text = "Edit";
            this.edit3.UseVisualStyleBackColor = true;
            this.edit3.Click += new System.EventHandler(this.edit3_Click);
            // 
            // ok3
            // 
            this.ok3.Location = new System.Drawing.Point(506, 8);
            this.ok3.Name = "ok3";
            this.ok3.Size = new System.Drawing.Size(104, 41);
            this.ok3.TabIndex = 4;
            this.ok3.Text = "Ok";
            this.ok3.UseVisualStyleBackColor = true;
            this.ok3.Visible = false;
            this.ok3.Click += new System.EventHandler(this.ok3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(47, 13);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(450, 30);
            this.textBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "3.";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.delete4);
            this.panel4.Controls.Add(this.done4);
            this.panel4.Controls.Add(this.edit4);
            this.panel4.Controls.Add(this.ok4);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(17, 413);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(938, 56);
            this.panel4.TabIndex = 9;
            this.panel4.Visible = false;
            // 
            // delete4
            // 
            this.delete4.Location = new System.Drawing.Point(827, 7);
            this.delete4.Name = "delete4";
            this.delete4.Size = new System.Drawing.Size(102, 42);
            this.delete4.TabIndex = 7;
            this.delete4.Text = "Delete";
            this.delete4.UseVisualStyleBackColor = true;
            this.delete4.Click += new System.EventHandler(this.delete4_Click);
            // 
            // done4
            // 
            this.done4.Location = new System.Drawing.Point(724, 7);
            this.done4.Name = "done4";
            this.done4.Size = new System.Drawing.Size(97, 42);
            this.done4.TabIndex = 6;
            this.done4.Text = "Done";
            this.done4.UseVisualStyleBackColor = true;
            this.done4.Click += new System.EventHandler(this.done4_Click);
            // 
            // edit4
            // 
            this.edit4.Location = new System.Drawing.Point(616, 7);
            this.edit4.Name = "edit4";
            this.edit4.Size = new System.Drawing.Size(102, 42);
            this.edit4.TabIndex = 5;
            this.edit4.Text = "Edit";
            this.edit4.UseVisualStyleBackColor = true;
            this.edit4.Click += new System.EventHandler(this.edit4_Click);
            // 
            // ok4
            // 
            this.ok4.Location = new System.Drawing.Point(506, 8);
            this.ok4.Name = "ok4";
            this.ok4.Size = new System.Drawing.Size(104, 41);
            this.ok4.TabIndex = 4;
            this.ok4.Text = "Ok";
            this.ok4.UseVisualStyleBackColor = true;
            this.ok4.Visible = false;
            this.ok4.Click += new System.EventHandler(this.ok4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(47, 13);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(450, 30);
            this.textBox4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "4.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.delete5);
            this.panel5.Controls.Add(this.done5);
            this.panel5.Controls.Add(this.edit5);
            this.panel5.Controls.Add(this.ok5);
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(17, 484);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(938, 56);
            this.panel5.TabIndex = 8;
            this.panel5.Visible = false;
            // 
            // delete5
            // 
            this.delete5.Location = new System.Drawing.Point(827, 7);
            this.delete5.Name = "delete5";
            this.delete5.Size = new System.Drawing.Size(102, 42);
            this.delete5.TabIndex = 7;
            this.delete5.Text = "Delete";
            this.delete5.UseVisualStyleBackColor = true;
            this.delete5.Click += new System.EventHandler(this.delete5_Click);
            // 
            // done5
            // 
            this.done5.Location = new System.Drawing.Point(724, 7);
            this.done5.Name = "done5";
            this.done5.Size = new System.Drawing.Size(97, 42);
            this.done5.TabIndex = 6;
            this.done5.Text = "Done";
            this.done5.UseVisualStyleBackColor = true;
            this.done5.Click += new System.EventHandler(this.done5_Click);
            // 
            // edit5
            // 
            this.edit5.Location = new System.Drawing.Point(616, 7);
            this.edit5.Name = "edit5";
            this.edit5.Size = new System.Drawing.Size(102, 42);
            this.edit5.TabIndex = 5;
            this.edit5.Text = "Edit";
            this.edit5.UseVisualStyleBackColor = true;
            this.edit5.Click += new System.EventHandler(this.edit5_Click);
            // 
            // ok5
            // 
            this.ok5.Location = new System.Drawing.Point(506, 8);
            this.ok5.Name = "ok5";
            this.ok5.Size = new System.Drawing.Size(104, 41);
            this.ok5.TabIndex = 4;
            this.ok5.Text = "Ok";
            this.ok5.UseVisualStyleBackColor = true;
            this.ok5.Visible = false;
            this.ok5.Click += new System.EventHandler(this.ok5_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(47, 13);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(450, 30);
            this.textBox5.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "5.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 556);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel0);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel0.ResumeLayout(false);
            this.panel0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textNewTask;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button done1;
        private System.Windows.Forms.Button edit1;
        private System.Windows.Forms.Button ok1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button done2;
        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.Button ok2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button delete3;
        private System.Windows.Forms.Button done3;
        private System.Windows.Forms.Button edit3;
        private System.Windows.Forms.Button ok3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button delete4;
        private System.Windows.Forms.Button done4;
        private System.Windows.Forms.Button edit4;
        private System.Windows.Forms.Button ok4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button delete5;
        private System.Windows.Forms.Button done5;
        private System.Windows.Forms.Button edit5;
        private System.Windows.Forms.Button ok5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
    }
}

