namespace Internet_Cards
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
            this.browseImgBtn = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QCL = new System.Windows.Forms.RadioButton();
            this.BCL = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QCR = new System.Windows.Forms.RadioButton();
            this.BCR = new System.Windows.Forms.RadioButton();
            this.processBtn = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseImgBtn
            // 
            this.browseImgBtn.Location = new System.Drawing.Point(187, 12);
            this.browseImgBtn.Name = "browseImgBtn";
            this.browseImgBtn.Size = new System.Drawing.Size(75, 23);
            this.browseImgBtn.TabIndex = 0;
            this.browseImgBtn.Text = "Selectionner";
            this.browseImgBtn.UseVisualStyleBackColor = true;
            this.browseImgBtn.Click += new System.EventHandler(this.browseImgBtn_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(49, 175);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(347, 295);
            this.Result.TabIndex = 1;
            this.Result.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QCL);
            this.groupBox1.Controls.Add(this.BCL);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 63);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colonne Gauche";
            // 
            // QCL
            // 
            this.QCL.AutoSize = true;
            this.QCL.Location = new System.Drawing.Point(97, 28);
            this.QCL.Name = "QCL";
            this.QCL.Size = new System.Drawing.Size(69, 17);
            this.QCL.TabIndex = 1;
            this.QCL.TabStop = true;
            this.QCL.Text = "Code QR";
            this.QCL.UseVisualStyleBackColor = true;
            // 
            // BCL
            // 
            this.BCL.AutoSize = true;
            this.BCL.Location = new System.Drawing.Point(6, 28);
            this.BCL.Name = "BCL";
            this.BCL.Size = new System.Drawing.Size(78, 17);
            this.BCL.TabIndex = 0;
            this.BCL.TabStop = true;
            this.BCL.Text = "Code Barre";
            this.BCL.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QCR);
            this.groupBox2.Controls.Add(this.BCR);
            this.groupBox2.Location = new System.Drawing.Point(232, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colonne Droite";
            // 
            // QCR
            // 
            this.QCR.AutoSize = true;
            this.QCR.Location = new System.Drawing.Point(112, 28);
            this.QCR.Name = "QCR";
            this.QCR.Size = new System.Drawing.Size(69, 17);
            this.QCR.TabIndex = 3;
            this.QCR.TabStop = true;
            this.QCR.Text = "Code QR";
            this.QCR.UseVisualStyleBackColor = true;
            // 
            // BCR
            // 
            this.BCR.AutoSize = true;
            this.BCR.Location = new System.Drawing.Point(6, 28);
            this.BCR.Name = "BCR";
            this.BCR.Size = new System.Drawing.Size(78, 17);
            this.BCR.TabIndex = 2;
            this.BCR.TabStop = true;
            this.BCR.Text = "Code Barre";
            this.BCR.UseVisualStyleBackColor = true;
            // 
            // processBtn
            // 
            this.processBtn.Location = new System.Drawing.Point(154, 128);
            this.processBtn.Name = "processBtn";
            this.processBtn.Size = new System.Drawing.Size(75, 23);
            this.processBtn.TabIndex = 6;
            this.processBtn.Text = "Extracter";
            this.processBtn.UseVisualStyleBackColor = true;
            this.processBtn.Click += new System.EventHandler(this.processBtn_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(49, 476);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(347, 23);
            this.progress.TabIndex = 7;
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(241, 128);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Vider";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 526);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.processBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.browseImgBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseImgBtn;
        private System.Windows.Forms.RichTextBox Result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton QCL;
        private System.Windows.Forms.RadioButton BCL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton QCR;
        private System.Windows.Forms.RadioButton BCR;
        private System.Windows.Forms.Button processBtn;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button resetBtn;
    }
}

