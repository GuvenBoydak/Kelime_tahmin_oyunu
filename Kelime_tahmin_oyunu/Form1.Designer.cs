
namespace Kelime_tahmin_oyunu
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
            this.btnTry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuessLetter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuessWord = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.flwquestion = new System.Windows.Forms.FlowLayoutPanel();
            this.lblquestion = new System.Windows.Forms.Label();
            this.flwButtonList = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lstGuessedWord = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHearts = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.flwquestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTry
            // 
            this.btnTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTry.Location = new System.Drawing.Point(309, 15);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(97, 33);
            this.btnTry.TabIndex = 0;
            this.btnTry.Text = "TRY";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess Letter:";
            // 
            // txtGuessLetter
            // 
            this.txtGuessLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuessLetter.Location = new System.Drawing.Point(148, 15);
            this.txtGuessLetter.Name = "txtGuessLetter";
            this.txtGuessLetter.Size = new System.Drawing.Size(140, 30);
            this.txtGuessLetter.TabIndex = 2;
            this.txtGuessLetter.TextChanged += new System.EventHandler(this.txtGuessLetter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Guess Word:";
            // 
            // txtGuessWord
            // 
            this.txtGuessWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuessWord.Location = new System.Drawing.Point(148, 71);
            this.txtGuessWord.Name = "txtGuessWord";
            this.txtGuessWord.Size = new System.Drawing.Size(140, 30);
            this.txtGuessWord.TabIndex = 4;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(309, 73);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(97, 30);
            this.btnGuess.TabIndex = 5;
            this.btnGuess.Text = "GUESS";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(574, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 37);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Location = new System.Drawing.Point(574, 70);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(87, 33);
            this.btnPass.TabIndex = 7;
            this.btnPass.Text = "PASS";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // flwquestion
            // 
            this.flwquestion.Controls.Add(this.lblquestion);
            this.flwquestion.Location = new System.Drawing.Point(12, 119);
            this.flwquestion.Name = "flwquestion";
            this.flwquestion.Size = new System.Drawing.Size(697, 95);
            this.flwquestion.TabIndex = 8;
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Location = new System.Drawing.Point(3, 0);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(140, 17);
            this.lblquestion.TabIndex = 0;
            this.lblquestion.Text = "Question is coming...";
            // 
            // flwButtonList
            // 
            this.flwButtonList.Location = new System.Drawing.Point(12, 220);
            this.flwButtonList.Name = "flwButtonList";
            this.flwButtonList.Size = new System.Drawing.Size(697, 116);
            this.flwButtonList.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "GUESSED WORD";
            // 
            // lstGuessedWord
            // 
            this.lstGuessedWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuessedWord.FormattingEnabled = true;
            this.lstGuessedWord.ItemHeight = 29;
            this.lstGuessedWord.Location = new System.Drawing.Point(18, 398);
            this.lstGuessedWord.Name = "lstGuessedWord";
            this.lstGuessedWord.Size = new System.Drawing.Size(198, 91);
            this.lstGuessedWord.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(540, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "HEART:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(540, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "SCORE:";
            // 
            // lblHearts
            // 
            this.lblHearts.AutoSize = true;
            this.lblHearts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHearts.Location = new System.Drawing.Point(651, 379);
            this.lblHearts.Name = "lblHearts";
            this.lblHearts.Size = new System.Drawing.Size(27, 29);
            this.lblHearts.TabIndex = 14;
            this.lblHearts.Text = "3";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(655, 446);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(27, 29);
            this.lblScore.TabIndex = 15;
            this.lblScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 525);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHearts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstGuessedWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flwButtonList);
            this.Controls.Add(this.flwquestion);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuessWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGuessLetter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flwquestion.ResumeLayout(false);
            this.flwquestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGuessLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuessWord;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.FlowLayoutPanel flwquestion;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.FlowLayoutPanel flwButtonList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstGuessedWord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHearts;
        private System.Windows.Forms.Label lblScore;
    }
}

