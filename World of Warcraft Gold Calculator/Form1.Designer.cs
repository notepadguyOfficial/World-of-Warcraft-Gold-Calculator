namespace World_of_Warcraft_Gold_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GoldInput = new System.Windows.Forms.NumericUpDown();
            this.SilverInput = new System.Windows.Forms.NumericUpDown();
            this.CopperInput = new System.Windows.Forms.NumericUpDown();
            this.GoldResult = new System.Windows.Forms.TextBox();
            this.SilverResult = new System.Windows.Forms.TextBox();
            this.CopperResutl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GoldInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilverInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopperInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gold Coin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Silver Coin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Copper Coin";
            // 
            // GoldInput
            // 
            this.GoldInput.Location = new System.Drawing.Point(164, 39);
            this.GoldInput.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.GoldInput.Name = "GoldInput";
            this.GoldInput.Size = new System.Drawing.Size(299, 22);
            this.GoldInput.TabIndex = 4;
            this.GoldInput.ValueChanged += new System.EventHandler(this.GoldInput_ValueChanged);
            // 
            // SilverInput
            // 
            this.SilverInput.Location = new System.Drawing.Point(164, 188);
            this.SilverInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.SilverInput.Name = "SilverInput";
            this.SilverInput.Size = new System.Drawing.Size(299, 22);
            this.SilverInput.TabIndex = 5;
            this.SilverInput.ValueChanged += new System.EventHandler(this.SilverInput_ValueChanged);
            // 
            // CopperInput
            // 
            this.CopperInput.Location = new System.Drawing.Point(164, 331);
            this.CopperInput.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.CopperInput.Name = "CopperInput";
            this.CopperInput.Size = new System.Drawing.Size(299, 22);
            this.CopperInput.TabIndex = 6;
            this.CopperInput.ValueChanged += new System.EventHandler(this.CopperInput_ValueChanged);
            // 
            // GoldResult
            // 
            this.GoldResult.Location = new System.Drawing.Point(494, 39);
            this.GoldResult.Name = "GoldResult";
            this.GoldResult.ReadOnly = true;
            this.GoldResult.Size = new System.Drawing.Size(279, 22);
            this.GoldResult.TabIndex = 7;
            this.GoldResult.Text = "0";
            // 
            // SilverResult
            // 
            this.SilverResult.Location = new System.Drawing.Point(494, 188);
            this.SilverResult.Name = "SilverResult";
            this.SilverResult.ReadOnly = true;
            this.SilverResult.Size = new System.Drawing.Size(279, 22);
            this.SilverResult.TabIndex = 8;
            this.SilverResult.Text = "0";
            // 
            // CopperResutl
            // 
            this.CopperResutl.Location = new System.Drawing.Point(494, 334);
            this.CopperResutl.Name = "CopperResutl";
            this.CopperResutl.ReadOnly = true;
            this.CopperResutl.Size = new System.Drawing.Size(279, 22);
            this.CopperResutl.TabIndex = 9;
            this.CopperResutl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CopperResutl);
            this.Controls.Add(this.SilverResult);
            this.Controls.Add(this.GoldResult);
            this.Controls.Add(this.CopperInput);
            this.Controls.Add(this.SilverInput);
            this.Controls.Add(this.GoldInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "World of Warcraft Gold Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.GoldInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SilverInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CopperInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown GoldInput;
        private System.Windows.Forms.NumericUpDown SilverInput;
        private System.Windows.Forms.NumericUpDown CopperInput;
        private System.Windows.Forms.TextBox GoldResult;
        private System.Windows.Forms.TextBox SilverResult;
        private System.Windows.Forms.TextBox CopperResutl;
    }
}

