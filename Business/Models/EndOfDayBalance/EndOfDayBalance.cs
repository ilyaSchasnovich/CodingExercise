using System;

namespace Business.Models
{
    public class EndOfDayBalance
    {
        public EndOfDayBalance(DateTime date, int balance)
        {
            Date = date;
            Balance = balance;
        }

        public DateTime Date { get; set; }
        public int Balance { get; set; }
    }
}
