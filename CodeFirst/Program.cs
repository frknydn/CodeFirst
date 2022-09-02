using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Program
    {
        PersonRepository personRepository;
        static void Main(string[] args)
        {


            personRepository = new PersonRepository();


        }

        public void button1_Clicl()
        {
            Person person = new Person();
            person.Name = textbox1.Text;



            personRepository.Add(person);
        }
    }
}
