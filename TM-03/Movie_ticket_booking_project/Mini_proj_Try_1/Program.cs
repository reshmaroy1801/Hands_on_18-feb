using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTicketBooking1;
using MovieTicketBooking2;
using MovieTicketBooking3;

namespace Mini_proj_Try_1
{
    class program
    {
        static public void create_admin()
        {
            MovieTicketing m1 = new MovieTicketing();
        } 

        static void Main(string[] args)
        {
            program.create_admin();
            Administrator admin1 = new Administrator();
            Menu m1 = new Menu();
            string str = m1.Login();
            int choice = 0;
            if (str == "Admin")
            {
                while (true)
                {
                    m1.AdminMenu();
                    choice = m1.GetChoice();

                    if (choice == 1)
                    {
                        Console.WriteLine("enter the details of the theatre");
                        string TheatreName1 = Console.ReadLine();
                        string CityName1 = Console.ReadLine();
                        string Address1 = Console.ReadLine();

                        int NoOfScreens1 = int.Parse(Console.ReadLine());


                        Theatre t = new Theatre(TheatreName1, CityName1, Address1, NoOfScreens1);
                        admin1.AddTheatre(t);

                    }

                    else if (choice == 2)
                    {

                        Console.WriteLine("enter the theatreID whose details you want to update");
                        int theatreID = int.Parse(Console.ReadLine());
                        foreach (var val in MovieTicketing.Theatres)
                        {
                            if (val.TheatreID == theatreID)
                            {
                                admin1.UpdateTheatre(val);
                            }
                        }

                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("enter the details of the movie");

                        string MovieName1 = Console.ReadLine();
                        string Director1 = Console.ReadLine();
                        string Producer1 = Console.ReadLine();
                        string Cast1 = Console.ReadLine();
                        double Duration1 = double.Parse(Console.ReadLine());
                        string Story1 = Console.ReadLine();
                        string Type1 = Console.ReadLine();

                        Movie m = new Movie(MovieName1, Director1, Producer1, Cast1, Duration1, Story1, Type1);
                        admin1.AddMovie(m);
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("enter the movie ID you want to update");
                        int movieID = int.Parse(Console.ReadLine());
                        foreach (var val in MovieTicketing.Movies)
                        {
                            if (val.MovieID == movieID)
                            {
                                admin1.UpdateMovie(val);
                            }
                        }
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Enter the details about show :");
                        int m_id = int.Parse(Console.ReadLine());
                        int t_id = int.Parse(Console.ReadLine());
                        int sc_id = int.Parse(Console.ReadLine());

                        DateTime s_date = DateTime.Parse(Console.ReadLine());
                        DateTime e_date = DateTime.Parse(Console.ReadLine());
                        decimal p_rate = decimal.Parse(Console.ReadLine());
                        decimal g_rate = decimal.Parse(Console.ReadLine());
                        decimal s_rate = decimal.Parse(Console.ReadLine());

                        Show show1 = new Show(s_date, e_date, m_id, t_id, sc_id, p_rate, g_rate, s_rate);
                        admin1.AddShow(show1);
                    }
                    else if (choice == 6)
                    {
                        Console.WriteLine("enter the show ID whose details you want to update");
                        int showID = int.Parse(Console.ReadLine());
                        foreach (var val in MovieTicketing.Shows)
                        {

                            if (val.ShowID == showID)
                            {
                                admin1.UpdateShow(val);
                            }
                        }
                    }
                    else if (choice == 7)
                    {
                        Console.WriteLine("enter the show ID whose details you want to delete");
                        int showID = int.Parse(Console.ReadLine());
                        foreach (var val in MovieTicketing.Shows)
                        {
                            if (val.ShowID == showID)
                            {
                                admin1.DeleteShow(showID);
                            }
                        }
                    }
                    else if (choice == 8)
                    {
                        foreach(var val in admin1.GetAllTheatres())
                        {
                            val.DisplayTheatreDetails();
                        }
                    }
                    else if (choice == 9)
                    {
                        foreach (var val in admin1.GetAllMovies())
                        {
                            val.DisplayMovieDetails();
                        }
                    }
                    else if (choice == 10)
                    {
                        foreach (var val in admin1.GetAllShows())
                        {
                            val.DisplayShowDetails();
                        }
                    }
                    else if (choice == 11)
                    {
                        Console.WriteLine("enter the user details");
                        string username = Console.ReadLine();
                        string password = Console.ReadLine();
                        string usertype = Console.ReadLine();
                        User u1 = new User(username, password, usertype);
                        admin1.AddAgent(u1);
                    }
                    else if (choice == 12)
                    {
                        Console.WriteLine("enter the booking details");
                        int showid = int.Parse(Console.ReadLine());
                        string customername = Console.ReadLine();
                        int numberofseats = int.Parse(Console.ReadLine());
                        string seattype = Console.ReadLine();
                        string email = Console.ReadLine();
                        TicketBooking tb = new TicketBooking();
                        admin1.BookTicket(showid, customername, numberofseats, seattype, email);
                    }
                    else if (choice == 13)
                    {
                        Console.WriteLine("enter the booking ID whose details you have to print");
                        int bookingID = int.Parse(Console.ReadLine());
                        foreach (var val in MovieTicketing.Bookings)
                        {
                            if (val.BookingID == bookingID)
                            {
                                admin1.PrintTicket(bookingID);
                            }
                        }
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }
                }
            }

            else if (str == "Agent")
            {
                while (true)
                {
                    if (choice == 1)
                    {
                        admin1.DisplayShows();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("enter the booking details");
                        int showid = int.Parse(Console.ReadLine());
                        string customername = Console.ReadLine();
                        int numberofseats = int.Parse(Console.ReadLine());
                        string seattype = Console.ReadLine();
                        string email = Console.ReadLine();
                        TicketBooking tb = new TicketBooking();
                        admin1.BookTicket(showid, customername, numberofseats, seattype, email);
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("enter the booking ID whose details you have to print");
                        int bookingID = int.Parse(Console.ReadLine());
                        foreach (var val in MovieTicketing.Bookings)
                        {
                            if (val.BookingID == bookingID)
                            {
                                admin1.PrintTicket(bookingID);
                            }
                        }
                    }
                    else
                    {
                        System.Environment.Exit(0);
                    }

                }

            }
 
            
            else
            {
                Console.WriteLine("invalid username OR Password.Please try again");
                
            }

            Console.ReadKey();

        }
    }
}
