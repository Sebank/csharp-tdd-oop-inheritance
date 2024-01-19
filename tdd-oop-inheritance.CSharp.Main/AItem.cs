using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public abstract class AItem
{
        public string title;
        protected bool onLoan = false;

        public AItem(string title)
        {
            this.title = title;
        }
        public bool isOnLoan()
        {
            return onLoan;
        }

        public abstract string checkIn();

        public abstract string checkOut();

    }
}

