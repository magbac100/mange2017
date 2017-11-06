using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactsApi.Models
{
    public class person
    {


        public string pers(int a)
        {
            db d = new db();
            string i = d.db1(a);
            //string firstName = a;
            //string lastName = "Backan";
            //string perso = firstName + " " + lastName;
            return i;
        }
    }
}