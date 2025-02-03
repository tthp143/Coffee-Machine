namespace Coffee_Machine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            ChocStock = new TextBox();
            label1 = new Label();
            MilkStock = new TextBox();
            label4 = new Label();
            CFStock = new TextBox();
            WaterStock = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            Mocca_B = new Button();
            BlackCF_B = new Button();
            Latte_B = new Button();
            HotChoc_B = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 104);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 5;
            label3.Text = "milk";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 64);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 4;
            label2.Text = "Chocolate";
            label2.Click += label2_Click;
            // 
            // ChocStock
            // 
            ChocStock.Location = new Point(115, 64);
            ChocStock.Name = "ChocStock";
            ChocStock.ReadOnly = true;
            ChocStock.Size = new Size(125, 27);
            ChocStock.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Coffee";
            // 
            // MilkStock
            // 
            MilkStock.Location = new Point(115, 101);
            MilkStock.Name = "MilkStock";
            MilkStock.ReadOnly = true;
            MilkStock.Size = new Size(125, 27);
            MilkStock.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 141);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 9;
            label4.Text = "Water";
            // 
            // CFStock
            // 
            CFStock.Location = new Point(115, 26);
            CFStock.Name = "CFStock";
            CFStock.ReadOnly = true;
            CFStock.Size = new Size(125, 27);
            CFStock.TabIndex = 6;
            // 
            // WaterStock
            // 
            WaterStock.Location = new Point(115, 141);
            WaterStock.Name = "WaterStock";
            WaterStock.ReadOnly = true;
            WaterStock.Size = new Size(125, 27);
            WaterStock.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(WaterStock);
            groupBox1.Controls.Add(CFStock);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(ChocStock);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(MilkStock);
            groupBox1.Location = new Point(34, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 197);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stock";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(92, 245);
            button1.Name = "button1";
            button1.Size = new Size(155, 57);
            button1.TabIndex = 16;
            button1.Text = "Stock UP +1000";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Mocca_B
            // 
            Mocca_B.Location = new Point(688, 178);
            Mocca_B.Name = "Mocca_B";
            Mocca_B.Size = new Size(119, 43);
            Mocca_B.TabIndex = 17;
            Mocca_B.Text = "Mocca";
            Mocca_B.UseVisualStyleBackColor = true;
            Mocca_B.Click += Mocca_B_Click;
            // 
            // BlackCF_B
            // 
            BlackCF_B.Location = new Point(517, 178);
            BlackCF_B.Name = "BlackCF_B";
            BlackCF_B.Size = new Size(119, 43);
            BlackCF_B.TabIndex = 18;
            BlackCF_B.Text = "BlackCoffee";
            BlackCF_B.UseVisualStyleBackColor = true;
            BlackCF_B.Click += BlackCF_B_Click;
            // 
            // Latte_B
            // 
            Latte_B.Location = new Point(517, 408);
            Latte_B.Name = "Latte_B";
            Latte_B.Size = new Size(119, 43);
            Latte_B.TabIndex = 19;
            Latte_B.Text = "Latte";
            Latte_B.UseVisualStyleBackColor = true;
            Latte_B.Click += Latte_B_Click;
            // 
            // HotChoc_B
            // 
            HotChoc_B.Location = new Point(688, 411);
            HotChoc_B.Name = "HotChoc_B";
            HotChoc_B.Size = new Size(119, 43);
            HotChoc_B.TabIndex = 20;
            HotChoc_B.Text = "Hot Chocolate";
            HotChoc_B.UseVisualStyleBackColor = true;
            HotChoc_B.Click += HotChoc_B_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Latte;
            pictureBox1.Location = new Point(493, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Hot_Chocolate;
            pictureBox2.Location = new Point(673, 258);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(159, 144);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Mocca;
            pictureBox3.Location = new Point(673, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(159, 144);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Blackcoffe;
            pictureBox4.Location = new Point(493, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(159, 144);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 478);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(HotChoc_B);
            Controls.Add(Latte_B);
            Controls.Add(BlackCF_B);
            Controls.Add(Mocca_B);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label2;
        private TextBox ChocStock;
        private Label label1;
        private TextBox MilkStock;
        private Label label4;
        private TextBox CFStock;
        private TextBox WaterStock;
        private GroupBox groupBox1;
        private Button button1;
        private Button Mocca_B;
        private Button BlackCF_B;
        private Button Latte_B;
        private Button HotChoc_B;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
