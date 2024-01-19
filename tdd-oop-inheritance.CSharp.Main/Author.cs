using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Author
{
        public string name, contactInformation, website;

        public Author(string name, string contactInformation, string website) 
        {
            this.name = name;
            this.contactInformation = contactInformation;
            this.website = website;
        }
}
}
