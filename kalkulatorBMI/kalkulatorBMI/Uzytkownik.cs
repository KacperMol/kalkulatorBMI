using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulatorBMI
{
    public class Uzytkownik
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Imie {  get; set; }   
        public string Nazwisko {  get; set; }   
        public double BMI {  get; set; }   

    }
}
