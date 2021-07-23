using System;

namespace DinerAdminV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Table[] tables = { new Table(1, 5), new Table(2, 10), new Table(3, 20) };
            bool isOpened = true;
            while (isOpened)
            {
                Console.WriteLine("Welcome to Yoba Diner Administration.");
                Console.SetCursorPosition(0, 5);
                for (int i = 0; i < tables.Length; i++)
                {
                    tables[i].ShowInfo();
                }

                Console.Write("\n Input the table number: ");
                int userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Write("\n Input the amount of seats: ");
                int userSeat = Convert.ToInt32(Console.ReadLine());

                bool isReserved = tables[userTable].Reservation(userSeat);
                
                if (isReserved)
                {
                    Console.WriteLine("Reservation succeeded");
                }
                else
                {
                    Console.WriteLine("Error"); 
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    class Table
    {
        private int _number;
        private int _maxSeats;
        private int _spareSeats;
        public Table(int number, int maxSeats)
        {
            _number = number;
            _maxSeats = maxSeats;
            _spareSeats = maxSeats;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Table {_number}. Spare seats {_spareSeats} / {_maxSeats}");
        }

        public bool Reservation(int place)
        {
            bool isReserved;
            isReserved = _spareSeats >= place;
            if (isReserved)
            {
                _spareSeats -= place;
                return isReserved;
            }
            else
            {
                return isReserved;
            }
        }
    }
}