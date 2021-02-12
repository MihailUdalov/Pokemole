using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemole
{
    public partial class Form1 : Form
    {
        int j = 10;
        int i;
        int score = 0;
        bool end = true;
        bool banscore = false;
        bool soundoff = false;
        public Form1()
        {
            InitializeComponent();

        }
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        private void EndButton_Click(object sender, EventArgs e)
        {
            end = true;
            MessageBox.Show(
            "You score:" + score.ToString() + "\nDuring the:" + ((i / 60) / 60).ToString() + "::" + ((i / 60) / 60).ToString() + "::" + (i / 60).ToString() + "::" + (i % 60).ToString(),
            "Game Over",
            MessageBoxButtons.OK,
            MessageBoxIcon.None,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            Application.Exit();
            WMP.close();

        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            score = 0;
            moleTimer.Enabled = false;
            i = 0;
            TimeBox.Text = "0::0::0";
            ScoreBox.Text = score.ToString();
            Button[] pokemole = { mole0, mole1, mole2, mole3, mole4, mole5,button1,button10,button11,button12,button13,button14,
                    button15,button16,button17,button18,button2,button3,button4,button5,button6,button7,button8,button9 };
            for (int j = 0; j < 24; j++)
            {

                pokemole[j].Visible = true;
                banscore = false;
            }
            WMP.controls.stop();

        }
        private void moleTimer_Tick(object sender, EventArgs e)
        {
            double d;
            if (end == false)
            {
                if (moleTimer.Interval > 100)
                    if ((i / 60) == j)
                    {
                        moleTimer.Interval = moleTimer.Interval - 100;
                        j = j + 10;
                    }
                d = moleTimer.Interval;
                d = d / 1000 * 60;
                i = Convert.ToInt32(d) + i;
                TimeBox.Text = ((i / 60) / 60).ToString() + "::" + ((i / 60) / 60).ToString() + "::" + (i / 60).ToString() + "::" + (i % 60).ToString();
                Random rnd = new Random();
                int mole = rnd.Next(0, 23);
                Button[] pokemole = { mole0, mole1, mole2, mole3, mole4, mole5,button1,button10,button11,button12,button13,button14,
                    button15,button16,button17,button18,button2,button3,button4,button5,button6,button7,button8,button9 };
                for (int j = 0; j < 24; j++)
                {
                    pokemole[j].Visible = false;
                    if (mole == j)
                    {
                        pokemole[j].Visible = true;
                    }
                    banscore = true;
                }
                if (soundoff == true)
                    WMP.controls.pause();
                if (soundoff == false)
                    WMP.controls.play();
                ScoreBox.Text = score.ToString();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            moleTimer.Enabled = true;
            end = false;
            banscore = true;
            playSimpleSound();
        }
        private void moles_Click(object sender, EventArgs e)
        {
            Plusscore(ref banscore, ref score);
        }

        private void Plusscore(ref bool banscore, ref int score)
        {
            if (banscore == true)
            {
                score++;
                banscore = false;
            }
        }

        private void playSimpleSound()
        {
            WMP.URL = @"C:\Users\Михаил\Downloads\Les-Paul-Guitar-Boogie.mp3"; 
            WMP.settings.volume = 50; 
            WMP.controls.play();         
        }

        private void sound_Click(object sender, EventArgs e)
        {
            soundoff = !soundoff;
        }
    }
}
