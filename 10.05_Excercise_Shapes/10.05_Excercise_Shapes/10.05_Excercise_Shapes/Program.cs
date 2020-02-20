using System;

namespace _10._05_Excercise_Shapes
{
    class ShapeManager
    {
        //public static void PrintInvoice(Invoice invoice)
        //{
        //    // Zkontroluji, zda invoice vubec existuje. Pokud ne, tak vyskocim z funkce ven.
        //    if (invoice == null) return;

        //    Console.WriteLine($"ID: {invoice.Id}, TotalPrice: {invoice.TotalPrice}, DateCreated: {invoice.DateCreated}");

        //    // Zapiseme do instance, kde bylo naposled printovano
        //    invoice.DatePrinted = DateTime.Now;
        //}

        //public static Invoice MakeInvoice(int id, decimal totalPrice)
        //{
        //    Invoice newInvoice = new Invoice();
        //    newInvoice.Id = id;
        //    newInvoice.TotalPrice = totalPrice;
        //    newInvoice.DateCreated = DateTime.Now;
        //    return newInvoice;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList shapes = new System.Collections.ArrayList();

            shapes.Add(ShapeManager.MakeObdelnik(2, 3));
            shapes.Add(ShapeManager.MakeKvadr(2, 5, 6));

            foreach (var shape in shapes)
            {
                shape.ToString();
            }
        }
    }
}
