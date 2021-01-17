using System.Collections.Generic;
using LeModas_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeModas_2.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index(){
            List<Customer> list = new List<Customer>();
            list.Add(new Customer{
                Name = "Nathan",
                Phone = "17991407968",
                Debts = 250.00,
                Cpf = "48969296832",
                Adress = "Rua Casmin Alves de Moura, 115"
            });
            list.Add(new Customer{
                Name = "Elenice",
                Phone = "17991950448",
                Debts = 350.00,
                Cpf = "74344471687",
                Adress = "Rua Casmin Alves de Moura, 115"
            });

            return View(list);
        }
    }
}