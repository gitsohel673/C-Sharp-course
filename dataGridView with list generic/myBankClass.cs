using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class myBankClass
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public  long Balance { get; set; }

        public myBankClass(string Owner)
        {
            this.Owner = Owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;    
        }

    }
}
