namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BT_Princ = new System.Windows.Forms.Button();
            this.IRBox = new System.Windows.Forms.RichTextBox();
            this.PCBox = new System.Windows.Forms.RichTextBox();
            this.MDRBox = new System.Windows.Forms.RichTextBox();
            this.MARBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.ACBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(428, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 455);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BT_Princ
            // 
            this.BT_Princ.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Princ.Location = new System.Drawing.Point(450, 545);
            this.BT_Princ.Name = "BT_Princ";
            this.BT_Princ.Size = new System.Drawing.Size(316, 40);
            this.BT_Princ.TabIndex = 4;
            this.BT_Princ.Text = "Enter";
            this.BT_Princ.UseVisualStyleBackColor = true;
            this.BT_Princ.Click += new System.EventHandler(this.button1_Click);
            // 
            // IRBox
            // 
            this.IRBox.Location = new System.Drawing.Point(788, 83);
            this.IRBox.Name = "IRBox";
            this.IRBox.Size = new System.Drawing.Size(65, 31);
            this.IRBox.TabIndex = 2;
            this.IRBox.Text = "";
            this.IRBox.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // PCBox
            // 
            this.PCBox.Location = new System.Drawing.Point(788, 133);
            this.PCBox.Name = "PCBox";
            this.PCBox.Size = new System.Drawing.Size(65, 31);
            this.PCBox.TabIndex = 2;
            this.PCBox.Text = "";
            this.PCBox.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // MDRBox
            // 
            this.MDRBox.Location = new System.Drawing.Point(788, 183);
            this.MDRBox.Name = "MDRBox";
            this.MDRBox.Size = new System.Drawing.Size(65, 31);
            this.MDRBox.TabIndex = 2;
            this.MDRBox.Text = "";
            this.MDRBox.TextChanged += new System.EventHandler(this.richTextBox5_TextChanged);
            // 
            // MARBox
            // 
            this.MARBox.Location = new System.Drawing.Point(788, 233);
            this.MARBox.Name = "MARBox";
            this.MARBox.Size = new System.Drawing.Size(65, 31);
            this.MARBox.TabIndex = 2;
            this.MARBox.Text = "";
            this.MARBox.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(808, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "IR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(808, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "PC";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "MDR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "MAR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(57, 67);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.richTextBox2.Size = new System.Drawing.Size(269, 400);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(805, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "AC";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ACBox
            // 
            this.ACBox.Location = new System.Drawing.Point(788, 285);
            this.ACBox.Name = "ACBox";
            this.ACBox.Size = new System.Drawing.Size(65, 31);
            this.ACBox.TabIndex = 16;
            this.ACBox.Text = "";
            this.ACBox.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 641);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ACBox);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MARBox);
            this.Controls.Add(this.MDRBox);
            this.Controls.Add(this.PCBox);
            this.Controls.Add(this.IRBox);
            this.Controls.Add(this.BT_Princ);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BT_Princ;
        private System.Windows.Forms.RichTextBox IRBox;
        private System.Windows.Forms.RichTextBox PCBox;
        private System.Windows.Forms.RichTextBox MDRBox;
        private System.Windows.Forms.RichTextBox MARBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ACBox;
    }
}

