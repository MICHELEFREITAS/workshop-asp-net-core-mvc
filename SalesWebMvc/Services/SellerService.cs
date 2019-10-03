using SalesWebMvc.Models;
using SalesWebMvc.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Dependencia para nosso DBContext do Data - SalesWebMvcContext. OBS: readonly dependencia não pode ser alterada
        private readonly SalesWebMvcContext _context;

        //construtor para injeção de ocorrencia possa ocorrer
        public SellerService(SalesWebMvcContext context) {
            //dependencia do context
            _context = context;
        }

        //operação retornar lista com todos vendedores do BD
        public List<Seller> FindAll() {
            //operação síncrona - roda acesso ao BD e aplicação fica bloqueada esperando terminar. Depois mudar para assíncrona aumentar a performace
            return _context.Seller.ToList();
        }

    }
}
