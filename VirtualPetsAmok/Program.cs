using System;
using System.Collections.Generic;
using System.Threading;

namespace VirtualPetsAmok
{
    class Program
    {
        static void Main(string[] args)
        {
            TitleScreen();
            //Console.WriteLine("uncomment title screen");
            //Console.ReadKey();
            MainMenu();
        }

        static void MainMenu()
        {
            PetShelter myShelter = new PetShelter();
            bool run = true;

            do
            {
                Console.Clear();
                myShelter.TimeEffectAll();

                Console.WriteLine("Main Menu:");
                Console.WriteLine("Press 1 to Create a Pet");

                if (myShelter.PetsList.Count > 0)
                {

                    Console.WriteLine("Press 2 to Display Pets' Information");
                    Console.WriteLine("Press 3 to Display Pets' Stats");
                    Console.WriteLine("Press 4 to Interact with Pets");
                    Console.WriteLine("Press 5 to Remove a Pet");
                }
                Console.WriteLine("Press 0 to Quit");

                ConsoleKeyInfo keyPressed = Console.ReadKey();

                string menuChoice;

                if (char.IsDigit(keyPressed.KeyChar))
                {

                    menuChoice = keyPressed.KeyChar.ToString();
                }
                else
                {
                    menuChoice = "default";
                }

                if (!menuChoice.Equals("1") && !menuChoice.Equals("0") && myShelter.PetsList.Count == 0)
                {
                    menuChoice = "-1";
                }

                switch (menuChoice)
                {
                    case "0":
                        Console.WriteLine("\nSee you next time, friend.");
                        run =  false;
                        break;
                    case "1":
                        Console.WriteLine("\n\nPet Creation:");
                        myShelter.CreateNewPet();
                        break;
                    case "2":
                        myShelter.DisplayAllPetsInfo();
                        break;
                    case "3":
                        myShelter.DisplayAllPetsStats();
                        break;
                    case "4":
                        myShelter.InteractionMenu();
                        break;
                    case "5":
                        myShelter.RemovePet();
                        break;
                    default:
                        Console.WriteLine("\nIncorrect entry. Try again.");
                        Console.WriteLine("\nPress ANY KEY to continue");
                        Console.ReadKey();
                        break;
                }

            } while (run);
        }

