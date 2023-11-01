// See https://aka.ms/new-console-template for more information
using HW5_2.Childs;

Console.WriteLine("enter your email:");
string emailAddress = Console.ReadLine();

Console.WriteLine("enter your message:");
string message = Console.ReadLine();

Email email = new Email(message,emailAddress);
email.Send();
