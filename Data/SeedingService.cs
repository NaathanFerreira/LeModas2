using System.Linq;
using LeModas_2.Models;

namespace LeModas_2.Data
{
    public class SeedingService
    {
        private LeModas_2Context _context;

        public SeedingService(LeModas_2Context context){
            _context = context;
        }

        public void Seed(){
            if(_context.Customer.Any()){
                return;
            }

            Customer c1 = new Customer{
                Name = "Nathan",
                Phone = "17991407968",
                Debts = 250.00,
                Cpf = "48969296832",
                Adress = "Rua Casmin Alves de Moura, 115"
            };
            Customer c2 = new Customer{
                Name = "ELenice",
                Phone = "132154",
                Debts = 750.00,
                Cpf = "12354",
                Adress = "Rua  Moura, 116"
            };
            Customer c3 = new Customer{
                Name = "Jean",
                Phone = "179968",
                Debts = 2250.00,
                Cpf = "4815832",
                Adress = "Rua Casmin , 116"
            };
            Customer c4 = new Customer{
                Name = "Henrique",
                Phone = "178768",
                Debts = 2950.00,
                Cpf = "48106832",
                Adress = "Rua  Alves , 118"
            };

            _context.Customer.AddRange(c1, c2, c3, c4);
            _context.SaveChanges();            
        }
    }
}