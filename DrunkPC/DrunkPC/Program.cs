using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
 

//Application Name: DrunkPC
//Made By Ben Piecora 9/18/2016
//Copyright Ben's Tech Garage 2016

namespace DrunkPC
{
    class Program
    {
        public static Random _random = new Random();
        static void Main(string[] args)
        {
            Thread drunkMouseThread = new Thread(new ThreadStart(DrunkMouseThread));
            Thread drunkKeyboardThread = new Thread(new ThreadStart(DrunkKeyboardThread));
            Thread drunkSoundThread = new Thread(new ThreadStart(DrunkSoundThread));
            Thread drunkPopupThead = new Thread(new ThreadStart(DrunkPopupThread));

            drunkMouseThread.Start();
            drunkKeyboardThread.Start();
            drunkSoundThread.Start();
            drunkPopupThead.Start();
        }
        public static void DrunkMouseThread()
        {
            int LastPosX = Cursor.Position.X;
            int LastPosY = Cursor.Position.Y;

            while (true)
            {
                LastPosX = Cursor.Position.X;
                LastPosY = Cursor.Position.Y;

                if (Cursor.Position.X != LastPosX || Cursor.Position.Y != LastPosY)
                {
                    int RX = _random.Next(-15, 15);
                    int RY = _random.Next(-15, 15);
                    Cursor.Position = new System.Drawing.Point(Cursor.Position.X + RX, Cursor.Position.Y + RY);
                    
                }
            }
        }
        public static void DrunkKeyboardThread()
        {
            while (true)
            {
                if (_random.Next(100) > 75)
                {
                    char key = (char)(_random.Next(25) + 65);
                    if (_random.Next(2) == 0)
                    {
                        key = Char.ToLower(key);
                    }

                    SendKeys.SendWait(key.ToString());
                }

                Thread.Sleep(_random.Next(500));
            }

        }
        public static void DrunkSoundThread()
        {
            while (true)
            {
                if (_random.Next(100) > 80)
                {
                    switch (_random.Next(5))
                    {

                        case 0:
                            SystemSounds.Asterisk.Play();
                            break;
                        case 1:
                            SystemSounds.Beep.Play();
                            break;
                        case 2:
                            SystemSounds.Exclamation.Play();
                            break;
                        case 3:
                            SystemSounds.Hand.Play();
                            break;
                        case 4:
                            SystemSounds.Question.Play();
                            break;

                    }

                }
                Thread.Sleep(1000);
            }

        }
        public static void DrunkPopupThread()
        {
            while (true)
            {
                if (_random.Next(100) > 50)
                {
                    switch (_random.Next(4))
                    {
                        case 0:
                            MessageBox.Show("Error: Insufficient Memory 0xGFKYS", "Insufficient Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 1:
                            MessageBox.Show("Your Computer has been infected by a virus!", "Norton 360 Antivirus Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            break;
                        case 2:
                            MessageBox.Show("Your Computer is sending error reports to the Main Microsoft Server! Please call Technical Support at 1(800)GOFUCKYOURSELF", "Microsoft Error Reporting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case 3:
                            MessageBox.Show("Error: Insufficient Memory 0xGFKYS", "Insufficient Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(1000);
                            MessageBox.Show("Your Computer has been infected by a virus!", "Norton 360 Antivirus Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Thread.Sleep(5000);
                            MessageBox.Show("Your Computer has been infected by a virus!", "Norton 360 Antivirus Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Thread.Sleep(6000);
                            MessageBox.Show("Your Computer has been infected by a virus!", "Norton 360 Antivirus Software", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Thread.Sleep(7000);
                            MessageBox.Show("Error: Insufficient Memory 0xGFKYS", "Insufficient Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(500);
                            MessageBox.Show("Error: Insufficient Memory 0xGFKYS", "Insufficient Memory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("Error: Too Many Errors", "Too Many Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Thread.Sleep(100);
                            MessageBox.Show("You're computer is about to explode!", "Going to Explode", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            MessageBox.Show("You're computer is going to explode in 5 seconds!", "Going to Explode", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            MessageBox.Show("You're computer is going to explode in 5 seconds!", "Going to Explode", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            MessageBox.Show("You're computer is going to explode in 5 seconds!", "Going to Explode", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            MessageBox.Show("You're computer is going to explode in 5 seconds!", "Going to Explode", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            MessageBox.Show("You're computer is going to explode in 5 seconds!", "Going to Explode", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            

                            break;

                    }

                    Thread.Sleep(500);
                }

            }

        }
    }
}
