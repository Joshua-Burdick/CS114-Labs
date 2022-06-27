
namespace CalcLab
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
            this.Results = new System.Windows.Forms.TextBox();
            this.opClear = new System.Windows.Forms.Button();
            this.opSQRT = new System.Windows.Forms.Button();
            this.opEXP = new System.Windows.Forms.Button();
            this.opMod = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.numDec = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.opEquals = new System.Windows.Forms.Button();
            this.opAdd = new System.Windows.Forms.Button();
            this.opMinus = new System.Windows.Forms.Button();
            this.opDivide = new System.Windows.Forms.Button();
            this.opMultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(64, 59);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Size = new System.Drawing.Size(257, 22);
            this.Results.TabIndex = 0;
            this.Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // opClear
            // 
            this.opClear.BackColor = System.Drawing.Color.White;
            this.opClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opClear.Location = new System.Drawing.Point(64, 98);
            this.opClear.Name = "opClear";
            this.opClear.Size = new System.Drawing.Size(50, 50);
            this.opClear.TabIndex = 1;
            this.opClear.Text = "C";
            this.opClear.UseVisualStyleBackColor = false;
            this.opClear.Click += new System.EventHandler(this.opClear_Click);
            // 
            // opSQRT
            // 
            this.opSQRT.BackColor = System.Drawing.Color.Gray;
            this.opSQRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opSQRT.Location = new System.Drawing.Point(133, 98);
            this.opSQRT.Name = "opSQRT";
            this.opSQRT.Size = new System.Drawing.Size(50, 50);
            this.opSQRT.TabIndex = 2;
            this.opSQRT.UseVisualStyleBackColor = false;
            this.opSQRT.Click += new System.EventHandler(this.opSQRT_Click);
            // 
            // opEXP
            // 
            this.opEXP.BackColor = System.Drawing.Color.Gray;
            this.opEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opEXP.Location = new System.Drawing.Point(202, 98);
            this.opEXP.Name = "opEXP";
            this.opEXP.Size = new System.Drawing.Size(50, 50);
            this.opEXP.TabIndex = 3;
            this.opEXP.Text = "x^y";
            this.opEXP.UseVisualStyleBackColor = false;
            this.opEXP.Click += new System.EventHandler(this.opEXP_Click);
            // 
            // opMod
            // 
            this.opMod.BackColor = System.Drawing.Color.Gray;
            this.opMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opMod.Location = new System.Drawing.Point(271, 98);
            this.opMod.Name = "opMod";
            this.opMod.Size = new System.Drawing.Size(50, 50);
            this.opMod.TabIndex = 4;
            this.opMod.Text = "%";
            this.opMod.UseVisualStyleBackColor = false;
            this.opMod.Click += new System.EventHandler(this.opMod_Click);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(64, 154);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(50, 50);
            this.num7.TabIndex = 5;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(64, 210);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(50, 50);
            this.num4.TabIndex = 6;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(64, 266);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(50, 50);
            this.num1.TabIndex = 7;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(64, 322);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(50, 50);
            this.num0.TabIndex = 8;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(133, 154);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(50, 50);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(133, 210);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(50, 50);
            this.num5.TabIndex = 10;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(133, 266);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(50, 50);
            this.num2.TabIndex = 11;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // numDec
            // 
            this.numDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDec.Location = new System.Drawing.Point(133, 322);
            this.numDec.Name = "numDec";
            this.numDec.Size = new System.Drawing.Size(50, 50);
            this.numDec.TabIndex = 12;
            this.numDec.Text = ".";
            this.numDec.UseVisualStyleBackColor = true;
            this.numDec.Click += new System.EventHandler(this.numDec_Click);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(202, 154);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(50, 50);
            this.num9.TabIndex = 13;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(202, 210);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(50, 50);
            this.num6.TabIndex = 14;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(202, 266);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(50, 50);
            this.num3.TabIndex = 15;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // opEquals
            // 
            this.opEquals.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.opEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opEquals.Location = new System.Drawing.Point(202, 322);
            this.opEquals.Name = "opEquals";
            this.opEquals.Size = new System.Drawing.Size(50, 50);
            this.opEquals.TabIndex = 16;
            this.opEquals.Text = "=";
            this.opEquals.UseVisualStyleBackColor = false;
            this.opEquals.Click += new System.EventHandler(this.opEquals_Click);
            // 
            // opAdd
            // 
            this.opAdd.BackColor = System.Drawing.Color.Gray;
            this.opAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opAdd.Location = new System.Drawing.Point(271, 154);
            this.opAdd.Name = "opAdd";
            this.opAdd.Size = new System.Drawing.Size(50, 50);
            this.opAdd.TabIndex = 17;
            this.opAdd.Text = "+";
            this.opAdd.UseVisualStyleBackColor = false;
            this.opAdd.Click += new System.EventHandler(this.opAdd_Click);
            // 
            // opMinus
            // 
            this.opMinus.BackColor = System.Drawing.Color.Gray;
            this.opMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opMinus.Location = new System.Drawing.Point(271, 210);
            this.opMinus.Name = "opMinus";
            this.opMinus.Size = new System.Drawing.Size(50, 50);
            this.opMinus.TabIndex = 18;
            this.opMinus.Text = "-";
            this.opMinus.UseVisualStyleBackColor = false;
            this.opMinus.Click += new System.EventHandler(this.opMinus_Click);
            // 
            // opDivide
            // 
            this.opDivide.BackColor = System.Drawing.Color.Gray;
            this.opDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opDivide.Location = new System.Drawing.Point(271, 266);
            this.opDivide.Name = "opDivide";
            this.opDivide.Size = new System.Drawing.Size(50, 50);
            this.opDivide.TabIndex = 19;
            this.opDivide.Text = "/";
            this.opDivide.UseVisualStyleBackColor = false;
            this.opDivide.Click += new System.EventHandler(this.opDivide_Click);
            // 
            // opMultiply
            // 
            this.opMultiply.BackColor = System.Drawing.Color.Gray;
            this.opMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opMultiply.Location = new System.Drawing.Point(271, 322);
            this.opMultiply.Name = "opMultiply";
            this.opMultiply.Size = new System.Drawing.Size(50, 50);
            this.opMultiply.TabIndex = 20;
            this.opMultiply.Text = "x";
            this.opMultiply.UseVisualStyleBackColor = false;
            this.opMultiply.Click += new System.EventHandler(this.opMultiply_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 448);
            this.Controls.Add(this.opMultiply);
            this.Controls.Add(this.opDivide);
            this.Controls.Add(this.opMinus);
            this.Controls.Add(this.opAdd);
            this.Controls.Add(this.opEquals);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.numDec);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.opMod);
            this.Controls.Add(this.opEXP);
            this.Controls.Add(this.opSQRT);
            this.Controls.Add(this.opClear);
            this.Controls.Add(this.Results);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Button opClear;
        private System.Windows.Forms.Button opSQRT;
        private System.Windows.Forms.Button opEXP;
        private System.Windows.Forms.Button opMod;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button numDec;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button opEquals;
        private System.Windows.Forms.Button opAdd;
        private System.Windows.Forms.Button opMinus;
        private System.Windows.Forms.Button opDivide;
        private System.Windows.Forms.Button opMultiply;
    }
}

