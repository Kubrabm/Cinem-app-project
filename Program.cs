using Cinem_app_project.Managers;
using Cinem_app_project.Models;

namespace Cinem_app_project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Cinema Project";
            var cinemManager = new CinemaManager();
            var hallManager = new HallManager();
            var filmManager = new FilmManager();
            var seatsManager = new SeatsManager();
            var sessionsManager = new SessionsManager();
            var ticketManager = new TicketManager();


            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();


                if (command.ToLower().Equals("add cinema"))
                {
                    var cinema1 = new Cinema
                    {
                        Id = 1,
                        Name = "Deniz Mall",

                    };

                    var cinema2 = new Cinema
                    {
                        Id = 2,
                        Name = "Ganjlik Mall",

                    };

                    cinemManager.Add(cinema1);
                    cinemManager.Add(cinema2);

                }

                else if (command.ToLower().Equals("print cinemas"))
                {
                    cinemManager.Print();
                }

                else if (command.ToLower().Equals("add hall"))
                {
                    var hall1 = new Hall
                    {
                        Id = 1,
                        Name = "Econom",
                        RowCount = 10,
                        ColumnCount = 12,
                    };

                    var hall2 = new Hall
                    {
                        Id = 2,
                        Name = "Standart",
                        RowCount = 10,
                        ColumnCount = 12,
                    };
                    var hall3 = new Hall
                    {
                        Id = 3,
                        Name = "VIP",
                        RowCount = 10,
                        ColumnCount = 12,
                    };

                    hallManager.Add(hall1);
                    hallManager.Add(hall2);
                    hallManager.Add(hall3);
                }

                else if (command.ToLower().Equals("print halls"))
                {
                    hallManager.Print();
                }

                else if (command.ToLower().Equals("add film"))
                {
                    var film = new Film()
                    {
                        Id = 1,
                        Name = "Titanic",
                        OnScreen = "09.02.2023-22.02.2023",
                        Director = "James Cameron",
                        Duration = "210 minutes",
                        AgeRestriction = "12+",
                        Description = "On the first and last voyage of the luxurious Titanic, two people meet.\n Lower deck passenger Jack has won a card ticket,\n and wealthy heiress Rose is on her way to America to marry of convenience.\n",
                    };

                    var film1 = new Film()
                    {
                        Id = 2,
                        Name = "Avatar 2",
                        OnScreen = "15.12.2022-15.02.2023",
                        Director = "James Cameron",
                        Duration = "210 minutes",
                        AgeRestriction = "12+",
                        Description = "Jake Sully lives with his newfound family formed on the planet of Pandora.\n Once a familiar threat returns to finish what was previously started,\n Jake must work with Neytiri and the army of the Na'vi race to protect their planet.\n",
                    };

                    var film2 = new Film()
                    {
                        Id = 3,
                        Name = "Megan",
                        OnScreen = "26.01.2023-22.02.2023",
                        Director = "Jerrard Johnstone",
                        Duration = "120 minutes",
                        AgeRestriction = "18+",
                        Description = "Gemma is a roboticist at a toy company.\n After unexpectedly gaining custody of her recently orphaned niece,\n she gives the girl an experimental android doll,\n who soon understands her mission to protect the child in a literal sense.\n",
                    };

                    filmManager.Add(film);
                    filmManager.Add(film1);
                    filmManager.Add(film2);
                }

                else if (command.ToLower().Equals("print films"))
                {
                    filmManager.Print();
                }
                else if (command.ToLower().Equals("print seats"))
                {
                    seatsManager.Print();
                }

                else if (command.ToLower().Equals("add session"))
                {
                    var session1 = new Session
                    {
                        Id = 1,
                        Film = (Film)filmManager.Get(1),
                        Hall = (Hall)hallManager.Get(1),
                        SeansTime = DateTime.Parse("11.02.2023 7:00:00 PM"),
                        Price = 10,
                    };

                    var session2 = new Session
                    {
                        Id = 2,
                        Film = (Film)filmManager.Get(2),
                        Hall = (Hall)hallManager.Get(2),
                        SeansTime = DateTime.Parse("11.02.2023 11:00:00 PM"),
                        Price = 6,
                    };

                    var session3 = new Session
                    {
                        Id = 3,
                        Film = (Film)filmManager.Get(3),
                        Hall = (Hall)hallManager.Get(3),
                        SeansTime = DateTime.Parse("11.02.2023 9:00:00 PM"),
                        Price = 8,
                    };

                    sessionsManager.Add(session1);
                    sessionsManager.Add(session2);
                    sessionsManager.Add(session3);
                }

                else if (command.ToLower().Equals("print sessions"))
                {
                    sessionsManager.Print();
                    Console.WriteLine("1.Sellect Session:");
                    Console.WriteLine("2.Return Back:");
                    int operation = int.Parse(Console.ReadLine());
                    bool sessionsCheck = false;

                    switch (operation)
                    {
                        case 1:
                            sessionsCheck = true;

                            Console.Write("Insert Session Id: ");
                            var id = int.Parse(Console.ReadLine());

                            var seans = (Session)sessionsManager.Get(id);
                            var tickets = ticketManager._ticket;

                            Console.WriteLine("");
                            Console.Write("  ");

                            for (int i = 0; i < seans.Hall.ColumnCount; i++)
                            {
                                Console.Write((i + 1) + " ");
                            }

                            Console.WriteLine("");

                            for (int i = 0; i < seans.Hall.RowCount; i++)
                            {
                                Console.Write((i + 1) + " ");

                                for (int j = 0; j < seans.Hall.ColumnCount; j++)
                                {
                                    bool sold = false;

                                    for (int k = 0; k < tickets.Length; k++)
                                    {
                                        if (tickets[k] != null && tickets[k].Session.Id == id && tickets[k].Row == i && tickets[k].Column == j)
                                        {
                                            sold = true;
                                            break;
                                        }
                                    }

                                    if (sold)
                                        Console.Write("$ ");
                                    else
                                        Console.Write("* ");
                                }

                                Console.WriteLine("");
                            }

                            break;
                        case 2:
                            sessionsCheck = true;
                            break;
                        default:
                            sessionsCheck = true;
                            Console.WriteLine("Wrong Number!!");
                            break;
                    }

                    if (sessionsCheck)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1.Buy Ticket:");
                        Console.WriteLine("2.Return Back:");

                        int operation1 = int.Parse(Console.ReadLine());

                        switch (operation1)
                        {
                            case 1:
                                Console.Write("Select Session: ");
                                var seansId = int.Parse(Console.ReadLine());
                                Console.Write("Select Row: ");
                                var row = int.Parse(Console.ReadLine());
                                Console.Write("Select Column: ");
                                var column = int.Parse(Console.ReadLine());

                                var seans = (Session)sessionsManager.Get(seansId);

                                ticketManager.CreateTicket(seans, row - 1, column - 1);
                                break;
                            case 2:
                                break;
                            default:
                                Console.WriteLine("Wrong Number!!");
                                break;
                        }
                    }
                }

            } while (command.ToLower() != "quit");
        }
    }
}