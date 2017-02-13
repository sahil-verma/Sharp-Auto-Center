namespace Assignment2
{
    partial class SharpAutoForm
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
            this.basePriceTextBox = new System.Windows.Forms.TextBox();
            this.additionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.tradeInAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.additionalItems = new System.Windows.Forms.GroupBox();
            this.computerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.stereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.exteriorFinish = new System.Windows.Forms.GroupBox();
            this.customizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.pearlizedRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.additionalItems.SuspendLayout();
            this.exteriorFinish.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            // basePriceTextBox
            // 
            this.basePriceTextBox.Location = new System.Drawing.Point(149, 29);
            this.basePriceTextBox.Name = "basePriceTextBox";
            this.basePriceTextBox.Size = new System.Drawing.Size(94, 20);
            this.basePriceTextBox.TabIndex = 7;
            this.basePriceTextBox.TextChanged += new System.EventHandler(this._textFields);
            // 
            // additionalOptionsTextBox
            // 
            this.additionalOptionsTextBox.Location = new System.Drawing.Point(149, 65);
            this.additionalOptionsTextBox.Name = "additionalOptionsTextBox";
            this.additionalOptionsTextBox.ReadOnly = true;
            this.additionalOptionsTextBox.Size = new System.Drawing.Size(94, 20);
            this.additionalOptionsTextBox.TabIndex = 8;
            this.additionalOptionsTextBox.Click += new System.EventHandler(this._textFields);
            this.additionalOptionsTextBox.TextChanged += new System.EventHandler(this.additionalOptions_TextChanged);
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(149, 100);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(94, 20);
            this.subTotalTextBox.TabIndex = 9;
            this.subTotalTextBox.Click += new System.EventHandler(this._textFields);
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(149, 135);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(94, 20);
            this.salesTaxTextBox.TabIndex = 10;
            this.salesTaxTextBox.Click += new System.EventHandler(this._textFields);
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(149, 173);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(94, 20);
            this.totalTextBox.TabIndex = 11;
            this.totalTextBox.Click += new System.EventHandler(this._textFields);
            // 
            // tradeInAllowanceTextBox
            // 
            this.tradeInAllowanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeInAllowanceTextBox.Location = new System.Drawing.Point(149, 212);
            this.tradeInAllowanceTextBox.Name = "tradeInAllowanceTextBox";
            this.tradeInAllowanceTextBox.Size = new System.Drawing.Size(94, 22);
            this.tradeInAllowanceTextBox.TabIndex = 12;
            this.tradeInAllowanceTextBox.Text = "0";
            this.tradeInAllowanceTextBox.Click += new System.EventHandler(this._textFields);
            this.tradeInAllowanceTextBox.TextChanged += new System.EventHandler(this._textFields);
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.Location = new System.Drawing.Point(148, 249);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.ReadOnly = true;
            this.amountDueTextBox.Size = new System.Drawing.Size(94, 20);
            this.amountDueTextBox.TabIndex = 13;
            this.amountDueTextBox.Click += new System.EventHandler(this._textFields);
            // 
            // additionalItems
            // 
            this.additionalItems.Controls.Add(this.computerNavigationCheckBox);
            this.additionalItems.Controls.Add(this.leatherInteriorCheckBox);
            this.additionalItems.Controls.Add(this.stereoSystemCheckBox);
            this.additionalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalItems.Location = new System.Drawing.Point(269, 36);
            this.additionalItems.Name = "additionalItems";
            this.additionalItems.Size = new System.Drawing.Size(169, 131);
            this.additionalItems.TabIndex = 14;
            this.additionalItems.TabStop = false;
            this.additionalItems.Text = "Additional Items";
            // 
            // computerNavigationCheckBox
            // 
            this.computerNavigationCheckBox.AutoSize = true;
            this.computerNavigationCheckBox.Location = new System.Drawing.Point(15, 105);
            this.computerNavigationCheckBox.Name = "computerNavigationCheckBox";
            this.computerNavigationCheckBox.Size = new System.Drawing.Size(153, 20);
            this.computerNavigationCheckBox.TabIndex = 2;
            this.computerNavigationCheckBox.Text = "Computer Navigation";
            this.computerNavigationCheckBox.UseVisualStyleBackColor = true;
            this.computerNavigationCheckBox.CheckedChanged += new System.EventHandler(this._checkBox);
            // 
            // leatherInteriorCheckBox
            // 
            this.leatherInteriorCheckBox.AutoSize = true;
            this.leatherInteriorCheckBox.Location = new System.Drawing.Point(15, 67);
            this.leatherInteriorCheckBox.Name = "leatherInteriorCheckBox";
            this.leatherInteriorCheckBox.Size = new System.Drawing.Size(115, 20);
            this.leatherInteriorCheckBox.TabIndex = 1;
            this.leatherInteriorCheckBox.Text = "Leather Interior";
            this.leatherInteriorCheckBox.UseVisualStyleBackColor = true;
            this.leatherInteriorCheckBox.CheckedChanged += new System.EventHandler(this._checkBox);
            // 
            // stereoSystemCheckBox
            // 
            this.stereoSystemCheckBox.AutoSize = true;
            this.stereoSystemCheckBox.Location = new System.Drawing.Point(15, 29);
            this.stereoSystemCheckBox.Name = "stereoSystemCheckBox";
            this.stereoSystemCheckBox.Size = new System.Drawing.Size(115, 20);
            this.stereoSystemCheckBox.TabIndex = 0;
            this.stereoSystemCheckBox.Text = "Stereo System";
            this.stereoSystemCheckBox.UseVisualStyleBackColor = true;
            this.stereoSystemCheckBox.CheckedChanged += new System.EventHandler(this._checkBox);
            // 
            // exteriorFinish
            // 
            this.exteriorFinish.Controls.Add(this.customizedDetailingRadioButton);
            this.exteriorFinish.Controls.Add(this.pearlizedRadioButton);
            this.exteriorFinish.Controls.Add(this.standardRadioButton);
            this.exteriorFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exteriorFinish.Location = new System.Drawing.Point(269, 196);
            this.exteriorFinish.Name = "exteriorFinish";
            this.exteriorFinish.Size = new System.Drawing.Size(169, 133);
            this.exteriorFinish.TabIndex = 15;
            this.exteriorFinish.TabStop = false;
            this.exteriorFinish.Text = "Exterior Finish";
            // 
            // customizedDetailingRadioButton
            // 
            this.customizedDetailingRadioButton.AutoSize = true;
            this.customizedDetailingRadioButton.Location = new System.Drawing.Point(15, 106);
            this.customizedDetailingRadioButton.Name = "customizedDetailingRadioButton";
            this.customizedDetailingRadioButton.Size = new System.Drawing.Size(152, 20);
            this.customizedDetailingRadioButton.TabIndex = 2;
            this.customizedDetailingRadioButton.Text = "Customized Detailing";
            this.customizedDetailingRadioButton.UseVisualStyleBackColor = true;
            this.customizedDetailingRadioButton.CheckedChanged += new System.EventHandler(this._radioButton);
            // 
            // pearlizedRadioButton
            // 
            this.pearlizedRadioButton.AutoSize = true;
            this.pearlizedRadioButton.Location = new System.Drawing.Point(15, 70);
            this.pearlizedRadioButton.Name = "pearlizedRadioButton";
            this.pearlizedRadioButton.Size = new System.Drawing.Size(83, 20);
            this.pearlizedRadioButton.TabIndex = 1;
            this.pearlizedRadioButton.Text = "Pearlized";
            this.pearlizedRadioButton.UseVisualStyleBackColor = true;
            this.pearlizedRadioButton.CheckedChanged += new System.EventHandler(this._radioButton);
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Checked = true;
            this.standardRadioButton.Location = new System.Drawing.Point(15, 32);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(81, 20);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "Standard";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            this.standardRadioButton.CheckedChanged += new System.EventHandler(this._radioButton);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(12, 346);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(82, 30);
            this.calculateButton.TabIndex = 16;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this._buttonClick);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(200, 345);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(52, 30);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this._buttonClick);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(378, 346);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(57, 29);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this._buttonClick);
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
            // SharpAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 384);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exteriorFinish);
            this.Controls.Add(this.additionalItems);
            this.Controls.Add(this.amountDueTextBox);
            this.Controls.Add(this.tradeInAllowanceTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(this.additionalOptionsTextBox);
            this.Controls.Add(this.basePriceTextBox);
            this.Controls.Add(this.Due);
            this.Controls.Add(this.Trade);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.Tax);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.additionalOp);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SharpAutoForm";
            this.ShowIcon = false;
            this.Text = "Sharp Auto Center";
            this.Load += new System.EventHandler(this.SharpAutoCenter_Load);
            this.additionalItems.ResumeLayout(false);
            this.additionalItems.PerformLayout();
            this.exteriorFinish.ResumeLayout(false);
            this.exteriorFinish.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.TextBox basePriceTextBox;
        private System.Windows.Forms.TextBox additionalOptionsTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox tradeInAllowanceTextBox;
        private System.Windows.Forms.TextBox amountDueTextBox;
        private System.Windows.Forms.GroupBox additionalItems;
        private System.Windows.Forms.CheckBox computerNavigationCheckBox;
        private System.Windows.Forms.CheckBox leatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox stereoSystemCheckBox;
        private System.Windows.Forms.GroupBox exteriorFinish;
        private System.Windows.Forms.RadioButton customizedDetailingRadioButton;
        private System.Windows.Forms.RadioButton pearlizedRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
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

