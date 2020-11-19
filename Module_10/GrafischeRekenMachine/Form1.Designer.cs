
namespace GrafischeRekenMachine
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nrA = new System.Windows.Forms.NumericUpDown();
            this.nrB = new System.Windows.Forms.NumericUpDown();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "B";
            // 
            // nrA
            // 
            this.nrA.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nrA.Location = new System.Drawing.Point(78, 25);
            this.nrA.Name = "nrA";
            this.nrA.Size = new System.Drawing.Size(120, 50);
            this.nrA.TabIndex = 2;
            // 
            // nrB
            // 
            this.nrB.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nrB.Location = new System.Drawing.Point(78, 94);
            this.nrB.Name = "nrB";
            this.nrB.Size = new System.Drawing.Size(120, 50);
            this.nrB.TabIndex = 3;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.Location = new System.Drawing.Point(78, 197);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(124, 45);
            this.lblAnswer.TabIndex = 4;
            this.lblAnswer.Text = "________";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(286, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 117);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.nrB);
            this.Controls.Add(this.nrA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rekenmachine";
            ((System.ComponentModel.ISupportInitialize)(this.nrA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nrA;
        private System.Windows.Forms.NumericUpDown nrB;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button button1;
    }
}

