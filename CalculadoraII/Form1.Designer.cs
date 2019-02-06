namespace CalculadoraII
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.display = new System.Windows.Forms.TextBox();
            this.btn_changeSymbol = new System.Windows.Forms.Button();
            this.btn_deleteDigit = new System.Windows.Forms.Button();
            this.btn_clearDisplay = new System.Windows.Forms.Button();
            this.btn_equals = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_substract = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn_decimal = new System.Windows.Forms.Button();
            this.btn_number0 = new System.Windows.Forms.Button();
            this.btn_number9 = new System.Windows.Forms.Button();
            this.btn_number8 = new System.Windows.Forms.Button();
            this.btn_number7 = new System.Windows.Forms.Button();
            this.btn_number6 = new System.Windows.Forms.Button();
            this.btn_number5 = new System.Windows.Forms.Button();
            this.btn_number4 = new System.Windows.Forms.Button();
            this.btn_number3 = new System.Windows.Forms.Button();
            this.btn_number2 = new System.Windows.Forms.Button();
            this.btn_number1 = new System.Windows.Forms.Button();
            this.btn_split = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Enabled = false;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(26, 27);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(341, 38);
            this.display.TabIndex = 19;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_changeSymbol
            // 
            this.btn_changeSymbol.Location = new System.Drawing.Point(69, 99);
            this.btn_changeSymbol.Name = "btn_changeSymbol";
            this.btn_changeSymbol.Size = new System.Drawing.Size(45, 32);
            this.btn_changeSymbol.TabIndex = 18;
            this.btn_changeSymbol.Text = "+/-";
            this.btn_changeSymbol.UseVisualStyleBackColor = true;
            this.btn_changeSymbol.Click += new System.EventHandler(this.btn_changeSymbol_Click);
            // 
            // btn_deleteDigit
            // 
            this.btn_deleteDigit.Location = new System.Drawing.Point(69, 61);
            this.btn_deleteDigit.Name = "btn_deleteDigit";
            this.btn_deleteDigit.Size = new System.Drawing.Size(45, 32);
            this.btn_deleteDigit.TabIndex = 17;
            this.btn_deleteDigit.Text = "<--";
            this.btn_deleteDigit.UseVisualStyleBackColor = true;
            this.btn_deleteDigit.Click += new System.EventHandler(this.btn_deleteDigit_Click);
            // 
            // btn_clearDisplay
            // 
            this.btn_clearDisplay.Location = new System.Drawing.Point(69, 23);
            this.btn_clearDisplay.Name = "btn_clearDisplay";
            this.btn_clearDisplay.Size = new System.Drawing.Size(45, 32);
            this.btn_clearDisplay.TabIndex = 16;
            this.btn_clearDisplay.Text = "Clear";
            this.btn_clearDisplay.UseVisualStyleBackColor = true;
            this.btn_clearDisplay.Click += new System.EventHandler(this.btn_clearDisplay_Click);
            // 
            // btn_equals
            // 
            this.btn_equals.Location = new System.Drawing.Point(69, 137);
            this.btn_equals.Name = "btn_equals";
            this.btn_equals.Size = new System.Drawing.Size(45, 32);
            this.btn_equals.TabIndex = 15;
            this.btn_equals.Text = "=";
            this.btn_equals.UseVisualStyleBackColor = true;
            this.btn_equals.Click += new System.EventHandler(this.btn_equals_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(18, 137);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(45, 32);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_substract
            // 
            this.btn_substract.Location = new System.Drawing.Point(18, 99);
            this.btn_substract.Name = "btn_substract";
            this.btn_substract.Size = new System.Drawing.Size(45, 32);
            this.btn_substract.TabIndex = 13;
            this.btn_substract.Text = "-";
            this.btn_substract.UseVisualStyleBackColor = true;
            this.btn_substract.Click += new System.EventHandler(this.btn_substract_Click);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Location = new System.Drawing.Point(18, 61);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(45, 32);
            this.btn_multiply.TabIndex = 12;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
            // 
            // btn_decimal
            // 
            this.btn_decimal.Location = new System.Drawing.Point(117, 137);
            this.btn_decimal.Name = "btn_decimal";
            this.btn_decimal.Size = new System.Drawing.Size(45, 32);
            this.btn_decimal.TabIndex = 11;
            this.btn_decimal.Text = ",";
            this.btn_decimal.UseVisualStyleBackColor = true;
            this.btn_decimal.Click += new System.EventHandler(this.btn_decimal_Click);
            // 
            // btn_number0
            // 
            this.btn_number0.Location = new System.Drawing.Point(15, 137);
            this.btn_number0.Name = "btn_number0";
            this.btn_number0.Size = new System.Drawing.Size(96, 32);
            this.btn_number0.TabIndex = 9;
            this.btn_number0.Text = "0";
            this.btn_number0.UseVisualStyleBackColor = true;
            this.btn_number0.Click += new System.EventHandler(this.btn_number0_Click);
            // 
            // btn_number9
            // 
            this.btn_number9.Location = new System.Drawing.Point(117, 99);
            this.btn_number9.Name = "btn_number9";
            this.btn_number9.Size = new System.Drawing.Size(45, 32);
            this.btn_number9.TabIndex = 8;
            this.btn_number9.Text = "9";
            this.btn_number9.UseVisualStyleBackColor = true;
            this.btn_number9.Click += new System.EventHandler(this.btn_number9_Click);
            // 
            // btn_number8
            // 
            this.btn_number8.Location = new System.Drawing.Point(66, 99);
            this.btn_number8.Name = "btn_number8";
            this.btn_number8.Size = new System.Drawing.Size(45, 32);
            this.btn_number8.TabIndex = 7;
            this.btn_number8.Text = "8";
            this.btn_number8.UseVisualStyleBackColor = true;
            this.btn_number8.Click += new System.EventHandler(this.btn_number8_Click);
            // 
            // btn_number7
            // 
            this.btn_number7.Location = new System.Drawing.Point(15, 99);
            this.btn_number7.Name = "btn_number7";
            this.btn_number7.Size = new System.Drawing.Size(45, 32);
            this.btn_number7.TabIndex = 6;
            this.btn_number7.Text = "7";
            this.btn_number7.UseVisualStyleBackColor = true;
            this.btn_number7.Click += new System.EventHandler(this.btn_number7_Click);
            // 
            // btn_number6
            // 
            this.btn_number6.Location = new System.Drawing.Point(117, 61);
            this.btn_number6.Name = "btn_number6";
            this.btn_number6.Size = new System.Drawing.Size(45, 32);
            this.btn_number6.TabIndex = 5;
            this.btn_number6.Text = "6";
            this.btn_number6.UseVisualStyleBackColor = true;
            this.btn_number6.Click += new System.EventHandler(this.btn_number6_Click);
            // 
            // btn_number5
            // 
            this.btn_number5.Location = new System.Drawing.Point(66, 61);
            this.btn_number5.Name = "btn_number5";
            this.btn_number5.Size = new System.Drawing.Size(45, 32);
            this.btn_number5.TabIndex = 4;
            this.btn_number5.Text = "5";
            this.btn_number5.UseVisualStyleBackColor = true;
            this.btn_number5.Click += new System.EventHandler(this.btn_number5_Click);
            // 
            // btn_number4
            // 
            this.btn_number4.Location = new System.Drawing.Point(15, 61);
            this.btn_number4.Name = "btn_number4";
            this.btn_number4.Size = new System.Drawing.Size(45, 32);
            this.btn_number4.TabIndex = 3;
            this.btn_number4.Text = "4";
            this.btn_number4.UseVisualStyleBackColor = true;
            this.btn_number4.Click += new System.EventHandler(this.btn_number4_Click);
            // 
            // btn_number3
            // 
            this.btn_number3.Location = new System.Drawing.Point(117, 23);
            this.btn_number3.Name = "btn_number3";
            this.btn_number3.Size = new System.Drawing.Size(45, 32);
            this.btn_number3.TabIndex = 2;
            this.btn_number3.Text = "3";
            this.btn_number3.UseVisualStyleBackColor = true;
            this.btn_number3.Click += new System.EventHandler(this.btn_number3_Click);
            // 
            // btn_number2
            // 
            this.btn_number2.Location = new System.Drawing.Point(66, 23);
            this.btn_number2.Name = "btn_number2";
            this.btn_number2.Size = new System.Drawing.Size(45, 32);
            this.btn_number2.TabIndex = 1;
            this.btn_number2.Text = "2";
            this.btn_number2.UseVisualStyleBackColor = true;
            this.btn_number2.Click += new System.EventHandler(this.btn_number2_Click);
            // 
            // btn_number1
            // 
            this.btn_number1.Location = new System.Drawing.Point(15, 23);
            this.btn_number1.Name = "btn_number1";
            this.btn_number1.Size = new System.Drawing.Size(45, 32);
            this.btn_number1.TabIndex = 0;
            this.btn_number1.Text = "1";
            this.btn_number1.UseVisualStyleBackColor = true;
            this.btn_number1.Click += new System.EventHandler(this.btn_number1_Click);
            // 
            // btn_split
            // 
            this.btn_split.Location = new System.Drawing.Point(18, 23);
            this.btn_split.Name = "btn_split";
            this.btn_split.Size = new System.Drawing.Size(45, 32);
            this.btn_split.TabIndex = 20;
            this.btn_split.Text = "/";
            this.btn_split.UseVisualStyleBackColor = true;
            this.btn_split.Click += new System.EventHandler(this.btn_split_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_number1);
            this.groupBox1.Controls.Add(this.btn_number2);
            this.groupBox1.Controls.Add(this.btn_number3);
            this.groupBox1.Controls.Add(this.btn_number4);
            this.groupBox1.Controls.Add(this.btn_number5);
            this.groupBox1.Controls.Add(this.btn_number6);
            this.groupBox1.Controls.Add(this.btn_number7);
            this.groupBox1.Controls.Add(this.btn_decimal);
            this.groupBox1.Controls.Add(this.btn_number8);
            this.groupBox1.Controls.Add(this.btn_number0);
            this.groupBox1.Controls.Add(this.btn_number9);
            this.groupBox1.Location = new System.Drawing.Point(26, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 186);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numerical";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_changeSymbol);
            this.groupBox2.Controls.Add(this.btn_split);
            this.groupBox2.Controls.Add(this.btn_multiply);
            this.groupBox2.Controls.Add(this.btn_deleteDigit);
            this.groupBox2.Controls.Add(this.btn_substract);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.btn_clearDisplay);
            this.groupBox2.Controls.Add(this.btn_equals);
            this.groupBox2.Location = new System.Drawing.Point(236, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 186);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(388, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandosToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // comandosToolStripMenuItem
            // 
            this.comandosToolStripMenuItem.Name = "comandosToolStripMenuItem";
            this.comandosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.comandosToolStripMenuItem.Text = "Comandos abreviados";
            this.comandosToolStripMenuItem.Click += new System.EventHandler(this.comandosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de Calculadora";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 286);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button btn_changeSymbol;
        private System.Windows.Forms.Button btn_deleteDigit;
        private System.Windows.Forms.Button btn_clearDisplay;
        private System.Windows.Forms.Button btn_equals;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_substract;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_decimal;
        private System.Windows.Forms.Button btn_number0;
        private System.Windows.Forms.Button btn_number9;
        private System.Windows.Forms.Button btn_number8;
        private System.Windows.Forms.Button btn_number7;
        private System.Windows.Forms.Button btn_number6;
        private System.Windows.Forms.Button btn_number5;
        private System.Windows.Forms.Button btn_number4;
        private System.Windows.Forms.Button btn_number3;
        private System.Windows.Forms.Button btn_number2;
        private System.Windows.Forms.Button btn_number1;
        private System.Windows.Forms.Button btn_split;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

