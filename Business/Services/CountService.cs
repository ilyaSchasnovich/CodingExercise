using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Services
{
    public class CountService : ICountSevice
    {
        public List<EndOfDayInfo> CalculateEndOfDayBalances(Brand brand)
        {
            return brand.Accounts.Select(account => CalculateEndOfDayBalanceForAccount(account, brand.RequestDateTime))
                                 .ToList();
        }

        private static EndOfDayInfo CalculateEndOfDayBalanceForAccount(Account account, DateTime requestedDate)
        {
            if (account?.Transactions is null || account.Transactions.Count() == 0)
                return null;

            var totalDebit = 0;
            var totalCredit = 0;
            var balance = account.Balances?.Current?.Amount ?? 0;

            var transactions = account.Transactions.Where(transactions => transactions.BookingDate < requestedDate)
                                                   .OrderByDescending(transaction => transaction.BookingDate);

            var endOfDayBalanses = new List<EndOfDayBalance>();
            var currentDate = transactions.First().BookingDate;


            foreach (var transaction in transactions)
            {
                if (transaction.BookingDate != currentDate)
                {
                    endOfDayBalanses.Add(new EndOfDayBalance(currentDate, balance));
                    currentDate = transaction.BookingDate;
                }

                if (transaction.CreditDebitIndicator == "Credit")
                {
                    balance += transaction.Amount;
                    totalCredit += transaction.Amount;
                }
                else if(transaction.CreditDebitIndicator == "Debit")
                {
                    balance -= transaction.Amount;
                    totalDebit += transaction.Amount;
                }

            }

            endOfDayBalanses.Add(new EndOfDayBalance(currentDate, balance));

            return new EndOfDayInfo()
            {
                AccountId = account.AccountID,
                TotalCredit = totalCredit,
                TotalDebit = totalDebit,
                EndOfDayBalances = endOfDayBalanses
            };

        }
    }
}
