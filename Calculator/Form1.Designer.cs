using System;
using System.Windows.Forms;

namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bMulti = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bResult = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bDot = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.tbOperat = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.bPlusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b7.Location = new System.Drawing.Point(14, 94);
            this.b7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(72, 59);
            this.b7.TabIndex = 2;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b8.Location = new System.Drawing.Point(93, 94);
            this.b8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(72, 59);
            this.b8.TabIndex = 3;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b9.Location = new System.Drawing.Point(173, 94);
            this.b9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(72, 59);
            this.b9.TabIndex = 4;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bDiv
            // 
            this.bDiv.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDiv.Location = new System.Drawing.Point(252, 291);
            this.bDiv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(72, 59);
            this.bDiv.TabIndex = 5;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(14, 159);
            this.b4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(72, 59);
            this.b4.TabIndex = 6;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b5.Location = new System.Drawing.Point(93, 159);
            this.b5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(72, 59);
            this.b5.TabIndex = 7;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b6.Location = new System.Drawing.Point(173, 159);
            this.b6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(72, 59);
            this.b6.TabIndex = 8;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // bMulti
            // 
            this.bMulti.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMulti.Location = new System.Drawing.Point(252, 159);
            this.bMulti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bMulti.Name = "bMulti";
            this.bMulti.Size = new System.Drawing.Size(72, 59);
            this.bMulti.TabIndex = 9;
            this.bMulti.Text = "*";
            this.bMulti.UseVisualStyleBackColor = true;
            this.bMulti.Click += new System.EventHandler(this.bMulti_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(14, 225);
            this.b1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(72, 59);
            this.b1.TabIndex = 10;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(93, 225);
            this.b2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(72, 59);
            this.b2.TabIndex = 11;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(173, 225);
            this.b3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(72, 59);
            this.b3.TabIndex = 12;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // bMinus
            // 
            this.bMinus.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bMinus.Location = new System.Drawing.Point(252, 224);
            this.bMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(72, 59);
            this.bMinus.TabIndex = 13;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b0.Location = new System.Drawing.Point(14, 291);
            this.b0.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(72, 59);
            this.b0.TabIndex = 14;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bResult
            // 
            this.bResult.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bResult.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bResult.Location = new System.Drawing.Point(93, 358);
            this.bResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bResult.Name = "bResult";
            this.bResult.Size = new System.Drawing.Size(231, 59);
            this.bResult.TabIndex = 15;
            this.bResult.Text = "=";
            this.bResult.UseVisualStyleBackColor = false;
            this.bResult.Click += new System.EventHandler(this.bResult_Click);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPlus.Location = new System.Drawing.Point(173, 291);
            this.bPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(72, 59);
            this.bPlus.TabIndex = 16;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bDot
            // 
            this.bDot.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bDot.Location = new System.Drawing.Point(93, 291);
            this.bDot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bDot.Name = "bDot";
            this.bDot.Size = new System.Drawing.Size(72, 59);
            this.bDot.TabIndex = 17;
            this.bDot.Text = ".";
            this.bDot.UseVisualStyleBackColor = true;
            this.bDot.Click += new System.EventHandler(this.bDot_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bClear.Location = new System.Drawing.Point(252, 94);
            this.bClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(72, 59);
            this.bClear.TabIndex = 18;
            this.bClear.Text = "CE";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // tbOperat
            // 
            this.tbOperat.BackColor = System.Drawing.SystemColors.Window;
            this.tbOperat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOperat.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbOperat.Location = new System.Drawing.Point(24, 55);
            this.tbOperat.Name = "tbOperat";
            this.tbOperat.Size = new System.Drawing.Size(289, 20);
            this.tbOperat.TabIndex = 19;
            this.tbOperat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.SystemColors.Window;
            this.tbResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbResult.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbResult.Location = new System.Drawing.Point(14, 14);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbResult.Name = "tbResult";
            this.tbResult.SelectionAlignment = HorizontalAlignment.Right;
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(310, 72);
            this.tbResult.TabIndex = 1;
            this.tbResult.Text = "";
            // 
            // bPlusMinus
            // 
            this.bPlusMinus.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bPlusMinus.Location = new System.Drawing.Point(14, 358);
            this.bPlusMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bPlusMinus.Name = "bPlusMinus";
            this.bPlusMinus.Size = new System.Drawing.Size(72, 59);
            this.bPlusMinus.TabIndex = 14;
            this.bPlusMinus.Text = "-/+";
            this.bPlusMinus.UseVisualStyleBackColor = true;
            this.bPlusMinus.Click += new System.EventHandler(this.bPlusMinus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(337, 430);
            this.Controls.Add(this.tbOperat);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bDot);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bResult);
            this.Controls.Add(this.bPlusMinus);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bMulti);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.tbResult);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        

        #endregion
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bMulti;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bResult;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bDot;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.TextBox tbOperat;
        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.Button bPlusMinus;

        public EventHandler Form1_Load { get; private set; }
    }
}

