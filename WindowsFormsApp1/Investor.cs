using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorsDB
{
    
    class Investor
    {
        String name;
        String secondName;
        String surname;
        double contractNumber;
        string address;
        double deposit;
        int term;

        public string Name { get => name; set => name = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public string Surname { get => surname; set => surname = value; }
        public double Deposit { get => deposit; set => deposit = value; }
        public int Term { get => term; set => term = value; }
        public double ContractNumber { get => contractNumber; set => contractNumber = value; }
        public string Address { get => address; set => address = value; }

        public Investor()
        {

        }

        public Investor(string name, string secondName, string surname, double contractNumber, 
            string address, double deposit, int term)
        {
            this.name = name;
            this.secondName = secondName;
            this.surname = surname;
            this.contractNumber = contractNumber;
            this.address = address;
            this.deposit = deposit;
            this.term = term;
        }

        public string toString()
        {
            return this.Name + " " + this.SecondName + " " + this.Surname + " " + " " + this.ContractNumber + " "
                + this.Address + " " + this.deposit + " " + this.term;
        }
    }
}
