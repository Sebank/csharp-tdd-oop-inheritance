﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_inheritance.CSharp.Main
{
    public class Library {
        List<AItem> items = new List<AItem>();

        public void addToStock(AItem item)
        {
            this.items.Add(item);
        }

        // The following methods may contain code that you are unfamiliar with. The strange syntax of article -> something
        // is called a lambda expression (https://www.w3schools.com/java/java_lambda.asp)

        public string checkIn(string title)
        {
            List<AItem> filtered = this.items.Where(item => item.title.Equals(title)).ToList();

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkIn();
        }

        public string checkOut(string title)
        {
            List<AItem> filtered = this.items.Where(item => item.title.Equals(title)).ToList();

            if (filtered.Count() < 1)
            {
                return "item is not part of the library's collection";
            }

            return filtered[0].checkOut();
        }
    }
}
