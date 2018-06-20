using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
namespace Simonsays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //serialPort1.Open();
        }

        int onInList = 0;
        List<int> pattern = new List<int>();    
        Random rand = new Random(); //de random knop die er wordt opgelicht wordt
        bool playingBack = false;

        //De nummers stellen tonen voor, Uit deze liedjes kan aan het begin van het spel gekozen worden. Na het liedje is het spel af.
        int[] lied1 = { 1, 2, 3, 1, 1, 2, 3, 1 };
        int[] lied2 = { 1, 1, 1, 0, 3, 1, 0, 3, 1 };
        int[] lied3 = { 4, 4, 5, 4, 5, 1, 3, 2, 2, 3, 5, 4 };
        int i;
        int[] array;

        private void playSimpleSound0()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\School\M\Jaar 2\S3\Proftaak\DedRubrics-master\Simonsays\sounds\C.wav");
            simpleSound.Play();
        }

        private void playSimpleSound1()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\School\M\Jaar 2\S3\Proftaak\DedRubrics-master\Simonsays\sounds\D.wav");
            simpleSound.Play();
        }

        private void playSimpleSound2()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\School\M\Jaar 2\S3\Proftaak\DedRubrics-master\Simonsays\sounds\E.wav");
            simpleSound.Play();
        }

        private void playSimpleSound3()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\School\M\Jaar 2\S3\Proftaak\DedRubrics-master\Simonsays\sounds\F.wav");
            simpleSound.Play();
        }

        private void playSimpleSound4()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\School\M\Jaar 2\S3\Proftaak\DedRubrics-master\Simonsays\sounds\G.wav");
            simpleSound.Play();
        }

        private void playSimpleSound5()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\School\M\Jaar 2\S3\Proftaak\DedRubrics-master\Simonsays\sounds\A.wav");
            simpleSound.Play();
        }





        // BUTTONS TESTCORRECT BUTTONS TESTCORRECT BUTTONS TESTCORRECT //

        private void Red_Click(object sender, EventArgs e)
        {
            if (pattern.Count == 0)
            {
                playSimpleSound0();
                Red.BackColor = Color.Red;
                Application.DoEvents();
                Thread.Sleep(500);
                Red.BackColor = Color.Transparent;
            }
            else
            {
                playSimpleSound0();
                testCorrect(0);
            }
            //als deze knop ingedrukt word geeft hij een een 0 door aan de functie testCorrect
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            if (pattern.Count == 0)
            {
                playSimpleSound1();
                Blue.BackColor = Color.Blue;
                Application.DoEvents();
                Thread.Sleep(500);
                Blue.BackColor = Color.Transparent;
            }
            else
            {
                playSimpleSound1();
                testCorrect(1);
            }
            //als deze knop ingedrukt word geeft hij een een 1 door aan de functie testCorrect
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            if (pattern.Count == 0)
            {
                playSimpleSound2();
                Yellow.BackColor = Color.Yellow;
                Application.DoEvents();
                Thread.Sleep(500);
                Yellow.BackColor = Color.Transparent;
            }
            else
            {
                playSimpleSound2();
                testCorrect(2);
            }
            //als deze knop ingedrukt word geeft hij een een 2 door aan de functie testCorrect
        }

        private void Green_Click(object sender, EventArgs e)
        {
            if (pattern.Count == 0)
            {
                playSimpleSound3();
                Green.BackColor = Color.Green;
                Application.DoEvents();
                Thread.Sleep(500);
                Green.BackColor = Color.Transparent;
            }
            else
            {
                playSimpleSound3();
                testCorrect(3);
            }
            //als deze knop ingedrukt word geeft hij een een 3 door aan de functie testCorrect
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            if (pattern.Count == 0)
            {
                playSimpleSound4();
                Purple.BackColor = Color.Purple;
                Application.DoEvents();
                Thread.Sleep(500);
                Purple.BackColor = Color.Transparent;
            }
            else
            {
                playSimpleSound4();
                testCorrect(4);
            }
            //als deze knop ingedrukt word geeft hij een een 4 door aan de functie testCorrect
        }

        private void Pink_Click(object sender, EventArgs e)
        {
            if (pattern.Count == 0)
            {
                playSimpleSound5();
                Pink.BackColor = Color.Pink;
                Application.DoEvents();
                Thread.Sleep(500);
                Pink.BackColor = Color.Transparent;
            }
            else
            {
                playSimpleSound5();
                testCorrect(5);
            }
            //als deze knop ingedrukt word geeft hij een een 5 door aan de functie testCorrect
        }



        void testCorrect(int color)
        {
            //voer de functie playingBack uit als deze aangeroept kan worden
            if (playingBack)
                return;
            //als de kleur(en) overeenkomt met de kleur(en) uit het array voeg er een aan toe.
            if (pattern[onInList] == color)
            {
                onInList++;
                if (onInList >= pattern.Count) //als de lijst groter is dan het huidige patroon pak het volgende nummer uit de array bij de lijst.
                {
                    int aLength = array.Length;
                    if (pattern.Count >= aLength)
                    {
                        //Je krijgt een message wanneer de reeks goed uitgevoerd is
                        MessageBox.Show("You won!");
                        pattern.Clear();
                        onInList = 0;
                        i = 0;
                    }
                    else
                    {
                        i++;
                        pattern.Add(array[i]);
                        onInList = 0;
                        Thread.Sleep(1000);
                        new Thread(playback).Start();
                    }
                }
            }
            else //als de kleur(en) niet overeenkomt terug naar nummer 1 uit de array
            {
                MessageBox.Show("Final Score: " + pattern.Count.ToString()); //geeft een messagebox weer die je final score zegt
                onInList = 0; //reset de lijst
                pattern = new List<int>();
                pattern.Clear();
                i = 0;
            }
            scorelabel.Text = ("Score: " + pattern.Count.ToString()); //laat de huidige score zien
            patternlabel.Text = ("Item within pattern: " + onInList.ToString()); //laat de huidige items in de reeks zien
        }



        void playback() //deze functie gebeurt als de computer de reeks laat zien die nagespeeld moet worden
        {
            playingBack = true;
            foreach(int color in pattern){ //voor elke kleur in de lijst doe een van de volgende cases
                switch (color)
                {
                    case 0: //knop 1
                        playSimpleSound0();
                        Red.BackColor = Color.Red;
                        Thread.Sleep(500);
                        Red.BackColor = Color.Transparent;
                        break;

                    case 1: //knop 2
                        playSimpleSound1();
                        Blue.BackColor = Color.Blue;
                        Thread.Sleep(500);
                        Blue.BackColor = Color.Transparent;
                        break;

                    case 2: //knop 3
                        playSimpleSound2();
                        Yellow.BackColor = Color.Yellow;
                        Thread.Sleep(500);
                        Yellow.BackColor = Color.Transparent;
                        break;

                    case 3: //knop 4
                        playSimpleSound3();
                        Green.BackColor = Color.Green;
                        Thread.Sleep(500);
                        Green.BackColor = Color.Transparent;
                        break;

                    case 4: //knop 5
                        playSimpleSound4();
                        Purple.BackColor = Color.Purple;
                        Thread.Sleep(500);
                        Purple.BackColor = Color.Transparent;
                        break;

                    case 5: //knop 6
                        playSimpleSound5();
                        Pink.BackColor = Color.Pink;
                        Thread.Sleep(500);
                        Pink.BackColor = Color.Transparent;
                        break;
                }
                Thread.Sleep(200); //wacht even voordat de volgende reeks wordt laten zien
            }
            playingBack = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void patternlabel_Click(object sender, EventArgs e)
        {

        }


        //kiezen van liedjes
        private void button1_Click(object sender, EventArgs e)
        {
            array = lied1;
            pattern.Add(array[i]); //voeg de eerste toon van het nummer toe
            new Thread(playback).Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            array = lied2;
            pattern.Add(array[i]); //voeg de eerste toon van het nummer toe
            new Thread(playback).Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            array = lied3;
            pattern.Add(array[i]); //voeg de eerste toon van het nummer toe
            new Thread(playback).Start();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
    }
}