        static void TitleScreen()
        {
            List<string> title = new List<string>();

            title.Add("omNNNNNNNm`  sNNNd.mNNNNNNNN//NMMMMMMMMMMNmho.  :NNNNNNNNNNNNNNNNh+NNNNNNNN:  +NNNNNN.    dNNNNNNNy    `mNNNNNNNN/     ");
            title.Add(" mMMMMMMMM: `NMMM/`MMMMMMMMM::MMMMMMMMMMMMMMMMs`-MMMMMMMMMMMMMMMMh+MMMMMMMM:  /MMMMMM.   :MMMMMMMMM.    NMMMMMMMM:     ");
            title.Add(" :MMMMMMMMy +MMMy  NMMMMMMMM--MMMMMMMMMMMMMMMMMy.MMMMMMMMMMMMMMMMy:MMMMMMMM-  :MMMMMM`   yMMMMMMMMMo    dMMMMMMMM-     ");
            title.Add("  sMMMMMMMM-mMMN`  mMMMMMMMM..MMMMMMMMMMMMMMMMMN`MMMMMMMMMMMMMMMMo-MMMMMMMM-  .MMMMMN`  `NMMMMMMMMMm`   hMMMMMMMM.     ");
            title.Add("  `mMMMMMMMNMMM/   hMMMMMMMM `NMMMMMMMd/omMMMMMN`:::-dMMMMMMM+-::.`NMMMMMMM-  `MMMMMN   +MMMMMMMMMMM/   sMMMMMMMM`     ");
            title.Add("   :MMMMMMMMMMh    yMMMMMMMN  NMMMMMMMs  :MMMMM+     yMMMMMMM.     dMMMMMMM-  `NMMMMm   mMMMMMMMMMMMd   oMMMMMMMN      ");
            title.Add("    hMMMMMMMMN.    sMMMMMMMm  mMMMMMMMh/omMMMm/      oMMMMMMM`     sMMMMMMM-   NMMMMd  /MMMM/mMMMMMMM:  +MMMMMMMm      ");
            title.Add("    .NMMMMMMMo     oMMMMMMMd  dMMMMMMMMMMMMm:        +MMMMMMN      :MMMMMMM:   NMMMMd  dMMMo .NMMMMMMh  /MMMMMMMd      ");
            title.Add("     oMMMMMMm`     +MMMMMMMh  hMMMMMMMhNMMMMd-       /MMMMMMd       yMMMMMMy   mMMMMd :MMMN--/dMMMMMMM- :MMMMMMMh ``.-`");
            title.Add("     `mMMMMM/      :MMMMMMMy  sMMMMMMM/:NMMMMMs.     -MMMMMMh        sMMMMMMmyhMMMMMd dMMMhMMMNMMMMMMMy -MMMMMMMMMMMMm ");
            title.Add("      :ddddy       -ddddddd+  /ddddddd- .hMMmy+.     .dddddd+         .ohmMMMMMMMNmh+.dddy yy:`+ddddddh`.dddddddddddd/ ");
            title.Add(" ");
            title.Add("                     /MMMMMMMMMMNmh+.   +NNNNNNNNNNNNNm`dNNNNNNNNNNNNNNNm. :ymMMMMMMMMy  /NNNNNNNy");
            title.Add("                     :MMMMMMMMMMMMMMNy` /MMMMMMMMMMMMMm mMMMMMMMMMMMMMMMM.oMMMMMMMMMMMd  .MMMMMMM:");
            title.Add("                     .MMMMMMMMMMMMMMMMd`-MMMMMMMMMMMMMh hMMMMMMMMMMMMMMMN-MMMMMMMMMMMMm   hMMMMMm ");
            title.Add("                     `MMMMMMMMMMMMMMMMM/.MMMMMMMMMMMMMs yMMMMMMMMMMMMMMMm.MMMMMMMMMMMMN   /MMMMMo ");
            title.Add("                      NMMMMMMMy-:hMMMMMo`MMMMMMMMy-://- -::-oMMMMMMMh-::: oMMMMMMMMN+-/   `NMMMM. ");
            title.Add("                      mMMMMMMMo  :MMMMM- NMMMMMMMhoooo.     :MMMMMMMo      :dMMMMMMm`      hMMMh  ");
            title.Add("                      dMMMMMMMs-+mMMMM+  NMMMMMMMMMMMN`     .MMMMMMM+        -yMMMMMd`     /MMM/  ");
            title.Add("                      hMMMMMMMMMMMMNy.   mMMMMMMMs//+/      `NMMMMMM:          :MMMMMh     `hys`        A    M     M  OO  K K");
            title.Add("                      yMMMMMMMhys+-`     dMMMMMMM:```..      NMMMMMM-       /::sMMMMMN`    -+o/.       A A   MM   MM O  O KK");
            title.Add("                      sMMMMMMM:          hMMMMMMMMMMMM+      mMMMMMM`       yMMMMMMMN/    yMMMMM:     AAAAA  M M M M O  O K K");
            title.Add("                      /ddddddd.          odddddddddddh`      sdddddh        -dmmmdh+.     /mMMMh.    A     A M  M  M  OO  K  K");

            string credits = "Created By Team MVP: Alex Albright, Sabrina Andrews, Mary McGeary, and Carlos Brown";
            Random randomNum = new Random();

            Console.Clear();

            // Scrolling Title
            for (int frame = 0; frame < title.Count * 2 + 1; frame++)
            {

                for (int lineHead = frame; lineHead < title.Count; lineHead++)
                {
                    Console.WriteLine("");
                }
                if (frame < title.Count)
                {
                    for (int lineBody = 0; lineBody < frame; lineBody++)
                    {

                        Console.WriteLine(title[lineBody]);
                    }
                }
                else
                {
                    for (int lineBody = frame - title.Count; lineBody < title.Count; lineBody++)
                    {
                        Console.WriteLine(title[lineBody]);
                    }
                }
                for (int lineFoot = title.Count; lineFoot < frame; lineFoot++)
                {
                    if (lineFoot == title.Count + ((title.Count - (title.Count % 2)) / 2))
                    {
                        Console.WriteLine(credits);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }

                if (frame == title.Count)
                {
                    Thread.Sleep(2000);
                }
                else if (frame == title.Count * 2)
                {
                    Thread.Sleep(2000);
                }
                else
                {
                    Thread.Sleep(50);
                }

                Console.Clear();
            }

            // Erase credits
            for (int frame = credits.Length; frame > 0; frame--)
            {
                for (int lineHead = 0; lineHead < 11; lineHead++)
                {
                    Console.WriteLine("");
                }

                int maxLimit = credits.Length - 1;
                int minLimit = frame - 1;
                int letter = randomNum.Next(0, maxLimit);

                credits = credits.Replace(credits[letter], ' ');
                credits = credits.Replace(credits[minLimit], ' ');
                Console.WriteLine(credits);

                if (frame != 1)
                {
                    Thread.Sleep(10);
                }
                else
                {
                    Thread.Sleep(500);
                }

                Console.Clear();
            }
        }
    }
}
