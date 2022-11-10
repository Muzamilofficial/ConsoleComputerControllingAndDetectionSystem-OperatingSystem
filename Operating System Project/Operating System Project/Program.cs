using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Management;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace OperatingSystemProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignLogo.yes();
            Console.ReadKey();
            Console.Clear();
            TitlePage.yes();
            Console.ReadKey();
            Console.Clear();
            END.yes();
            Console.ReadKey();
            
            
        }
    }
    class END
    {
        static public void yes()
        {
            Console.WriteLine(@"
████████╗██╗░░██╗░█████╗░███╗░░██╗██╗░░██╗  ██╗░░░██╗░█████╗░██╗░░░██╗░░░░░░░░░░░░
╚══██╔══╝██║░░██║██╔══██╗████╗░██║██║░██╔╝  ╚██╗░██╔╝██╔══██╗██║░░░██║░░░░░░░░░░░░
░░░██║░░░███████║███████║██╔██╗██║█████═╝░  ░╚████╔╝░██║░░██║██║░░░██║░░░░░░░░░░░░
░░░██║░░░██╔══██║██╔══██║██║╚████║██╔═██╗░  ░░╚██╔╝░░██║░░██║██║░░░██║░░░░░░░░░░░░
░░░██║░░░██║░░██║██║░░██║██║░╚███║██║░╚██╗  ░░░██║░░░╚█████╔╝╚██████╔╝██╗██╗██╗██╗
░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝  ░░░╚═╝░░░░╚════╝░░╚═════╝░╚═╝╚═╝╚═╝╚═╝");
        }
    }
   class DesignLogo
    {
        static public void yes()
        {
            Console.WriteLine(@"

░█████╗░░█████╗░███╗░░██╗░██████╗░█████╗░██╗░░░░░███████╗
██╔══██╗██╔══██╗████╗░██║██╔════╝██╔══██╗██║░░░░░██╔════╝
██║░░╚═╝██║░░██║██╔██╗██║╚█████╗░██║░░██║██║░░░░░█████╗░░
██║░░██╗██║░░██║██║╚████║░╚═══██╗██║░░██║██║░░░░░██╔══╝░░
╚█████╔╝╚█████╔╝██║░╚███║██████╔╝╚█████╔╝███████╗███████╗
░╚════╝░░╚════╝░╚═╝░░╚══╝╚═════╝░░╚════╝░╚══════╝╚══════╝

░█████╗░██████╗░███████╗██████╗░░█████╗░████████╗███████╗██████╗░
██╔══██╗██╔══██╗██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔════╝██╔══██╗
██║░░██║██████╔╝█████╗░░██████╔╝███████║░░░██║░░░█████╗░░██║░░██║
██║░░██║██╔═══╝░██╔══╝░░██╔══██╗██╔══██║░░░██║░░░██╔══╝░░██║░░██║
╚█████╔╝██║░░░░░███████╗██║░░██║██║░░██║░░░██║░░░███████╗██████╔╝
░╚════╝░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝╚═════╝░

░█████╗░░█████╗░███╗░░░███╗██████╗░██╗░░░██╗████████╗███████╗██████╗░
██╔══██╗██╔══██╗████╗░████║██╔══██╗██║░░░██║╚══██╔══╝██╔════╝██╔══██╗
██║░░╚═╝██║░░██║██╔████╔██║██████╔╝██║░░░██║░░░██║░░░█████╗░░██████╔╝
██║░░██╗██║░░██║██║╚██╔╝██║██╔═══╝░██║░░░██║░░░██║░░░██╔══╝░░██╔══██╗
╚█████╔╝╚█████╔╝██║░╚═╝░██║██║░░░░░╚██████╔╝░░░██║░░░███████╗██║░░██║
░╚════╝░░╚════╝░╚═╝░░░░░╚═╝╚═╝░░░░░░╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝

░█████╗░░█████╗░███╗░░██╗████████╗██████╗░░█████╗░██╗░░░░░██╗░░░░░██╗███╗░░██╗░██████╗░  ░█████╗░███╗░░██╗██████╗░
██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░██║░░░░░██║████╗░██║██╔════╝░  ██╔══██╗████╗░██║██╔══██╗
██║░░╚═╝██║░░██║██╔██╗██║░░░██║░░░██████╔╝██║░░██║██║░░░░░██║░░░░░██║██╔██╗██║██║░░██╗░  ███████║██╔██╗██║██║░░██║
██║░░██╗██║░░██║██║╚████║░░░██║░░░██╔══██╗██║░░██║██║░░░░░██║░░░░░██║██║╚████║██║░░╚██╗  ██╔══██║██║╚████║██║░░██║
╚█████╔╝╚█████╔╝██║░╚███║░░░██║░░░██║░░██║╚█████╔╝███████╗███████╗██║██║░╚███║╚██████╔╝  ██║░░██║██║░╚███║██████╔╝
░╚════╝░░╚════╝░╚═╝░░╚══╝░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░╚══════╝╚══════╝╚═╝╚═╝░░╚══╝░╚═════╝░  ╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░

██████╗░███████╗████████╗░█████╗░██╗██╗░░░░░░██████╗
██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██║██║░░░░░██╔════╝
██║░░██║█████╗░░░░░██║░░░███████║██║██║░░░░░╚█████╗░
██║░░██║██╔══╝░░░░░██║░░░██╔══██║██║██║░░░░░░╚═══██╗
██████╔╝███████╗░░░██║░░░██║░░██║██║███████╗██████╔╝
╚═════╝░╚══════╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝╚══════╝╚═════╝░

██████╗░███████╗████████╗███████╗░█████╗░████████╗██╗░█████╗░███╗░░██╗
██╔══██╗██╔════╝╚══██╔══╝██╔════╝██╔══██╗╚══██╔══╝██║██╔══██╗████╗░██║
██║░░██║█████╗░░░░░██║░░░█████╗░░██║░░╚═╝░░░██║░░░██║██║░░██║██╔██╗██║
██║░░██║██╔══╝░░░░░██║░░░██╔══╝░░██║░░██╗░░░██║░░░██║██║░░██║██║╚████║
██████╔╝███████╗░░░██║░░░███████╗╚█████╔╝░░░██║░░░██║╚█████╔╝██║░╚███║
╚═════╝░╚══════╝░░░╚═╝░░░╚══════╝░╚════╝░░░░╚═╝░░░╚═╝░╚════╝░╚═╝░░╚══╝

░██████╗██╗░░░██╗░██████╗████████╗███████╗███╗░░░███╗
██╔════╝╚██╗░██╔╝██╔════╝╚══██╔══╝██╔════╝████╗░████║
╚█████╗░░╚████╔╝░╚█████╗░░░░██║░░░█████╗░░██╔████╔██║
░╚═══██╗░░╚██╔╝░░░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║
██████╔╝░░░██║░░░██████╔╝░░░██║░░░███████╗██║░╚═╝░██║
╚═════╝░░░░╚═╝░░░╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝");
        }
    }
    class TitlePage
    {
        static public void yes()
        {
            Console.WriteLine("\n\nWELCOME TO THE PROJECT: 'CONSOLE OPERATED COMPUTER CONTROLLING AND DETAILS DETECTION SYSTEM' \n\n ");
            Console.WriteLine("GROUP MEMBERS                   S.ID                    MOBILE NO                      EMAIL\n");
            Console.WriteLine("Muzamil Khan                    11508                   123444453                    xyz@gmail.com");
            Console.ReadKey();
            Console.Clear();
            TitlePage.securityLogin();
        }
        static public void securityLogin()
        {
            Console.WriteLine("login as: \n1: user\n2: admin");
            string enter = Console.ReadLine();
            Console.Clear();
            if (enter == "user" || enter == "USER" || enter == "User" || enter == "1" || enter == "01")
            {
                userMenu.yes();
            }
            else if (enter == "admin" || enter == "ADMIN" || enter == "Admin" || enter == "2" || enter == "02")
            {
                admin.logincheck();
            }
            else
            {
                Console.WriteLine(@"Invalid input!\n\n\n\t\tdo you want to enter again? press 'y' for yes ");
                string x = Console.ReadLine();
                if (x == "y" || x == "yes" || x == "Y")
                {
                    TitlePage.securityLogin();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\t\t\tExiting softwere..............");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
    
    class admin
    {
        public static void logincheck()
        {
            Console.WriteLine("ENTER ADMIN NAME...");
            string user = Console.ReadLine();
            
            if (user == "muzamil" || user == "MUZAMIL")
            {
                Console.WriteLine("ENTER ADMIN PASWORD...");
                string pass = Console.ReadLine();
                if (pass == "11508")
                {

                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\t\t\t\tLOGIN SUCCESSFULLY....");
                    Console.ReadKey();
                    Console.Clear();
                    admin.userlogindetail();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\t\t\tWRONG pasword.... try again");
                    admin.logincheck();
                }
            }
            else if (user == "mk" || user == "MK")
            {
                Console.WriteLine("ENTER ADMIN PASWORD...");
                string pass = Console.ReadLine();
                if (pass == "123")
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\t\t\t\tLOGIN SUCCESSFULLY....");
                    Console.ReadKey();
                    Console.Clear();
                    admin.userlogindetail();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\t\t\tWRONG pasword.... try again");
                    admin.logincheck();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\t\t\tENTER A VALID USER NAME PLEASE......");
                admin.logincheck();

            }
        
            
        }
        public static void userlogindetail()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n\t\t\tSHOWING YOU WHO HAVE ACCESSED YOUR SOFTWERE YET ....");
            Console.ReadKey();
            Console.Clear();
            string filepath = @"G:\Degree Projects\Operating System On Console Computer Controlling And Details Detection System in Csharp\Operating System Computer Detailed System In Csharp";
            
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }

    //*****************************************************************USER************************************************************************************

    class userMenu
    {
        public static void yes()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO THE MENU:\n");
            Console.WriteLine(" 1: File and Directory details system\n 2: Browsing Internet");
            Console.WriteLine(" 3: See available WIFI's\n 4: See previously connected Wifi Details");
            Console.WriteLine(" 5: Your Processor detail and Speed \n 6: Show complete IP configration");
            Console.WriteLine(" 7: See System (Info / spex)");
            Console.WriteLine(" 8: Close the programme");
            string choice = Console.ReadLine();
            Console.Clear();
            if (choice == "1")
            {
                USER_FileAndDirectory.ChoiceFileAndDirectory();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter what do you want to browse through google");
                string query = Console.ReadLine();
                internet.searchGoogle(query);
            }
            else if (choice == "3")
            {
                WIFI.present();
            }
            else if (choice == "4")
            {
                WIFI.previous();
            }
            else if (choice == "5")
            {
                processor.info();
            }
            else if (choice == "6")
            {
                IP.CompleteConfigration();
            }
            else if (choice == "7")
            {
                systemInfo.open();
            }
            else if (choice == "8")
            {
                
            }
            else
            {
                userMenu.yes();
            }
        }
    }
    class USER_FileAndDirectory
    {
        public static void ChoiceFileAndDirectory()
        {
            Console.WriteLine(@"
                                            
                                

                                        WELCOME TO FILE DETAILS SYSTEM");
            Console.WriteLine(@"                        ''WE HAVE FIOLLOWING OPTIONS IN 'FILE DETAILS SYSTEM''
1: JUST DIRECTORY DETAILS OF 'Muzamil Khan' 
2: See the whole files present in the Available Directory 
3: see the name of files along with the last accessed
4: see files with complete address of each
5: go to main menu");
            string CHOICE3 = Console.ReadLine();

            if (CHOICE3 == "1")
            {
                Console.Clear();
                USER_FileAndDirectory.choice1();
               

            }
            else if (CHOICE3 == "2")
            {
                Console.Clear();
                USER_FileAndDirectory.choice2();
                

            }
            else if (CHOICE3 == "3")
            {
                Console.Clear();
                USER_FileAndDirectory.choice3();
                

            }
            else if (CHOICE3 == "4")
            {
                Console.Clear();
                USER_FileAndDirectory.choice4();
                

            }
            else if (CHOICE3 == "5")
            {
                userMenu.yes();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\t\t\t........Invalid Input Try again latter........");
                Console.ReadKey();
                Console.Clear();
                USER_FileAndDirectory.ChoiceFileAndDirectory();
            }
        }
        public static void choice1()
        {
            string rootpath = @"G:\Degree Projects\Operating System On Console Computer Controlling And Details Detection System in Csharp\Operating System Computer Detailed System In Csharp";
            string[] dirs = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            Console.ReadKey();
            Console.Clear();
            USER_FileAndDirectory.ChoiceFileAndDirectory();
        }
        public static void choice2()
        {
            string rootpath = @"G:\Degree Projects\Operating System On Console Computer Controlling And Details Detection System in Csharp\Operating System Computer Detailed System In Csharp";
            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));//it'll just show the names of files                                                               
            }
            Console.ReadKey();
            Console.Clear();
            USER_FileAndDirectory.ChoiceFileAndDirectory();
        }
        public static void choice3()
        {
            string rootpath = @"G:\Degree Projects\Operating System On Console Computer Controlling And Details Detection System in Csharp\Operating System Computer Detailed System In Csharp";
            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                var info = new FileInfo(file);
                Console.WriteLine(@"{Path.GetFileName(file)}: {info.LastAccessTime}"); //complete information of the filees(size, last seen, etc)(we can)
            }
            Console.ReadKey();
            Console.Clear();
            USER_FileAndDirectory.ChoiceFileAndDirectory();
        }
        public static void choice4()
        {
            string rootpath = @"G:\Degree Projects\Operating System On Console Computer Controlling And Details Detection System in Csharp\Operating System Computer Detailed System In Csharp";
            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);//file with complete address
                var info = new FileInfo(file);
            }
            Console.ReadKey();
            Console.Clear();
            USER_FileAndDirectory.ChoiceFileAndDirectory();
        }
       
    }
    class internet
    {

        public static void searchGoogle(string query)
        {
            Process.Start("http://google.com/search?q=" + query);
            Console.WriteLine("Do you want another browsing?     (y/n)");
            string c = Console.ReadLine();
            if (c == "yes" || c == "YES" || c == "y" || c == "Y")
            {
                Console.WriteLine("Enter what do you want to browse through google");
                string q = Console.ReadLine();
                internet.searchGoogle(q);
            }
            else if (c == "no" || c == "NO" || c == "n" || c == "N")
            {
                userMenu.yes();
            }
            else
            {
                userMenu.yes();
            }
        }
    }
    class WIFI
    {
        public static void present()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true; // new window open krny s mana kia h
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("netsh wlan show network");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine("\n\n\n");
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
            Console.Clear();
            userMenu.yes();
        }
        public static void previous()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true; // new window open krny s mana kia h
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("netsh wlan show profile key=clear");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine("\n\n\n");
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
            Console.Clear();
            userMenu.yes();
        }
    }
    class processor
    {
        public static void info()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true; // new window open krny s mana kia h
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            //to see the processor speed and processor info
            process.StandardInput.WriteLine("wmic cpu get name, maxclockspeed, currentclockspeed");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine("\n\n\n");
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
            Console.Clear();
            userMenu.yes();
        }
    }
    class systemInfo
    {
        public static void open()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true; // new window open krny s mana kia h
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("systeminfo");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine("\n\n\n");
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
            Console.Clear();
            userMenu.yes();
        }
    }
   
    class IP
    {
        public static void CompleteConfigration()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true; // new window open krny s mana kia h
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine("ipconfig /all");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine("\n\n\n");
            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
            Console.Clear();
            userMenu.yes();
        }   
    }
}
