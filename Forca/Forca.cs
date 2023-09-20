using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forca
{
    public partial class Forca : Form
    {
        #region "Constructor"
        public Forca()
        {
            InitializeComponent();
        }
        #endregion

        #region "variables"
        public List<string> lstWords;
        string word;
        string tip;
        string won;
        Random rnd = new Random();
        int randomNumber;
        int erro = 0;
        #endregion

        #region "Methods"

        #region "StartingGame()"
        public void StartingGame()
        {
            try
            {
                Clear();
                FinishingGame(true);
                SettingRandomTypeOfWords();
                randomNumber = rnd.Next(0, lstWords.Count);
                word = lstWords.ElementAtOrDefault(randomNumber);
                for (int i = 1; i <= word.Length; i++)
                {
                    ShowSpace(i);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "FinishingGame"
        public void FinishingGame(bool status)
        {
            btnA.Enabled = status;
            btnB.Enabled = status;
            btnC.Enabled = status;
            btnD.Enabled = status;
            btnE.Enabled = status;
            btnF.Enabled = status;
            btnG.Enabled = status;
            btnH.Enabled = status;
            btnI.Enabled = status;
            btnJ.Enabled = status;
            btnK.Enabled = status;
            btnL.Enabled = status;
            btnM.Enabled = status;
            btnN.Enabled = status;
            btnO.Enabled = status;
            btnP.Enabled = status;
            btnQ.Enabled = status;
            btnR.Enabled = status;
            btnS.Enabled = status;
            btnT.Enabled = status;
            btnU.Enabled = status;
            btnV.Enabled = status;
            btnW.Enabled = status;
            btnX.Enabled = status;
            btnY.Enabled = status;
            btnZ.Enabled = status;
            btnAnswer.Visible = !status;
        }
        #endregion

        #region "ShowLetter"
        public void ShowLetter(int buttonNumber, string letter)
        {
            switch (buttonNumber)
            {
                case 1:
                    btnWord1.Text = letter;
                    break;
                case 2:
                    btnWord2.Text = letter;
                    break;
                case 3:
                    btnWord3.Text = letter;
                    break;
                case 4:
                    btnWord4.Text = letter;
                    break;
                case 5:
                    btnWord5.Text = letter;
                    break;
                case 6:
                    btnWord6.Text = letter;
                    break;
                case 7:
                    btnWord7.Text = letter;
                    break;
                case 8:
                    btnWord8.Text = letter;
                    break;
                case 9:
                    btnWord9.Text = letter;
                    break;
                case 10:
                    btnWord10.Text = letter;
                    break;
                case 11:
                    btnWord11.Text = letter;
                    break;
                case 12:
                    btnWord12.Text = letter;
                    break;
                case 13:
                    btnWord13.Text = letter;
                    break;
                case 14:
                    btnWord14.Text = letter;
                    break;
                case 15:
                    btnWord15.Text = letter;
                    break;
                case 16:
                    btnWord16.Text = letter;
                    break;
                case 17:
                    btnWord17.Text = letter;
                    break;
                case 18:
                    btnWord18.Text = letter;
                    break;
            }
        }
        #endregion

        #region "ShowError"
        public void ShowError(int cont)
        {
            switch (cont)
            {
                case 1:
                    picErrorImage1.Visible = true;
                    picErrorImage1.Image = picErrorImage0.Image;
                    break;
                case 2:
                    picErrorImage2.Visible = true;
                    break;
                case 3:
                    picErrorImage3.Visible = true;
                    break;
                case 4:
                    picErrorImage4.Visible = true;
                    break;
                case 5:
                    picErrorImage5.Visible = true;
                    break;
                case 6:
                    picErrorImage6.Visible = true;
                    picErrorImage1.Image = picErrorImage7.Image;
                    break;
            }
        }
        #endregion

        #region "ShowSpace"
        public void ShowSpace(int spaceNumber)
        {
            switch (spaceNumber)
            {
                case 1:
                    btnWord1.Visible = true;
                    break;
                case 2:
                    btnWord2.Visible = true;
                    break;
                case 3:
                    btnWord3.Visible = true;
                    break;
                case 4:
                    btnWord4.Visible = true;
                    break;
                case 5:
                    btnWord5.Visible = true;
                    break;
                case 6:
                    btnWord6.Visible = true;
                    break;
                case 7:
                    btnWord7.Visible = true;
                    break;
                case 8:
                    btnWord8.Visible = true;
                    break;
                case 9:
                    btnWord9.Visible = true;
                    break;
                case 10:
                    btnWord10.Visible = true;
                    break;
                case 11:
                    btnWord11.Visible = true;
                    break;
                case 12:
                    btnWord12.Visible = true;
                    break;
                case 13:
                    btnWord13.Visible = true;
                    break;
                case 14:
                    btnWord14.Visible = true;
                    break;
                case 15:
                    btnWord15.Visible = true;
                    break;
                case 16:
                    btnWord16.Visible = true;
                    break;
                case 17:
                    btnWord17.Visible = true;
                    break;
                case 18:
                    btnWord18.Visible = true;
                    break;
            }
        }
        #endregion

        #region "SettingRandomTypeOfWords"
        public void SettingRandomTypeOfWords()
        {
            try
            {
                randomNumber = rnd.Next(1, 7);

                switch (randomNumber)
                {
                    case 1:
                        tip = "É uma fruta!";
                        lstWords = new List<string>() {"MANGA","MORANGO","ABACAXI","UMBU","JACA","MARACUJA","MANGOSTIM","CEREJA","PESSEGO",
                            "TAMARINDO","MELANCIA","JABOTICABA","SIRIGUELA","CAQUI","PINHA","PITAYA","ATEMOIA","LICHIA","TANGERINA","ABACATE"};
                        break;
                    case 2:
                        tip = "É um tipo de carro!";
                        lstWords = new List<string>() {"GOL","VECTRA","KADETT","ONIX","SANDERO","CORSA","COROLLA","CIVIC","MERIVA","DOBLO","CELTA",
                            "FUSCA","FUSION","COMBI","FIORINO","CAPTIVA","PUNTO","SIENA","LOGAN","FIESTA","ETIOS","PRISMA","VOYAGE","VERSA","COBALT"};
                        break;
                    case 3:
                        tip = "É um nome de um país!";
                        lstWords = new List<string>() {"BRASIL","CHILE","RUSSIA","ARGENTINA","INGLATERRA","HOLANDA","INDIA","VENEZUELA","AFRICA",
                            "MEXICO","BOLIVIA","BELGICA","ANDORRA","ANGOLA","CATAR","DINAMARCA","EGITO","EQUADOR","PERU","ESPANHA","HONDURAS","ISRAEL"};
                        break;
                    case 4:
                        tip = "É uma banda de rock!";
                        lstWords = new List<string>() {"SLIPKNOT","KORN","METALLICA","PARAMORE","AUDIOSLAVE","SEPULTURA","SLAYER","VIOLATOR","LAMBOFGOD",
                            "TORTURE_SQUAD","ALL_THAT_REMAINS","LINKIN_PARK","CHARLIE_BROWN_JR","CAPITAL_INICIAL","FOO_FIGHTERS","LIMP_BIZKIT","NICKEL_BACK"};
                        break;
                    case 5:
                        tip = "Foi presidente do Brasil!";
                        lstWords = new List<string>() {"DEODORO_DA_FONSECA","FLORIANO_PEIXOTO","PRUDENTE_DE_MORAIS","CAMPOS_SALES","RODRIGUES_ALVES",
                            "AFFONSO_PENA","MICHEL_TEMER","DILMA_ROUSSEFF","FERNANDO_HENRIQUE","ITAMAR_FRANCO","FERNANDO_COLLOR","JOSE_SARNEY",
                            "TANCREDO_NEVES","ERNESTO_GEISEL"};
                        break;
                    case 6:
                        tip = "Nome de um time de futebol!";
                        lstWords = new List<string>() {"PALMEIRAS","SAOPAULO","INTERNACIONAL","BARCELONA","REALMADRI","CORINTHIANS","ARSENAL",
                            "MANCHESTER_CITY","MANCHESTER_UNITED","BOCA_JUNIOR","SANTOS","CHAPECOENSE","FLAMENGO","VASCO","BAHIA","CHELSE","LIVERPOOL"};
                        break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "CheckingIfUserWon"
        public bool CheckingIfUserWon(int randomNumber)
        {
            for (int i = 1; i <= randomNumber; i++)
            {
                switch (i)
                {
                    case 1:
                        won += btnWord1.Text;
                        break;
                    case 2:
                        won += btnWord2.Text;
                        break;
                    case 3:
                        won += btnWord3.Text;
                        break;
                    case 4:
                        won += btnWord4.Text;
                        break;
                    case 5:
                        won += btnWord5.Text;
                        break;
                    case 6:
                        won += btnWord6.Text;
                        break;
                    case 7:
                        won += btnWord7.Text;
                        break;
                    case 8:
                        won += btnWord8.Text;
                        break;
                    case 9:
                        won += btnWord9.Text;
                        break;
                    case 10:
                        won += btnWord10.Text;
                        break;
                    case 11:
                        won += btnWord11.Text;
                        break;
                    case 12:
                        won += btnWord12.Text;
                        break;
                    case 13:
                        won += btnWord13.Text;
                        break;
                    case 14:
                        won += btnWord14.Text;
                        break;
                    case 15:
                        won += btnWord15.Text;
                        break;
                    case 16:
                        won += btnWord16.Text;
                        break;
                    case 17:
                        won += btnWord17.Text;
                        break;
                    case 18:
                        won += btnWord18.Text;
                        break;
                }
            }
            if (won.Equals(word))
            {
                return true;
            }
            else
            {
                won = "";
                return false;
            }
        }
        #endregion

        #region "Clear"
        public void Clear()
        {
            try
            {
                btnWord1.Text = "_";
                btnWord2.Text = "_";
                btnWord3.Text = "_";
                btnWord4.Text = "_";
                btnWord5.Text = "_";
                btnWord6.Text = "_";
                btnWord7.Text = "_";
                btnWord8.Text = "_";
                btnWord9.Text = "_";
                btnWord10.Text = "_";
                btnWord11.Text = "_";
                btnWord12.Text = "_";
                btnWord13.Text = "_";
                btnWord14.Text = "_";
                btnWord15.Text = "_";
                btnWord16.Text = "_";
                btnWord17.Text = "_";
                btnWord18.Text = "_";

                btnWord1.Visible = false;
                btnWord2.Visible = false;
                btnWord3.Visible = false;
                btnWord4.Visible = false;
                btnWord5.Visible = false;
                btnWord6.Visible = false;
                btnWord7.Visible = false;
                btnWord8.Visible = false;
                btnWord9.Visible = false;
                btnWord10.Visible = false;
                btnWord11.Visible = false;
                btnWord12.Visible = false;
                btnWord13.Visible = false;
                btnWord14.Visible = false;
                btnWord15.Visible = false;
                btnWord16.Visible = false;
                btnWord17.Visible = false;
                btnWord18.Visible = false;

                picErrorImage1.Visible = false;
                picErrorImage2.Visible = false;
                picErrorImage3.Visible = false;
                picErrorImage4.Visible = false;
                picErrorImage5.Visible = false;
                picErrorImage6.Visible = false;
                picErrorImage7.Visible = false;

                erro = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion

        #region "Events"

        #region "Form1_Load"
        private void Form1_Load(object sender, EventArgs e)
        {
            StartingGame();
        }
        #endregion

        #region "btnNewGame_Click"
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
                StartingGame();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnFinish_Click"
        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Form1_FormClosing"
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        #endregion

        #region "btnAnswer_Click"
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A resposta é {word}!");
        }
        #endregion

        #region "btnA_Click"
        private void btnA_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'A';
                btnA.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnB_Click"
        private void btnB_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'B';
                btnB.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnC_Click"
        private void btnC_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'C';
                btnC.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnD_Click"
        private void btnD_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'D';
                btnD.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnE_Click"
        private void btnE_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'E';
                btnE.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnF_Click"
        private void btnF_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'F';
                btnF.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnG_Click"
        private void btnG_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'G';
                btnG.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnH_Click"
        private void btnH_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'H';
                btnH.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnI_Click"
        private void btnI_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'I';
                btnI.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnJ_Click"
        private void btnJ_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'J';
                btnJ.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnK_Click"
        private void btnK_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'K';
                btnK.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnL_Click"
        private void btnL_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'L';
                btnL.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnM_Click"
        private void btnM_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'M';
                btnM.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnN_Click"
        private void btnN_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'N';
                btnN.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnO_Click"
        private void btnO_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'O';
                btnO.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnP_Click"
        private void btnP_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'P';
                btnP.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnQ_Click"
        private void btnQ_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'Q';
                btnQ.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnR_Click"
        private void btnR_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'R';
                btnR.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnS_Click"
        private void btnS_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'S';
                btnS.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnT_Click"
        private void btnT_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'T';
                btnT.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnU_Click"
        private void btnU_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'U';
                btnU.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnV_Click"
        private void btnV_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'V';
                btnV.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnW_Click"
        private void btnW_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'W';
                btnW.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnX_Click"
        private void btnX_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'X';
                btnX.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnY_Click"
        private void btnY_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'Y';
                btnY.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnZ_Click"
        private void btnZ_Click(object sender, EventArgs e)
        {
            try
            {
                char letter = 'Z';
                btnZ.Enabled = false;
                if (word.Contains(letter))
                {
                    int cont = 0;
                    foreach (char item in word)
                    {
                        cont++;
                        if (item.Equals(letter))
                        {
                            ShowLetter(cont, letter.ToString());
                        }
                    }
                    if (CheckingIfUserWon(word.Length))
                    {
                        if (MessageBox.Show("Parabens!! \nVocê acertou a palavra! \nDeseja iniciar uma nova partida?", "Confirm",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
                else
                {
                    erro++;
                    ShowError(erro);
                    if (erro >= 6)
                    {
                        if (MessageBox.Show("Fim de jogo! \nDeseja iniciar uma nova partida ? ", "Confirm",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            StartingGame();
                        else
                            FinishingGame(false);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "btnTip_Click"
        private void btnTip_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(tip);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #endregion
    }
}
