namespace LeModas_2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Debts { get; set; }
        public string Cpf { get; set; }
        public string Adress { get; set; }

        public Customer(){}

        public Customer(int id, string name, string phone, double debts, string cpf, string adress)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Debts = debts;
            Cpf = cpf;
            Adress = adress;
        }
    }
}