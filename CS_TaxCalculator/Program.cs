// See https://aka.ms/new-console-template for more information
using CS_TaxCalculator.Interfaces;
using CS_TaxCalculator.Logic;
using CS_TaxCalculator.TaxFacade;
using CS_TaxCalculator.TaxGateway;

Console.WriteLine("DEMO Interface");
// Client App

//TaxCalculator taxCalculator = new TaxCalculator();

//ITaxCalculator taxCalc = new TDSCalculator();

//Console.WriteLine($"TDS = {taxCalculator.GetTax(taxCalc, 200000)}");

//taxCalc = new GSTCalculator();

//Console.WriteLine($"GST : {taxCalculator.GetTax(taxCalc, 600000)}");


TaxCalculatorFacade facade = new TaxCalculatorFacade();

Console.WriteLine($"TDS = {facade.CalculateTax(200000,"TDS")}");
Console.WriteLine($"GST = {facade.CalculateTax(600000, "GST")}");

Console.ReadLine();
