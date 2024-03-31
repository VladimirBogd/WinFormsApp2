namespace WinFormsApp2
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
            this.textBoxSequence = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonTask = new System.Windows.Forms.Button();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSequence
            // 
            this.textBoxSequence.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxSequence.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSequence.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSequence.Location = new System.Drawing.Point(15, 78);
            this.textBoxSequence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSequence.Name = "textBoxSequence";
            this.textBoxSequence.Size = new System.Drawing.Size(281, 25);
            this.textBoxSequence.TabIndex = 0;
            this.textBoxSequence.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSequence_KeyUp);
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(15, 52);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(281, 25);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Введите числа через пробел";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResult.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResult.Location = new System.Drawing.Point(47, 109);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(217, 67);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "Посчитать количество бОльших \"соседей\"";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            this.buttonResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonResult_KeyUp);
            this.buttonResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonResult_MouseClick);
            // 
            // buttonTask
            // 
            this.buttonTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTask.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTask.Location = new System.Drawing.Point(10, 12);
            this.buttonTask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(101, 29);
            this.buttonTask.TabIndex = 3;
            this.buttonTask.Text = "Задание";
            this.buttonTask.UseVisualStyleBackColor = false;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAnswer.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAnswer.Location = new System.Drawing.Point(13, 231);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(284, 68);
            this.labelAnswer.TabIndex = 11;
            this.labelAnswer.Text = "Ответ:";
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClean.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClean.Location = new System.Drawing.Point(90, 302);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(130, 30);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Очистить поля";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(308, 336);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxSequence);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "бОльшие \"соседи\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSequence;
        private Label labelDescription;
        private Button buttonResult;
        private Button buttonTask;
        private Label labelAnswer;
        private Button buttonClean;
    }
}