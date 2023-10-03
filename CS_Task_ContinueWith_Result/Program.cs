﻿// See https://aka.ms/new-console-template for more information
using CS_Task_ContinueWith_Result.Logic;
using System.Text.Json;

Console.WriteLine("Task Continue with Result");
PaymentMonitor monitor = new PaymentMonitor(-300000);
Payment payment = new Payment();
payment.NetIncome = 300000;
try
{
    Task<Payment> tResult = Task.Factory.StartNew<Payment>(() =>
    {
         // Calculate TDS
            var tds = monitor.GetTDS();
            payment.TDS = tds;
            Console.WriteLine($"The TDS : Rs.{payment.TDS}/-");
            return payment;
         
    }).ContinueWith<Payment>((t1) =>
    {
        // Calculate
        var gst = monitor.GetGST();
        payment.GST = gst;
        Console.WriteLine($"GST is : Rs. {payment.GST}/-");
        return payment;
    }).ContinueWith<Payment>((t2) =>
    {
        payment.NetPayment = monitor.GetNetPayment(payment.NetIncome, t2.Result.TDS, t2.Result.GST);
        return payment;
    });

    var finalResult = tResult.Result;

    Console.WriteLine($"Final Payment details : {JsonSerializer.Serialize(finalResult)}");

}
catch (Exception ex)
{
    Console.WriteLine($"Error Occurred : {ex.Message}");
}
Console.ReadLine();