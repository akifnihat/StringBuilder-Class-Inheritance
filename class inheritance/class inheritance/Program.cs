using class_inheritance.Models;
using System.Security.Principal;

namespace class_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //Account account = new Account();
            //Console.Write("Istifadeci adı daxil et: ");
            //string username = Console.ReadLine();

            //Console.Write("Parolu daxil et: ");
            //string password = Console.ReadLine();

            //account.Login(username, password);
            #endregion

            #region task2
            //Car Car = new Car("bmw","m5",77,4.5,44,"qara",2014);
            //Car.ShowInfo();
            //Console.WriteLine("Distance qeyd et");
            //Car.Drive(Convert.ToInt32(Console.ReadLine()));
            #endregion

            #region task3
            //Circle cirle = new Circle(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

            //cirle.GetInfo();

            //Rectangle rectangle = new Rectangle(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));

            //rectangle.GetInfo();

            #endregion
        }
    }
    public class Account
    {
        public void Login(string username, string password)
        {
            string correctUsername = "lorem123";
            string correctPassword = "123456*";

            if (username == correctUsername && password == correctPassword)
                Console.WriteLine("Giris ugurludur.");
            else
                Console.WriteLine("Email ve ya parol sehvdir.");
        }
    }

}
