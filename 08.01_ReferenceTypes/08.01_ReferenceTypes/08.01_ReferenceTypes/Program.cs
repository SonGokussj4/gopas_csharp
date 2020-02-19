using System;

namespace _08._01_ReferenceTypes
{
    internal class Invoice
    {
        private int ID;
        public decimal TotalPrice;
        public DateTime DateCreated;
        public DateTime DatePrinted;

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
    }

    internal class InvoiceManager
    {
        public static void PrintInvoice(Invoice invoice)
        {
            // Zkontroluji, zda invoice vubec existuje. Pokud ne, tak vyskocim z funkce ven.
            if (invoice == null) return;

            Console.WriteLine($"ID: {invoice.Id}, TotalPrice: {invoice.TotalPrice}, DateCreated: {invoice.DateCreated}");

            // Zapiseme do instance, kde bylo naposled printovano
            invoice.DatePrinted = DateTime.Now;
        }

        public static Invoice MakeInvoice(int id, decimal totalPrice)
        {
            Invoice newInvoice = new Invoice();
            newInvoice.Id = id;
            newInvoice.TotalPrice = totalPrice;
            newInvoice.DateCreated = DateTime.Now;
            return newInvoice;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Invoice[] invoices = new Invoice[3];

            invoices[0] = new Invoice();
            invoices[0].Id = 1;
            invoices[0].TotalPrice = 5000;
            invoices[0].DateCreated = new DateTime(2020, 02, 19);

            invoices[1] = new Invoice();
            invoices[1].Id = 2;
            invoices[1].TotalPrice = 20000;
            invoices[1].DateCreated = new DateTime(2020, 02, 15);

            invoices[2] = InvoiceManager.MakeInvoice(3, 8000);

            foreach (Invoice item in invoices)
            {
                InvoiceManager.PrintInvoice(item);
            }
            Console.WriteLine($"Printovano: {invoices[0].DatePrinted}");
        }
    }
}