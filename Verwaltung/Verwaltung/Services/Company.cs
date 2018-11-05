using System.ComponentModel;

namespace Verwaltung.Services
{
    public class Company
    {

        public Company()
        {
            Customer = new BindingList<Customer>();
        }

        public string Companyname { get; set; }

        public string Ort { get; set; }

        public string Strasse { get; set; }

        public string Plz { get; set; }

        public BindingList<Customer> Customer { get; }

        public static BindingList<Company> GetDemoData()
        {
            var comp = new BindingList<Company>();
            var company = new Company {Companyname = "Bioforce", Ort = "Roggwil", Strasse = "Grunaustrasse", Plz = "9043"};
            company.Customer.Add(new Customer {Firstname = "Jakob", Lastname = "Hasler"});
            company.Customer.Add(new Customer {Firstname = "Claude", Lastname = "Sunier"});
            comp.Add(company);

            company = new Company {Companyname = "ASK", Ort = "Stein", Strasse = "Grunaustrasse", Plz = "9043"};
            company.Customer.Add(new Customer {Firstname = "Urs", Lastname = "Buchegger"});
            comp.Add(company);

            return comp;
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Company)) return Equals(obj, this);

            var company = (Company)obj;
            return string.Equals(Companyname, company.Companyname) && string.Equals(Ort, company.Ort);
        }
    }
}