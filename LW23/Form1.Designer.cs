namespace LW23
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
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CoefficientATextBox = new System.Windows.Forms.TextBox();
            this.drawGraphButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Location = new System.Drawing.Point(6, 11);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(338, 333);
            this.graphPictureBox.TabIndex = 0;
            this.graphPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть коефіцієнт a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "a =";
            // 
            // CoefficientATextBox
            // 
            this.CoefficientATextBox.Location = new System.Drawing.Point(88, 114);
            this.CoefficientATextBox.Name = "CoefficientATextBox";
            this.CoefficientATextBox.Size = new System.Drawing.Size(76, 20);
            this.CoefficientATextBox.TabIndex = 4;
            this.CoefficientATextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoefficientATextBox_KeyPress);
            // 
            // drawGraphButton
            // 
            this.drawGraphButton.Location = new System.Drawing.Point(88, 254);
            this.drawGraphButton.Name = "drawGraphButton";
            this.drawGraphButton.Size = new System.Drawing.Size(144, 74);
            this.drawGraphButton.TabIndex = 6;
            this.drawGraphButton.Text = "Побудувати графік";
            this.drawGraphButton.UseVisualStyleBackColor = true;
            this.drawGraphButton.Click += new System.EventHandler(this.drawGraphButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.graphPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(394, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 350);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // scaleNumericUpDown
            // 
            this.scaleNumericUpDown.Location = new System.Drawing.Point(132, 177);
            this.scaleNumericUpDown.Name = "scaleNumericUpDown";
            this.scaleNumericUpDown.Size = new System.Drawing.Size(32, 20);
            this.scaleNumericUpDown.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Масштаб: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scaleNumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drawGraphButton);
            this.Controls.Add(this.CoefficientATextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Побудова графіка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scaleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CoefficientATextBox;
        private System.Windows.Forms.Button drawGraphButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown scaleNumericUpDown;
        private System.Windows.Forms.Label label3;
    }
}

