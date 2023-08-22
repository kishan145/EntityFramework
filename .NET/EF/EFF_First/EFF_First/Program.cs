using EFF_First;
using System;
using System.Collections.Generic;

class Program
    {
        static void Main(string[] args)
        {

        Batch model = new Batch();
        BatchBAL bl = new BatchBAL();

        string loopInput = string.Empty;

        do
        {
            Console.WriteLine("Menu:\n1.Insert\n2.Display All\n3.Display Record by batch id");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:

                    Console.WriteLine("Enter Batch Code");
                    model.BatchCode = Console.ReadLine();
                    Console.WriteLine("Enter Location");
                    model.Location = Console.ReadLine();
                    Console.WriteLine("Enter Number of traine");
                    model.TraineeStrenght = int.Parse(Console.ReadLine());

                    bool result = bl.CheckInsert(model);

                    if (result)
                    {
                        Console.WriteLine("\nSuccess");

                    }
                    else
                    {
                        Console.WriteLine("\nFailed");

                    }

                    break;

                case 2:

                    IList<Batch> li = bl.DisplayAllBatchRecord();

                    if (li.Count > 0)
                    {
                        Console.WriteLine("{0,-20}{1,-20}{2}", "Batch Code", "Location", "Trinee Count");
                        foreach(var data in li)
                        {
                            Console.WriteLine(data);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Record");
                    }

                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("Invalid selection");

                    break;


            }

            Console.WriteLine("Press Yes to continue...any other key to terminate");
            loopInput = Console.ReadLine();


        } while (loopInput.Equals("yes",StringComparison.InvariantCultureIgnoreCase));

        }
    }

