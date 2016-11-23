using System;

namespace Project___Shaper
{
    class Program
    {
		/*
		 * Muslu.net
		 * M.Tayyip MUSLU
		*/
        static void Main(string[] args)
        {
            Random random = new Random(); Console.ForegroundColor = ConsoleColor.White;

            int probability1 = random.Next(0, 100); // horizontal or vertical situation

            int probability2 = random.Next(0, 100); /* %90 xx, %5 x0 and %5 0x sitiation.. */

            string command = "00"; // default command

            string c1 = " ", c2 = " ", c3 = " ", c4 = " ", c5 = " ", c6 = " ", c7 = " ", c8 = " ", c9 = " "; // computer's board location
            string u1 = " ", u2 = " ", u3 = " ", u4 = " ", u5 = " ", u6 = " ", u7 = " ", u8 = " ", u9 = " "; // user's board location
            string g1 = " ", g2 = " ";
            int raund = 1;
            // %50 probability of X for each location
            for (int i = 1; i <= 9; i++)
            {
                if (random.Next(0, 100) >= 50)
                {
                    if (i == 1) c1 = "X";
                    else if (i == 2) c2 = "X";
                    else if (i == 3) c3 = "X";
                    else if (i == 4) c4 = "X";
                    else if (i == 5) c5 = "X";
                    else if (i == 6) c6 = "X";
                    else if (i == 7) c7 = "X";
                    else if (i == 8) c8 = "X";
                    else if (i == 9) c9 = "X";
                }
            }
            int commandKont = 0, error = 0; // for controling command 41 and 42, and out of board situation
            while (true)
            {
                if (c1 == u1 && c2 == u2 && c3 == u3 && c4 == u4 && c5 == u5 && c6 == u6 && c7 == u7 && c8 == u8 && c9 == u9)
                { // if all computers section and all users section is equal, the game over
                    int score = 210 - 10 * raund;
                    raund = 30; // for exiting loop
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("+------------ FINAL ----------------+"); Console.ForegroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("  Computer's Board"); Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   User's Board  "); Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("     1  2  3         1  2  3   ");
                    Console.WriteLine("   +----------+   +-----------+");
                    Console.WriteLine(" 1 | " + c1 + "  " + c2 + "  " + c3 + "  |   |  " + u1 + "  " + u2 + "  " + u3 + "  |");
                    Console.WriteLine(" 2 | " + c4 + "  " + c5 + "  " + c6 + "  |   |  " + u4 + "  " + u5 + "  " + u6 + "  |");
                    Console.WriteLine(" 3 | " + c7 + "  " + c8 + "  " + c9 + "  |   |  " + u7 + "  " + u8 + "  " + u9 + "  |");
                    Console.WriteLine("   +----------+   +-----------+");
                    Console.WriteLine("Game is finished Your Score: " + score);
                    Console.Beep(1200, 220); Console.Beep(1200, 220); Console.Beep(1200, 220); Console.Beep(1200, 220); Console.Beep(1200, 220); Console.Beep(1200, 220);
                    break;
                }
                if (commandKont == 1 || error == 1)
                {// if command 41 or 42 used or ther are out of board situation
                    if (commandKont == 1) commandKont = 0;
                    if (error == 1) error = 0;
                }
                else
                {//if not create new probability.
                    probability1 = random.Next(0, 100);
                    probability2 = random.Next(0, 100);
                    if (probability2 >= 0 && probability2 < 5) { /* X0 Situation */ g1 = "X"; g2 = " "; }
                    else if (probability2 >= 5 && probability2 < 10) { /* 0X Situation */ g1 = " "; g2 = "X"; }
                    else { g1 = "X"; g2 = "X"; /* XX Situation */ }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("+------------ RAUND " + raund + " ----------------+"); Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("  Computer's Board"); Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("   User's Board  "); Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("     1  2  3         1  2  3   ");
                Console.Write("   +----------+   +-----------+");
                if (probability1 >= 0 && probability1 < 50) { /* if probabilty is vertical */ Console.WriteLine("   +---+"); }
                else { /* if probabilty is horizontal */Console.WriteLine("   +-----+"); }

                Console.Write(" 1 | " + c1 + "  " + c2 + "  " + c3 + "  |   |  " + u1 + "  " + u2 + "  " + u3 + "  |");

                if (probability1 >= 0 && probability1 < 50) { Console.WriteLine("   | " + g1 + " |"); }
                else { Console.WriteLine("   | " + g1 + " " + g2 + " |"); }

                Console.Write(" 2 | " + c4 + "  " + c5 + "  " + c6 + "  |   |  " + u4 + "  " + u5 + "  " + u6 + "  |");
                if (probability1 >= 0 && probability1 < 50) { Console.WriteLine("   | " + g2 + " |"); }
                else { Console.WriteLine("   +-----+"); }

                Console.Write(" 3 | " + c7 + "  " + c8 + "  " + c9 + "  |   |  " + u7 + "  " + u8 + "  " + u9 + "  |");
                if (probability1 >= 0 && probability1 < 50) { Console.WriteLine("   +---+"); }
                else { Console.WriteLine(); }
                Console.WriteLine("   +----------+   +-----------+");

                if (c1 == u1 && c2 == u2 && c3 == u3 && c4 == u4 && c5 == u5 && c6 == u6 && c7 == u7 && c8 == u8 && c9 == u9)
                { // if all computers section and all users section is same, the game is over
                }
                else
                {
                    Console.Write("Command : ");
                    command = Console.ReadLine();
                    if (command == "11")
                    {
                        Console.Beep(400, 300); Console.Beep(600, 200);
                        if (probability1 >= 0 && probability1 < 50) // this situation is vertical
                        {
                            //  user1. and user4. are procceed
                            if (g1 == "X") { if (u1 == "X") u1 = " "; else u1 = "X"; }
                            else { if (u1 == "X") u1 = "X"; else u1 = " "; }

                            if (g2 == "X")
                            {
                                if (u4 == "X") u4 = " ";
                                else u4 = "X";
                            }
                            else { if (u4 == "X") u4 = "X"; else u4 = " "; }
                        }
                        else // this situation is horizontal
                        {
                            if (g1 == "X") { if (u1 == "X") u1 = " "; else u1 = "X"; }
                            else { if (u1 == "X") u1 = "X"; else u1 = " "; }

                            if (g2 == "X") { if (u2 == "X") u2 = " "; else u2 = "X"; }
                            else { if (u2 == "X") u2 = "X"; else u2 = " "; }
                        }
                    }
                    else if (command == "21")
                    {
                        Console.Beep(400, 300); Console.Beep(600, 200);
                        if (probability1 >= 0 && probability1 < 50)
                        {
                            if (g1 == "X") { if (u4 == "X") u4 = " "; else u4 = "X"; }
                            else { if (u4 == "X") u4 = "X"; else u4 = " "; }

                            if (g2 == "X") { if (u7 == "X") u7 = " "; else u7 = "X"; }
                            else { if (u7 == "X") u7 = "X"; else u7 = " "; }
                        }
                        else
                        {
                            if (g1 == "X") { if (u4 == "X") u4 = " "; else u4 = "X"; }
                            else { if (u4 == "X") u4 = "X"; else u4 = " "; }

                            if (g2 == "X") { if (u5 == "X") u5 = " "; else u5 = "X"; }
                            else { if (u5 == "X") u5 = "X"; else u5 = " "; }
                        }
                    }
                    else if (command == "31")
                    {
                        if (probability1 >= 0 && probability1 < 50) { error = 1; /* out of board */ }
                        else
                        {
                            Console.Beep(400, 300); Console.Beep(600, 200);
                            if (g1 == "X") { if (u7 == "X") u7 = " "; else u7 = "X"; }
                            else { if (u7 == "X") u7 = "X"; else u7 = " "; }

                            if (g2 == "X") { if (u8 == "X") u8 = " "; else u8 = "X"; }
                            else { if (u8 == "X") u8 = "X"; else u8 = " "; }
                        }
                    }
                    else if (command == "12")
                    {
                        Console.Beep(400, 300); Console.Beep(600, 200);
                        if (probability1 >= 0 && probability1 < 50)
                        {
                            if (g1 == "X") { if (u2 == "X") u2 = " "; else u2 = "X"; }
                            else { if (u2 == "X") u2 = "X"; else u2 = " "; }

                            if (g2 == "X") { if (u5 == "X") u5 = " "; else u5 = "X"; }
                            else { if (u5 == "X") u5 = "X"; else u5 = " "; }
                        }
                        else
                        {
                            if (g1 == "X") { if (u2 == "X") u2 = " "; else u2 = "X"; }
                            else { if (u2 == "X") u2 = "X"; else u2 = " "; }

                            if (g2 == "X") { if (u3 == "X") u3 = " "; else u3 = "X"; }
                            else { if (u3 == "X") u3 = "X"; else u3 = " "; }
                        }
                    }
                    else if (command == "13")
                    {
                        if (probability1 >= 0 && probability1 < 50)
                        {
                            Console.Beep(400, 300); Console.Beep(600, 200);
                            if (g1 == "X") { if (u3 == "X") u3 = " "; else u3 = "X"; }
                            else { if (u3 == "X") u3 = "X"; else u3 = " "; }

                            if (g2 == "X") { if (u6 == "X") u6 = " "; else u6 = "X"; }
                            else { if (u6 == "X") u6 = "X"; else u6 = " "; }
                        }
                        else { error = 1; /* oob */ }
                    }
                    else if (command == "22")
                    {
                        Console.Beep(400, 300); Console.Beep(600, 200);
                        if (probability1 >= 0 && probability1 < 50)
                        {
                            if (g1 == "X") { if (u5 == "X") u5 = " "; else u5 = "X"; }
                            else { if (u5 == "X") u5 = "X"; else u5 = " "; }

                            if (g2 == "X") { if (u8 == "X") u8 = " "; else u8 = "X"; }
                            else { if (u8 == "X") u8 = "X"; else u8 = " "; }
                        }
                        else
                        {
                            if (g1 == "X") { if (u5 == "X") u5 = " "; else u5 = "X"; }
                            else { if (u5 == "X") u5 = "X"; else u5 = " "; }

                            if (g2 == "X") { if (u6 == "X") u6 = " "; else u6 = "X"; }
                            else { if (u6 == "X") u6 = "X"; else u6 = " "; }
                        }
                    }
                    else if (command == "23")
                    {
                        if (probability1 >= 0 && probability1 < 50)
                        {
                            Console.Beep(400, 300); Console.Beep(600, 200);
                            if (g1 == "X") { if (u6 == "X") u6 = " "; else u6 = "X"; }
                            else { if (u6 == "X") u6 = "X"; else u6 = " "; }

                            if (g2 == "X") { if (u9 == "X") u9 = " "; else u9 = "X"; }
                            else { if (u9 == "X") u9 = "X"; else u9 = " "; }
                        }
                        else { error = 1; /* oob */ }
                    }
                    else if (command == "32")
                    {
                        if (probability1 >= 0 && probability1 < 50) { error = 1; /* oob */ }
                        else
                        {
                            Console.Beep(400, 300); Console.Beep(600, 200);
                            if (g1 == "X") { if (u8 == "X") u8 = " "; else u8 = "X"; }
                            else { if (u8 == "X") u8 = "X"; else u8 = " "; }

                            if (g2 == "X") { if (u9 == "X") u9 = " "; else u9 = "X"; }
                            else { if (u9 == "X") u9 = "X"; else u9 = " "; }
                        }
                    }
                    else if (command == "33")
                    {
                        if (probability1 >= 0 && probability1 < 50) { error = 1; /* oob */ }
                        else { error = 1; /* oob */ }
                    }
                    else if (command == "41")
                    {
                        Console.Beep(1000, 200); Console.Beep(900, 200); Console.Beep(800, 200);
                        commandKont = 1; //for do not change probability
                        // rotate clockwise
                        if (probability1 >= 0 && probability1 < 50)
                        {
                            probability1 = 60; // rotate to horizontal
                                               /* 
                                                * vertical xx > horizontal xx
                                                * vertical x0 > horizontal 0x
                                                * vertical 0x > horizontal x0
                                                */
                            if (g1 == "X" && g2 == " ") { g1 = " "; g2 = "X"; }
                            else if (g1 == " " && g2 == "X") { g1 = "X"; g2 = " "; }
                            else { g1 = "X"; g2 = "X"; }
                        }
                        else
                        {
                            probability1 = 40; // rotate to vertical 
                                               /* horizontal x0 -> vertical x0
                                                * horizontal 0x -> vertical 0x
                                                * horizontal xx -> vertical xx
                                               */
                        }
                    }
                    else if (command == "42")
                    {
                        Console.Beep(800, 200); Console.Beep(900, 200); Console.Beep(1000, 200);
                        // rotate anticlockwise
                        commandKont = 1; //for do not change probability
                        if (probability1 >= 0 && probability1 < 50)
                        {
                            probability1 = 60; // rotate horizontal
                                               /* 
                                                * vertical xx -> horizontal xx
                                                * vertical x0 -> horizontal x0
                                                * vertical 0x -> horizontal 0x
                                                */
                        }
                        else
                        {
                            probability1 = 40; // dikey yaptık
                                               /* horizontal x0 -> vertical 0x
                                                * horizontal 0x -> vertical x0
                                                * horizontal xx -> vertical xx
                                               */
                            if (g1 == "X" && g2 == " ") { g1 = " "; g2 = "X"; }
                            else if (g1 == " " && g2 == "X") { g1 = "X"; g2 = " "; }
                            else { g1 = "X"; g2 = "X"; }
                        }
                    }
                    else
                    { // if press without undefined command
                        Console.Beep(500, 800);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("  ***** ERROR: Wrong Command Entered *****");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (error == 1) { Console.Beep(500, 800); Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("  ***** ERROR: Out of Board *****"); error = 0; Console.ForegroundColor = ConsoleColor.White; }
                }
                raund++;
            }
            if (raund == 30)
            {
                Console.Write("Press any key for closing game...");
            }
            else if (raund > 20 && raund < 30)
            {
                Console.WriteLine("  ***** ERROR: You could'nt finish game! *****");
            }
            Console.ReadKey();
        }
    }
}