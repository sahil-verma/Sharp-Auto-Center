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
            this.components = new System.ComponentModel.Container();
            this.Price = new System.Windows.Forms.Label();
            this.additionalOp = new System.Windows.Forms.Label();
            this.totalPrice = new System.Windows.Forms.Label();
            this.Tax = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.Trade = new System.Windows.Forms.Label();
            this.Due = new System.Windows.Forms.Label();
            this.basePrice = new System.Windows.Forms.TextBox();
            this.additionalOptions = new System.Windows.Forms.TextBox();
            this.subTotal = new System.Windows.Forms.TextBox();
            this.salesTax = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.tradeInAllowance = new System.Windows.Forms.TextBox();
            this.amountDue = new System.Windows.Forms.TextBox();
            this.additionalItems = new System.Windows.Forms.GroupBox();
            this.computerNavigation = new System.Windows.Forms.CheckBox();
            this.leatherInterior = new System.Windows.Forms.CheckBox();
            this.stereoSystem = new System.Windows.Forms.CheckBox();
            this.exteriorFinish = new System.Windows.Forms.GroupBox();
            this.customizedDetailing = new System.Windows.Forms.RadioButton();
            this.pearlized = new System.Windows.Forms.RadioButton();
            this.standard = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoCenterFontDialog = new System.Windows.Forms.FontDialog();
            this.autoCenterColorDialog = new System.Windows.Forms.ColorDialog();
            this.additionalItems.SuspendLayout();
            this.exteriorFinish.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Price
            // 
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(4, 29);
            this.Price.Name = "Price";
            this.Price.Padding = new System.Windows.Forms.Padding(1);
            this.Price.Size = new System.Drawing.Size(137, 23);
            this.Price.TabIndex = 0;
            this.Price.Text = "Base Price :";
            this.Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Price.Click += new System.EventHandler(this.label1_Click);
            // 
            // additionalOp
            // 
            this.additionalOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalOp.Location = new System.Drawing.Point(4, 65);
            this.additionalOp.Name = "additionalOp";
            this.additionalOp.Padding = new System.Windows.Forms.Padding(1);
            this.additionalOp.Size = new System.Drawing.Size(137, 23);
            this.additionalOp.TabIndex = 1;
            this.additionalOp.Text = "Additional Options :";
            this.additionalOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.additionalOp.Click += new System.EventHandler(this.label2_Click);
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
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(5, 174);
            this.sum.Name = "sum";
            this.sum.Padding = new System.Windows.Forms.Padding(1);
            this.sum.Size = new System.Drawing.Size(137, 23);
            this.sum.TabIndex = 4;
            this.sum.Text = "Total : ";
            this.sum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // Due
            // 
            this.Due.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Due.Location = new System.Drawing.Point(4, 249);
            this.Due.Name = "Due";
            this.Due.Padding = new System.Windows.Forms.Padding(1);
            this.Due.Size = new System.Drawing.Size(137, 23);
            this.Due.TabIndex = 6;
            this.Due.Text = "Amount Due :";
            this.Due.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // basePrice
            // 
            this.basePrice.Location = new System.Drawing.Point(149, 29);
            this.basePrice.Name = "basePrice";
            this.basePrice.Size = new System.Drawing.Size(94, 20);
            this.basePrice.TabIndex = 7;
            this.basePrice.TextChanged += new System.EventHandler(this._textFields);
            // 
            // additionalOptions
            // 
            this.additionalOptions.Location = new System.Drawing.Point(149, 65);
            this.additionalOptions.Name = "additionalOptions";
            this.additionalOptions.ReadOnly = true;
            this.additionalOptions.Size = new System.Drawing.Size(94, 20);
            this.additionalOptions.TabIndex = 8;
            this.additionalOptions.Click += new System.EventHandler(this._textFields);
            this.additionalOptions.TextChanged += new System.EventHandler(this.additionalOptions_TextChanged);
            // 
            // subTotal
            // 
            this.subTotal.Location = new System.Drawing.Point(149, 100);
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Size = new System.Drawing.Size(94, 20);
            this.subTotal.TabIndex = 9;
            this.subTotal.Click += new System.EventHandler(this._textFields);
            // 
            // salesTax
            // 
            this.salesTax.Location = new System.Drawing.Point(149, 135);
            this.salesTax.Name = "salesTax";
            this.salesTax.ReadOnly = true;
            this.salesTax.Size = new System.Drawing.Size(94, 20);
            this.salesTax.TabIndex = 10;
            this.salesTax.Click += new System.EventHandler(this._textFields);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(149, 173);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(94, 20);
            this.total.TabIndex = 11;
            this.total.Click += new System.EventHandler(this._textFields);
            // 
            // tradeInAllowance
            // 
            this.tradeInAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeInAllowance.Location = new System.Drawing.Point(149, 212);
            this.tradeInAllowance.Name = "tradeInAllowance";
            this.tradeInAllowance.Size = new System.Drawing.Size(94, 22);
            this.tradeInAllowance.TabIndex = 12;
            this.tradeInAllowance.Text = "0";
            this.tradeInAllowance.Click += new System.EventHandler(this._textFields);
            this.tradeInAllowance.TextChanged += new System.EventHandler(this._textFields);
            // 
            // amountDue
            // 
            this.amountDue.Location = new System.Drawing.Point(148, 249);
            this.amountDue.Name = "amountDue";
            this.amountDue.ReadOnly = true;
            this.amountDue.Size = new System.Drawing.Size(94, 20);
            this.amountDue.TabIndex = 13;
            this.amountDue.Click += new System.EventHandler(this._textFields);
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
            // computerNavigation
            // 
            this.computerNavigation.AutoSize = true;
            this.computerNavigation.Location = new System.Drawing.Point(15, 105);
            this.computerNavigation.Name = "computerNavigation";
            this.computerNavigation.Size = new System.Drawing.Size(153, 20);
            this.computerNavigation.TabIndex = 2;
            this.computerNavigation.Text = "Computer Navigation";
            this.computerNavigation.UseVisualStyleBackColor = true;
            this.computerNavigation.CheckedChanged += new System.EventHandler(this._checkBox);
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
            this.leatherInterior.CheckedChanged += new System.EventHandler(this._checkBox);
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
            this.stereoSystem.CheckedChanged += new System.EventHandler(this._checkBox);
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
            // customizedDetailing
            // 
            this.customizedDetailing.AutoSize = true;
            this.customizedDetailing.Location = new System.Drawing.Point(15, 106);
            this.customizedDetailing.Name = "customizedDetailing";
            this.customizedDetailing.Size = new System.Drawing.Size(152, 20);
            this.customizedDetailing.TabIndex = 2;
            this.customizedDetailing.Text = "Customized Detailing";
            this.customizedDetailing.UseVisualStyleBackColor = true;
            this.customizedDetailing.CheckedChanged += new System.EventHandler(this._radioButton);
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
            this.pearlized.CheckedChanged += new System.EventHandler(this._radioButton);
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
            this.standard.CheckedChanged += new System.EventHandler(this._radioButton);
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
            this.calculate.Click += new System.EventHandler(this._buttonClick);
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
            this.clear.Click += new System.EventHandler(this._buttonClick);
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
            this.exit.Click += new System.EventHandler(this._buttonClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.calculateToolStripMenuItem.Text = "&Calculate ";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.fontToolStripMenuItem.Text = "&Font ...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.colorToolStripMenuItem.Text = "C&olor ...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // autoCenterFontDialog
            // 
            this.autoCenterFontDialog.MaxSize = 14;
            this.autoCenterFontDialog.MinSize = 8;
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
            this.Controls.Add(this.amountDue);
            this.Controls.Add(this.tradeInAllowance);
            this.Controls.Add(this.total);
            this.Controls.Add(this.salesTax);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.additionalOptions);
            this.Controls.Add(this.basePrice);
            this.Controls.Add(this.Due);
            this.Controls.Add(this.Trade);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.additionalOp);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SharpAutoCenter";
            this.ShowIcon = false;
            this.Text = "Sharp Auto Center";
            this.Load += new System.EventHandler(this.SharpAutoCenter_Load);
            this.additionalItems.ResumeLayout(false);
            this.additionalItems.PerformLayout();
            this.exteriorFinish.ResumeLayout(false);
            this.exteriorFinish.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label additionalOp;
        private System.Windows.Forms.Label totalPrice;
        private System.Windows.Forms.Label Tax;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label Trade;
        private System.Windows.Forms.Label Due;
        private System.Windows.Forms.TextBox basePrice;
        private System.Windows.Forms.TextBox additionalOptions;
        private System.Windows.Forms.TextBox subTotal;
        private System.Windows.Forms.TextBox salesTax;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox tradeInAllowance;
        private System.Windows.Forms.TextBox amountDue;
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
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.FontDialog autoCenterFontDialog;
        private System.Windows.Forms.ColorDialog autoCenterColorDialog;
    }
}

