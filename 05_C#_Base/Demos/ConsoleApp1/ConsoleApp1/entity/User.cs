using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.entity
{
    internal class User
    {
        private int? _id;
        private string _name;
        private string _email;
        private int _age;

        public int? Id { get; set ; }
        public string Name { get => _name;  set => _name = value;}
        public string Email { get => _email; set => _email = value;}
        public int Age { get => _age; set => _age = value;}

        public User() { }
        public User(int? id, string name, string email, int age)
        {
            Id = id;
            Name = name;
            Email = email;
            Age = age;
        }

        public override string ToString()
        {
            return $"Nom : {Name}, Email : {Email}, Age : {Age}";
        }
    }
}
