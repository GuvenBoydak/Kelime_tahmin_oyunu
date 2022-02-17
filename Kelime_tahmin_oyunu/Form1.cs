using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_tahmin_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        List<char> letters = new List<char>();

        int selectedIndexQustion = -1;
        int LifeCount = 3;
        int score;

        void lettersAdd()
        {
            for (int i = 65; i <= 90; i++)
            {
                letters.Add(Convert.ToChar(i));

                switch (i)
                {
                    case 67:
                        letters.Add(Convert.ToChar(199));
                        break;
                    case 73:
                        letters.Add(Convert.ToChar(304));
                        break;
                    case 79:
                        letters.Add(Convert.ToChar(214));
                        break;
                    case 85:
                        letters.Add(Convert.ToChar(220));
                        break;
                    case 83:
                        letters.Add(Convert.ToChar(350));
                        break;
                    case 71:
                        letters.Add(Convert.ToChar(286));
                        break;
                    default:
                        break;
                }
            }
        }
        void AnswerAndQuestions()
        {
            questions.Add("Türkiyenin Başkenti neresidir?");
            answers.Add("Ankara");
            questions.Add("Hollandanın Başkenti Neresidir?");
            answers.Add("Amsterdam");
            questions.Add("Avrupadaki bir Şehir?");
            answers.Add("Belçika");
        }
        void GameStart()
        {
            Random rdm = new Random();
            int random;
            LifeCount = 3;
            score = 0;

            lblHearts.Text = LifeCount.ToString();
            lblScore.Text = score.ToString();
            do
            {
                random = rdm.Next(0, questions.Count);

            } while (selectedIndexQustion == random);
            flwquestion.Controls.Clear();

            selectedIndexQustion = random;

            string question = questions[selectedIndexQustion];
            string answer = answers[selectedIndexQustion];

            foreach (var item in answer)
            {
                Button btn = new Button();
                btn.Text = string.Empty;
                btn.Tag = item.ToString().ToUpper();
                flwButtonList.Controls.Add(btn);
            }
            lblquestion.Text = question;
            flwquestion.Controls.Add(lblquestion);



        }
        int GuessletterCounter(string answer, string text)
        {
            int counter = 0;
            char[] letter = answer.ToCharArray();

            foreach (var item in flwButtonList.Controls)
            {
                foreach (var s in letter)
                {
                    if (text.ToString().ToUpper() == s.ToString().ToUpper())
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        bool CheckGuessLetter(string text)
        {
            bool IsExixt = false;
            foreach (var item in flwButtonList.Controls)
            {
                Button btn = (Button)item;

                if (btn.Tag.ToString() == text.ToUpper())
                {
                    btn.BackColor = Color.Red;
                    btn.Text = btn.Tag.ToString();
                    IsExixt = true;
                }

            }

            return IsExixt;
        }
        void ShowWord(string text)
        {
            foreach (var item in flwButtonList.Controls)
            {
                Button btn = (Button)item;
                if (btn.Tag.ToString().ToUpper() == text.ToUpper())
                {
                    btn.BackColor = Color.Red;
                    btn.Text = btn.Tag.ToString().ToUpper();
                }
            }
        }
        void DoYouWantPlay()
        {
            DialogResult result = MessageBox.Show("TEKRAR OYNAMAK İSTERMİSİNİZ??", "UYARI", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                flwButtonList.Controls.Clear();
                GameStart();
            }
        }
        bool IsNulOrEmptyMessageBox(string text)
        {
            bool IsnullOrEmpty = false;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("BOŞ GEÇİLEMEZ!!!!");
                IsnullOrEmpty = true;
            }

            return IsnullOrEmpty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lettersAdd();
            AnswerAndQuestions();
            GameStart();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            flwButtonList.Controls.Clear();
            GameStart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            flwButtonList.Controls.Clear();
            GameStart();
        }

        private void txtGuessLetter_TextChanged(object sender, EventArgs e)
        {
            if (txtGuessLetter.TextLength >= 2)
            {
                DialogResult result = MessageBox.Show("1 Den Fazla Harf GİRİLEMEZ!!!"); MessageBox.Show("YENİDEN BAŞLAMAK İSTERMİSİNİZ!!!", "DİKKAT UYARI", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    txtGuessLetter.Text = string.Empty;
                }
            }
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            string answer = answers[selectedIndexQustion];
            string letter = txtGuessLetter.Text;
            IsNulOrEmptyMessageBox(letter);

            if (CheckGuessLetter(letter.ToUpper()))
            {
                if (GuessletterCounter(answer, letter) >= 2)
                {
                    score += 100;
                }
                else
                {
                    score += 250;
                }
                LifeCount--;
            }
            else
            {
                LifeCount--;
            }

            if (LifeCount == 0)
            {
                MessageBox.Show("SON ŞANS lÜTFEN KELİMEYİ TAHMİN EDİNİ");
            }


            lblHearts.Text = LifeCount.ToString();
            lblScore.Text = score.ToString();
            txtGuessLetter.Text = string.Empty;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string answer = answers[selectedIndexQustion];
            string word = txtGuessWord.Text;
            txtGuessWord.Text = string.Empty;
            IsNulOrEmptyMessageBox(word);

            if (answer.ToUpper() == word.ToUpper())
            {
                ShowWord(word);
                score += 300;
                lblScore.Text = score.ToString();
                lstGuessedWord.Items.Add(word.ToUpper());

                MessageBox.Show("Tebrikler Kazandınız");
                DoYouWantPlay();

            }
            else
            {
                LifeCount--;
                if (LifeCount == 0)
                {
                    MessageBox.Show("KAYBETİNİZ!!!");
                    DoYouWantPlay();
                }
            }

            lblHearts.Text = LifeCount.ToString();
        }
    }
}
