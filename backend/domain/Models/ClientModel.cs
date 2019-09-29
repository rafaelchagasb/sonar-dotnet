using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace domain.Models
{
    public class ClientModel
    {
        public string FullName { get; set; }

        public string FirstName {
            get
            {
                return this.FullName.Split(" ").First();
            }
        }
    }
}
