using PlayesTeam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace TestConsol
{
    class Program
    {
        static List<Player> teamList = new List<Player>();
        static void Main(string[] args)
        {
            Console.Title = "player Management Softwer";
            showMainMessage();
        }
        //___________________________________________________________
        //Add player
        //___________________________________________________________
        static void addPlayer() {

            Console.Clear();
            Console.WriteLine("...::::Add menu::::...");
            Player player1 = new Player();
            Console.WriteLine("\nEnter Player Name :");
            player1.Names = Console.ReadLine();
            Console.WriteLine("Enter Player Nationality :");
            player1.Nationality = Console.ReadLine();
            Console.WriteLine("Enter Player Age :");
            player1.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player post :");
            player1.Field = Console.ReadLine();
            teamList.Add(player1);
            foreach (var player in teamList)
            {
              Console.WriteLine("Name=" +player.Names + "| Age=" + player.Age + "| Nation= " + player.Nationality + "| post=" + player.Field + " ");
            }
            showMainMessage();
        }
        //___________________________________________________________
        //Show main Menu
        //___________________________________________________________
        static void showMainMessage()
        {
            Console.WriteLine("                 .....:::::::Welcome To The Player Management Software:::::::.....");
            Console.WriteLine("\n *Home Page*");
            Console.Out.WriteLine("\n [1]. Add player");
            Console.Out.WriteLine(" [2]. Show player");
            Console.Out.WriteLine(" [3]. Sort option");
            Console.Out.WriteLine(" [4]. Search option");
            Console.Out.WriteLine(" [5]. Add fake data");
            Console.Out.WriteLine(" [6]. Select Capitan");
            Console.Out.WriteLine(" [7]. Developer resume");
            Console.Out.WriteLine("\n*****************************************");
            Console.Out.WriteLine(" For some action just add a number ");
            Console.Out.WriteLine("*****************************************");
            int command = int.Parse(Console.ReadLine());

            switch (command)
            {
                case 1:
                    addPlayer();
                    break;
                case 2:
                    ShowPlayer();
                    break;
                case 3:
                    SortOption();
                    break;
                case 4:
                    searchOption();
                    break;
                case 5:
                    addFakeData();
                    break;
                case 6:
                    selectCapitan();
                    break;
                case 7:
                    developer();
                    break;
                default:
                    Console.Out.WriteLine("\nxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.Out.WriteLine("        Wrog input set again");
                    Console.Out.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    showMainMessage();
                    break;
            }  
        }
        //________________________________________________________________
        //Add fake data
        //________________________________________________________________
        static void addFakeData()
        {
            String[] countrys = {"Iran","Spain","Italy","Japon","China","Brazil","North Korea","England","Germany","Belgium" };
            String[] fields = {"goalkeeper","Defender","Midfilder","Striker","Winger","Second Striker"};
            string[] names = {"Erfan","lionel","Angel","Shahab","Alex","Manuel","Robert","Marko","Mario","Luis","David","Jack" };
            string[] familis = {"Gharche","Salami","Willson","Grealish","gomez","Perez","Rogers","Benson","Wood","Collins","Shaw" };
            for (int i=0; i<=10; i++)
            {
                int randomCountrys = new Random().Next(0,countrys.Length);
                int randomfields = new Random().Next(0,fields.Length);
                int age = new Random().Next(18, 40);
                int randomName = new Random().Next(0, names.Length);
                int randomFamilis = new Random().Next(0, familis.Length);

                Player player = new Player();
                player.Age = age;
                player.Names = names[randomName] + " " + familis[randomFamilis];
                player.Field = fields[randomfields];
                player.Nationality = countrys[randomCountrys];
                teamList.Add(player);
                Console.WriteLine("\n Name=" + player.Names + "| Age=" + player.Age + "| Nation= " + player.Nationality + "| post=" + player.Field + " ");
            }
            Console.WriteLine("_________________________________");
            Console.WriteLine("\n *Fake data successfully added*");
            Console.WriteLine("_________________________________");
            showMainMessage();
        }
        //________________________________________________________________
        //Show team list
        //________________________________________________________________
        static void ShowPlayer()
        {
            Console.Clear(); 
            Console.WriteLine(" team member is :" + teamList.Count);
            foreach (Player player in teamList)
            {
                Console.WriteLine("\n Name=" + player.Names + "| Age=" + player.Age + "| Nation= " + player.Nationality + "| post=" + player.Field + " ");
            }
            showMainMessage();
        }
        //________________________________________________________________
        //Sort by Name/Nation/Position/Age
        //________________________________________________________________
        static void SortOption()
        {
            Console.Clear();
            Console.WriteLine("...::: sort option menu :::...");
            Console.WriteLine("\n[1].Sort by name");
            Console.WriteLine("[2].Sort by age");
            Console.WriteLine("[3].Sort by nation");
            Console.WriteLine("[4].Sort by Field");
            Console.Write("\n[5]. back to main menu");
            if (Console.ReadKey().KeyChar == '5')
                showMainMessage();


            int fieldSearch = int.Parse(Console.ReadLine());
            switch (fieldSearch)
            {
                case 1:
                    sortbyName();
                    break;
                case 2:
                    sortbyAge();
                    break;
                case 3:
                    sortbyNation();
                    break;
                case 4:
                    sortbyField();
                    break;
                default:
                    Console.Out.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.Out.WriteLine("        Wrog input set again");
                    Console.Out.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    showMainMessage();
                    break;
            }
            return;
        }
        static void sortbyAge()
        {
            teamList.Sort((playerX, playerY) => playerX.Age.CompareTo(playerY.Age));
            ShowPlayer();
        }
        static void sortbyName()
        {
            teamList.Sort((playerX, playerY) => playerX.Names.CompareTo(playerY.Names));
            ShowPlayer();
        }
        static void sortbyNation()
        {
            teamList.Sort((playerX, playerY) => playerX.Nationality.CompareTo(playerY.Nationality));
            ShowPlayer();
        }
        static void sortbyField()
        {
            teamList.Sort((playerX, playerY) => playerX.Field.CompareTo(playerY.Field));
            ShowPlayer();
        }
        //________________________________________________________________
        //Search menu
        //________________________________________________________________
        static void searchOption()
        {
            Console.Clear();
            Console.WriteLine("...:::Search option menu:::...");
            Console.WriteLine("\n [1].Search by age");
            Console.WriteLine(" [2].Search by name");
            Console.WriteLine(" [3].Search by nation");
            Console.WriteLine(" [4].Search by Player field");
            Console.Write("\n[5]. back to main menu");
            if (Console.ReadKey().KeyChar == '5')
                showMainMessage();

            int searchbyOption = int.Parse(Console.ReadLine());          
            switch (searchbyOption)
            {
                case 1:
                    searchByAge();
                    break;
                case 2:
                    searchbyName();
                    break;
                case 3:
                    searchbyNation();
                    break;
                case 4:
                    searchbyField();
                    break;
                default:
                    Console.Out.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    Console.Out.WriteLine("        Wrog input set again");
                    Console.Out.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                    showMainMessage();
                    break;
            }
        }
        //___________________________________________________________
        //Search by age
        //___________________________________________________________
        static void searchByAge()
        {
            Console.Clear();
            Console.WriteLine("...:::: Age search menu ::::...");
            Console.WriteLine("\nEnter age:");
            int age = int.Parse(Console.ReadLine());
            foreach (var player in teamList)
            {
                if (age == player.Age)
                {
                    Console.WriteLine("  name:" + player.Names + "|  Age:" + player.Age);
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("  Player found successfully");
                    showMainMessage();

                }
            }
        }
        //___________________________________________________________
        //Search by Nation
        //___________________________________________________________
        static void searchbyNation()
        {
            Console.WriteLine("...:::: Nation search menu ::::...");
            Console.WriteLine("\nEnter Nation:");
            string Nation = Console.ReadLine();
            foreach (Player player in teamList)
            {
                if (Nation == player.Nationality)
                {
                    Console.WriteLine("  name:" + player.Names + "|  Nation:" + player.Nationality);
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("  Player found successfully");
                    showMainMessage();

                }
            }
        }
        //___________________________________________________________
        //Search by name
        //___________________________________________________________
        static void searchbyName()
        {
            Console.WriteLine("...:::: Name search menu ::::...");
            Console.WriteLine("\nEnter Name:");
            string Name = Console.ReadLine();
            foreach (Player player in teamList)
            {
                if (Name == player.Names)
                {
                    Console.WriteLine(" name:" + player.Names + "| age:" + player.Age);
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("  Player found successfully");
                    showMainMessage();

                }
            }
        }
        //___________________________________________________________
        //Search by position
        //___________________________________________________________
        static void searchbyField()
        {
            Console.WriteLine("...:::: Player field search menu ::::...");
            Console.WriteLine("\nEnter player field:");
            string Field = Console.ReadLine();
            foreach (Player player in teamList)
            {
                if (Field == player.Field)
                {
                    Console.WriteLine(" name:" + player.Names + "| field:" + player.Field);
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("  Player found successfully");
                    showMainMessage();
                }
            }
        }
        //________________________________________________________________
        //Show developer resume
        //________________________________________________________________
        static void developer()
        {
            Console.Clear();
            Console.WriteLine("       :::::               Name : Erfan Gharche Beydokhti                  :::::");
            Console.WriteLine("   ....:::::           Job : Co_developer and Graphic designer             :::::....");
            Console.WriteLine(".......:::::   Specialized programming language: Dart Flutter frame work   :::::.......");
            Console.WriteLine("\n [1].Back to main menu");
            if (Console.ReadKey().KeyChar == '1')
                showMainMessage();
        }
        //___________________________________________________________
        //Select capitan
        //___________________________________________________________
        static void selectCapitan()
        {
            int olderAge = 0;
            String olderName ="";

            for (int i = 0; i < teamList.Count; i++)
            {
                Player player = teamList.ElementAt(i);
                int currentAge = player.Age;
                String currentName = player.Names;
                if (currentAge >= olderAge) {
                    olderName = currentName;
                    olderAge = currentAge;
                }
            }
            Console.Out.WriteLine("Capitan has " + olderAge +" years old" + "  |  and his name is:" + olderName);
            showMainMessage();
        }
    }
}
