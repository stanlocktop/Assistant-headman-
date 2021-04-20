using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assistant
{
    class Check
    {
        public string Name;
        public string Surrname;
        public string money;
        public bool checkname;
        public bool checkmoney;
        public Check()
        {
            Name = " ";
            Surrname = " ";
            money = " ";
            checkname = true;
            checkmoney = true;
        }
        public string CheckName(string _Name, string _Surrname)
        {
            Regex reg = new Regex("[a-zA-Zа-яА-Я]$");
            if (reg.Match(_Name).Success && reg.Match(_Surrname).Success)
            {
                checkname = true;
            }
            else
            {
                checkname = false;
            }
            return " ";

        }
        public string CheckMoney(string _money)
        {
            Regex reg = new Regex("[a-zA-Zа-яА-Я]$");
            if (reg.Match(_money).Success)
            {
                checkmoney = false;
            }
            else
            {
                checkmoney = true;
            }
            return " ";
        }
    }
}

