using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class DbStorage
    {
        public List<Person> people = new List<Person>(){
            new Person() { Id = 1 , Name="Zahra" , Nationalcode="adsfasfd"},
            new Person() { Id = 2 ,Name = "fariba" , Nationalcode ="asdfaf"},
            new Person() { Id = 3 ,Name="Zhina" , Nationalcode ="afdasfas"}
    };
    }
}
