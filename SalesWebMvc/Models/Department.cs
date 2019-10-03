
using SalesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        //1 departamento possui vários vendedores
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() {
        }

        //ICollection não entram na lista de construtor com argumento
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //Adicionar vendedor 
        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }

        //calcula total de vendas do departamento para intervalo datas
        public double TotalSales(DateTime initial, DateTime final) {
            //para cada vendedor da lista, chamando totalSales do vendedor no período initial e final e faz soma para todos vendedores do departamento
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
