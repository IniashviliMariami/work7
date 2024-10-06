using System;


namespace work7
{
    internal class Client
    {
        public string Name {  get; set; }
        public string Lastname { get; set; }

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

        public Account Account { get; set; }


        public Client(string name, string lastname, string id, Account account)
        {
            Name = name;
            Lastname = lastname;
            Id = id;
            Account = account;
           
        }
    }
}
