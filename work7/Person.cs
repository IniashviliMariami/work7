using System;


namespace work7
{
    public class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }

        private int age;

      public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value >0)
                {
                    age = value;
                }
            }

        }

        private string id;
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if(value.Length == 11) 
                { 
                    id = value;
                }
            }
        }

        public string Phone { get; set; }
        public string Mail { get; set; }
     
        
        public Person(string name, string lastname, int age, string id, string phone, string mail) 
        {
            Name = name;
            Lastname = lastname;
            Age = age;
            Id = id;
            Phone = phone;
            Mail = mail;
        }


    }
}
