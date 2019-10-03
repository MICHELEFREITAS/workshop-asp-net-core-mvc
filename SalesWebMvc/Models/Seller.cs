using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set;}
        public string Nome { get; set;}
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        //1 seller possui 1 departamento
        public Department Department { get; set; }
        //avisando entities framework que esse id tem que existir pq id não pode ser null
        public int DepartmentId { get; set; }
        //Lista de vendas desse vendedor. Assossiação para muitos de acordo com diagrama do vendedor com registro de vendas. 1 vendedor tem várias vendas
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() {
        }

        public Seller(int id, string nome, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        //adicionar venda na lista de vendas (SalesRecord)
        public void AddSales(SalesRecord sr) {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr) {
            Sales.Remove(sr);
        }

        //Calcula total de vendas desse vendedor nesse período datas
        public double TotalSales(DateTime initial, DateTime final) {
            //filtrar vendas e retornar registro de vendas da data inicial até final. Calcula soma das vendas
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
        
    }
}
