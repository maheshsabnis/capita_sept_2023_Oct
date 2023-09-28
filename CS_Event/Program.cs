// See https://aka.ms/new-console-template for more information
using CS_Event.Logic;

Console.WriteLine("DEMO Event");
Banking bank = new Banking(70000);
// Subscribe to Notification
EventListener listener = new EventListener(bank);
bank.Deposit(60000);
Console.WriteLine($"Nebalance after deposit : {bank.GetBalance()}");
bank.Withdrawal(127000);
Console.WriteLine($"Nebalance after withdrawal : {bank.GetBalance()}");
Console.ReadLine();
