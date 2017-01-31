namespace Assignment2
{
    partial class SharpAutoCenter
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
            this.Price = new System.Windows.Forms.Label();
            this.additionalOptions = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.Trade = new System.Windows.Forms.Label();
            this.amountDue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.additionalItems = new System.Windows.Forms.GroupBox();
            this.exteriorFinish = new System.Windows.Forms.GroupBox();
            this.stereoSystem = new System.Windows.Forms.CheckBox();
            this.leatherInterior = new System.Windows.Forms.CheckBox();
            this.computerNavigation = new System.Windows.Forms.CheckBox();
            this.standard = new System.Windows.Forms.RadioButton();
            this.pearlized = new System.Windows.Forms.RadioButton();
            this.customizedDetailing = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.additionalItems.SuspendLayout();
            this.exteriorFinish.SuspendLayout();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(4, 26);
            this.Price.Name = "Price";
            this.Price.Padding = new System.Windows.Forms.Padding(1);
            this.Price.Size = new System.Drawing.Size(137, 23);
            this.Price.TabIndex = 0;
            this.Price.Text = "Base Price :";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Price.Click += new System.EventHandler(this.label1_Click);
            // 
            // additionalOptions
            // 
            this.additionalOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalOptions.Location = new System.Drawing.Point(4, 62);
            this.additionalOptions.Name = "additionalOptions";
            this.additionalOptions.Padding = new System.Windows.Forms.Padding(1);
            this.additionalOptions.Size = new System.Drawing.Size(137, 23);
            this.additionalOptions.TabIndex = 1;
            this.additionalOptions.Text = "Additional Options :";
            this.additionalOptions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.additionalOptions.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(5, 100);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Padding = new System.Windows.Forms.Padding(1);
            this.totalPrice.Size = new System.Drawing.Size(137, 23);
            this.totalPrice.TabIndex = 2;
            this.totalPrice.Text = "SubTotal : ";
            this.totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // Tax
            // 
            this.Tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tax.Location = new System.Drawing.Point(5, 135);
            this.Tax.Name = "Tax";
            this.Tax.Padding = new System.Windows.Forms.Padding(1);
            this.Tax.Size = new System.Drawing.Size(137, 23);
            this.Tax.TabIndex = 3;
            this.Tax.Text = "Sales Tax (13%) :";
            this.Tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(5, 174);
            this.total.Name = "total";
            this.total.Padding = new System.Windows.Forms.Padding(1);
            this.total.Size = new System.Drawing.Size(137, 23);
            this.total.TabIndex = 4;
            this.total.Text = "Total : ";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Trade
            // 
            this.Trade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trade.Location = new System.Drawing.Point(5, 212);
            this.Trade.Name = "Trade";
            this.Trade.Padding = new System.Windows.Forms.Padding(1);
            this.Trade.Size = new System.Drawing.Size(137, 23);
            this.Trade.TabIndex = 5;
            this.Trade.Text = "Trade-in Allowance : ";
            this.Trade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Trade.Click += new System.EventHandler(this.label6_Click);
            // 
            // amountDue
            // 
            this.amountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDue.Location = new System.Drawing.Point(4, 249);
            this.amountDue.Name = "amountDue";
            this.amountDue.Padding = new System.Windows.Forms.Padding(1);
            this.amountDue.Size = new System.Drawing.Size(137, 23);
            this.amountDue.TabIndex = 6;
            this.amountDue.Text = "Amount Due :";
            this.amountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(149, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(149, 174);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(94, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(149, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(94, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(148, 249);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(94, 20);
            this.textBox7.TabIndex = 13;
            // 
            // additionalItems
            // 
            this.additionalItems.Controls.Add(this.computerNavigation);
            this.additionalItems.Controls.Add(this.leatherInterior);
            this.additionalItems.Controls.Add(this.stereoSystem);
            this.additionalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalItems.Location = new System.Drawing.Point(269, 36);
            this.additionalItems.Name = "additionalItems";
            this.additionalItems.Size = new System.Drawing.Size(169, 131);
            this.additionalItems.TabIndex = 14;
            this.additionalItems.TabStop = false;
            this.additionalItems.Text = "Additional Items";
            // 
            // exteriorFinish
            // 
            this.exteriorFinish.Controls.Add(this.customizedDetailing);
            this.exteriorFinish.Controls.Add(this.pearlized);
            this.exteriorFinish.Controls.Add(this.standard);
            this.exteriorFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exteriorFinish.Location = new System.Drawing.Point(269, 196);
            this.exteriorFinish.Name = "exteriorFinish";
            this.exteriorFinish.Size = new System.Drawing.Size(169, 133);
            this.exteriorFinish.TabIndex = 15;
            this.exteriorFinish.TabStop = false;
            this.exteriorFinish.Text = "Exterior Finish";
            // 
            // stereoSystem
            // 
            this.stereoSystem.AutoSize = true;
            this.stereoSystem.Location = new System.Drawing.Point(15, 29);
            this.stereoSystem.Name = "stereoSystem";
            this.stereoSystem.Size = new System.Drawing.Size(115, 20);
            this.stereoSystem.TabIndex = 0;
            this.stereoSystem.Text = "Stereo System";
            this.stereoSystem.UseVisualStyleBackColor = true;
            this.stereoSystem.CheckedChanged += new System.EventHandler(this.stereoSystem_CheckedChanged);
            // 
            // leatherInterior
            // 
            this.leatherInterior.AutoSize = true;
            this.leatherInterior.Location = new System.Drawing.Point(15, 67);
            this.leatherInterior.Name = "leatherInterior";
            this.leatherInterior.Size = new System.Drawing.Size(115, 20);
            this.leatherInterior.TabIndex = 1;
            this.leatherInterior.Text = "Leather Interior";
            this.leatherInterior.UseVisualStyleBackColor = true;
            this.leatherInterior.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // computerNavigation
            // 
            this.computerNavigation.AutoSize = true;
            this.computerNavigation.Location = new System.Drawing.Point(15, 105);
            this.computerNavigation.Name = "computerNavigation";
            this.computerNavigation.Size = new System.Drawing.Size(153, 20);
            this.computerNavigation.TabIndex = 2;
            this.computerNavigation.Text = "Computer Navigation";
            this.computerNavigation.UseVisualStyleBackColor = true;
            this.computerNavigation.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Checked = true;
            this.standard.Location = new System.Drawing.Point(15, 32);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(81, 20);
            this.standard.TabIndex = 0;
            this.standard.TabStop = true;
            this.standard.Text = "Standard";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // pearlized
            // 
            this.pearlized.AutoSize = true;
            this.pearlized.Location = new System.Drawing.Point(15, 70);
            this.pearlized.Name = "pearlized";
            this.pearlized.Size = new System.Drawing.Size(83, 20);
            this.pearlized.TabIndex = 1;
            this.pearlized.Text = "Pearlized";
            this.pearlized.UseVisualStyleBackColor = true;
            // 
            // customizedDetailing
            // 
            this.customizedDetailing.AutoSize = true;
            this.customizedDetailing.Location = new System.Drawing.Point(15, 106);
            this.customizedDetailing.Name = "customizedDetailing";
            this.customizedDetailing.Size = new System.Drawing.Size(152, 20);
            this.customizedDetailing.TabIndex = 2;
            this.customizedDetailing.Text = "Customized Detailing";
            this.customizedDetailing.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(12, 346);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(82, 30);
            this.calculate.TabIndex = 16;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(200, 345);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(52, 30);
            this.clear.TabIndex = 17;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(378, 346);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(57, 29);
            this.exit.TabIndex = 18;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // SharpAutoCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 384);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.exteriorFinish);
            this.Controls.Add(this.additionalItems);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.amountDue);
            this.Controls.Add(this.Trade);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.additionalOptions);
            this.Controls.Add(this.Price);
            this.Name = "SharpAutoCenter";
            this.ShowIcon = false;
            this.Text = "Sharp Auto Center";
            this.Load += new System.EventHandler(this.SharpAutoCenter_Load);
            this.additionalItems.ResumeLayout(false);
            this.additionalItems.PerformLayout();
            this.exteriorFinish.ResumeLayout(false);
            this.exteriorFinish.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label additionalOptions;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label Trade;
        private System.Windows.Forms.Label amountDue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.GroupBox additionalItems;
        private System.Windows.Forms.CheckBox computerNavigation;
        private System.Windows.Forms.CheckBox leatherInterior;
        private System.Windows.Forms.CheckBox stereoSystem;
        private System.Windows.Forms.GroupBox exteriorFinish;
        private System.Windows.Forms.RadioButton customizedDetailing;
        private System.Windows.Forms.RadioButton pearlized;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
    }
}

