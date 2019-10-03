using System;
using SalesWebMvc.Models.Enums;
using SalesWebMvc.Models.ViewModels;

namespace SalesWebMvc.Models
{
    //Registro das vendas
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SaleStatus status { get; set; }
        //cada registro de vendas possui 1 vendedor
        public Seller Seller { get; set; }


        public SalesRecord() {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            this.status = status;
            Seller = seller;
        }
    }
}
