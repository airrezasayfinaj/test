using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somepractice
{



    internal class datetimeamir
    {


        private int _year;
        private int _month;
        private int _day;
        private int _hour;
        private int _minute;
        private int _second;
        private int _microsecond;
        private int _nanosecond;
     

        public int Year
        {

            get { return _year; }

            set { _year = value; }
        }
        public int Month
        {

            get { return _month; }

            set
            {
                if (value >= 1 && value <= 12)
                    _month = value;
                //else
                //    throw new Exception("عدد ماه باید بین 1 تا 12 باشد");

            }
        }
            


        public int Day
        {
            get { return _day; }
            set
            {
                int maxValidDay;
                if (Month >= 1 && Month <= 6)
                {
                    maxValidDay = 31;

                }
                else
                {
                    maxValidDay = 30;

                }
                if (value >= 1 && value <= maxValidDay)
                {

                    _day = value;

                }


            }
        }
        public int Convertmilady()
        {
            if (Year > 622) { 
                if (IsLeapYear == false)
                { 
                    if (Month <= 10)
                    {
                        if (Day <= 10)
                        {
                            int sixtowone = 621;
                            int relyear = Year - sixtowone;
                            Year = relyear;
                            return Year;

                        }
                        else
                        {
                            int sixtowone = 621;

                            int relyear = Year - sixtowone;
                            Year = relyear;
                            return Year;

                        }
                    }
                    else
                    {
                        int relyear = Year - 622;
                        Year = relyear;
                        return Year;

                    }
                }
                else
                {
                    if (Month <= 10)
                    {
                        if (Day <= 11)
                        {
                            int relyear = Year - 621;
                            Year = relyear;
                            return Year;

                        }
                        else
                        {
                            int relyear = Year - 622;
                            Year = relyear;
                            return Year;

                        }
                    }
                    else
                    {
                        int relyear = Year - 622;
                        Year = relyear;
                        return Year;

                    }

                }
           
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        public int ConvertShamsi()
        {

            if (IsLeapYear == false)
            {
                if (Month <= 10)
                {
                    if (Day <= 10)
                    {
                        int sixtowone = 621;
                        int relyear = Year + sixtowone;
                        Year = relyear;
                        return Year;

                    }
                    else
                    {
                        int sixtowone = 621;

                        int relyear = Year + sixtowone;
                        Year = relyear;
                        return Year;

                    }
                }
                else
                {
                    int relyear = Year + 622;
                    Year = relyear;
                    return Year;

                }
            }
            else
            {
                if (Month <= 10)
                {
                    if (Day <= 11)
                    {
                        int relyear = Year + 621;
                        Year = relyear;
                        return Year;

                    }
                    else
                    {
                        int relyear = Year + 622;
                        Year = relyear;
                        return Year;

                    }
                }
                else
                {
                    int relyear = Year + 622;
                    Year = relyear;
                    return Year;

                }

            }

        }

        private int year;
        private int month;
        private int day;



        public datetimeamir(int yearf, int montht, int dayf)
        {

            year = yearf;
            month = montht;
            day = dayf;

        }

        public static datetimeamir operator +(datetimeamir a, datetimeamir b)
        {
            int d = a.day + b.day;
            if (a.month <= 6)
            {
                if (d > 31)
                {
                    int day = d % 31;
                    a.day = day;
                    int dayofmonth = d / 31;
                    int m = a.month + dayofmonth;
                    if (a.month > 12)
                    {
                        a.year++;
                    }
                }
            }
            if (a.month > 6)
            {
                if (d > 30)
                {
                    int day = d % 30;
                    a.day = day;
                    int dayofmonth = d / 30;
                    int m = a.month + dayofmonth;
                    if (a.month > 12)
                    {
                        int q = a.month % 12;
                        a.month = q;
                        a.year++;
                    }
                }
            }
            int s = a.month + b.month;
            if (s > 12)
            {
                int w = s % 12;
                a.month = w;
                a.year++;
            }
            int y = a.year + b.year;
            a.year = y;
            return new datetimeamir(a.year, a.month, a.day);
        }
        public static datetimeamir operator -(datetimeamir a, datetimeamir b)
        {
            int d = a.day - b.day;
            if (a.month <= 6)
            {
                if (d <= 0)
                {
                    int m = d + 31;
                    a.month--;
                    a.day = m;
                    if (a.month < 1)
                    {
                        a.year--;
                    }
                }
                if (d > 0)
                {
                    a.day = d;
                }
            }
            if (a.month > 6)
            {
                if (d <= 0)
                {
                    int m = d + 30;
                    a.day = m;
                    a.month--;
                    if (a.month < 1)
                    {
                        a.year--;
                    }
                }
                if (d > 0)
                {
                    a.day = d;
                }
            }
            
            int month = a.month - b.month;
            if (month > 0)
            {
                int realmonth = month % 12;
                a.month = realmonth;
                int yemonth = month / 12;
                int ye = a.year - yemonth;
                a.year = ye;
            }
            int realyear = a.year - b.year;
            a.year = realyear;
            return new datetimeamir(a.year, a.month, a.day);

        }
        public static datetimeamir operator *(datetimeamir a, datetimeamir b)
        {
            int d = a.day * b.day;
            if (a.month <= 6)
            {
                if (d > 31)
                {
                    int realday = d % 31;
                    a.day = realday;
                    int da = d / 31;
                    int dam = a.month + da;
                    a.month = dam;
                    if (a.month > 12)
                    {
                        int mo = a.month / 12;
                        int moy = a.year + mo;
                        a.year = moy;
                        int relmon = a.month % 12;
                        a.month = relmon;
                    }
                }
               // a.day = d;
            }
            if (a.month > 6)
            {
                if (d > 30)
                {
                    int realday = d % 30;
                    a.day = realday;
                    int da = d / 30;
                    int dam = a.month + da;
                    a.month = dam;
                    if (a.month > 12)
                    {
                        int mo = a.month / 12;
                        int moy = a.year + mo;
                        a.year = moy;
                        int relmon = a.month % 12;
                        a.month = relmon;
                    }
                }
              //  a.day = d;
            }
            int month = a.month * b.month;
            if (month > 12)
            {
                int mont = month / 12;
                int monthyea = a.year + mont;
                a.year = monthyea;
                int realmonth = month % 12;
                a.month = realmonth;
            }
          //  a.month = month;
            int year = a.year * b.year;
            a.year = year;
            return new datetimeamir(a.year, a.month, a.day);

        }
        public static datetimeamir operator /(datetimeamir a, datetimeamir b)
        {
            if (b.day < a.day)
            {
                int d = a.day / b.day;
                a.day = d;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
            if (a.month > b.month)
            {
                int m = a.month / b.month;
                a.month = m;
            }
            else
            {
                throw new ArgumentOutOfRangeException();

            }
            if (a.year > b.year)
            {
                int y = a.year / b.year;
                a.year = y;
            }
            else
            {
                throw new ArgumentOutOfRangeException();

            }
            return new datetimeamir(a.year, a.month, a.day);
        }
        public static datetimeamir operator <(datetimeamir a, datetimeamir b)
        {
            if (a.year < b.year)
            {
                return new datetimeamir(b.year, b.month, b.day);
            }
            else
            {
                if (a.month < b.month)
                {
                    return new datetimeamir(b.year, b.month, b.day);

                }
                else
                {
                    if (a.day < b.day)
                    {
                        return new datetimeamir(b.year, b.month, b.day);

                    }
                }
            }
            return new datetimeamir(a.year, a.month, a.day);

        }
        public static datetimeamir operator >(datetimeamir a, datetimeamir b)
        {
            if (a.year > b.year)
            {
                return new datetimeamir(a.year, a.month, a.day);

            }
            else
            {
                if (a.month > b.month)
                {
                    return new datetimeamir(a.year, a.month, a.day);

                }
                else
                {
                    if (a.day > b.day)
                    {
                        return new datetimeamir(a.year, a.month, a.day);

                    }
                }
            }
            return new datetimeamir(a.year, a.month, a.day);

        }
        public override string ToString() => $"{year} / {month} / {day}";
        public int Addday()
        {
        
            int result = Day ;
            if (Month <= 6)
            {
                int d=result % 31;
                Day = d;
                int g = result / 32;
                int m = Month + g;
                Month = m;
                if (Month > 12)
                {
                    int y = Month / 12;
                    int yea = Year + y;
                    Year = yea;
                }
            }
   
            if (Year % 33 == 1 || Year % 33 == 5 || Year % 33 == 9 || Year % 33 == 13 || Year % 33 == 17 || Year % 33 == 22 || Year % 33 == 26 || Year % 33 == 30)
            {
                if (Month == 12)
                {
                    int d = result % 30;
                    Day = d;
                }
            }
            if (Month > 6)
            {
                int d = result % 30;
                Day = d;
                int g = result / 31;
                int m = Month + g;
                Month = m;
                if (Month > 12)
                {
                    int y = Month / 12;
                    int yea = Year + y;
                    Year = yea;
                }
            }
            return result;
        }
        public int AddMonth(int month)
        {
          
            int result = Month + month;

            if (result < 12)
            {
                Month = result;
            }
            else
            {
                int formonth = result % 12;
                int Resul = result / 12;
                int ye = Year + Resul;
                Year = ye;
                Month = formonth;
            }
            return result;
        }

        public int Addyear(int year) 
        {
            int res = Year + year;
            Year = res;
            return res;
        }

        public bool IsLeapYear
        {
            get
            {

                if (Year % 33 == 1 || Year % 33 == 5 || Year % 33 == 9 || Year % 33 == 13 || Year % 33 == 17 || Year % 33 == 22 || Year % 33 == 26 || Year % 33 == 30)
                {
                    return true;
                }

                else
                {
                    return false;
                }


            }
        }


        public object equalsday
        {
            get
            {
                int MonthIndex = 0;
                switch (Month)
                {
                    case 1:
                        MonthIndex = 0;
                        break;
                    case 2:
                        MonthIndex = 3;
                        break;
                    case 3:
                        MonthIndex = 3;
                        break;
                    case 4:
                        MonthIndex = 6;
                        break;
                    case 5:
                        MonthIndex = 1;
                        break;
                    case 6:
                        MonthIndex = 4;
                        break;
                    case 7:
                        MonthIndex = 6;
                        break;
                    case 8:
                        MonthIndex = 2;
                        break;
                    case 9:
                        MonthIndex = 5;
                        break;
                    case 10:
                        MonthIndex = 0;
                        break;
                    case 11:
                        MonthIndex = 3;
                        break;
                    case 12:
                        MonthIndex = 5;
                        break;
                }
                int ye = Year;
                double yea = Year;
                int c = ye / 100;
                double q = yea / 100;
                double o = q - c;
                double p = o * 100;
                int yearindex = 0;
                int bagi = (Year - (int)p) % 4;
                switch (bagi)
                {
                    case 0:
                        yearindex = 6;
                        break;
                    case 1:
                        yearindex = 4;
                        break;
                    case 2:
                        yearindex = 2;
                        break;
                    case 3:
                        yearindex = 0;
                        break;
                }

                int year = Year;
                double w = Year;
                int reasul = year / 100;
                double res = w / 100;
                double g = res - reasul;
                double k = g * 100;
                double f = Day + MonthIndex + yearindex + k + (k / 4);
                int Result = (int)f % 7;
                string dayname = "shit";
                switch (Result)
                {
                    case 0:
                        return dayname = "sunday";
                    case 1:
                        return dayname = "monday";
                    case 2:
                        return dayname = "Tuesday";
                    case 3:
                        return dayname = "Wednesday";
                    case 4:
                        return dayname = "Thurthday";
                    case 5:
                        return dayname = "Frieday";
                    case 6:
                        return dayname = "saterday";

                    default:
                        break;
                }
                return dayname;
            }
        }


       // public struct equaldate
       // {
            //public static equaldate operator ==(equaldate a, equaldate b)
            //{
            //    if (a.year == b.year)
            //    {
            //        if (a.month == b.month)
            //        {
            //            if (a.day == b.day)
            //            {
            //                  return new equaldate(a.year, a.month, a.day);

            //            }
            //            else
            //            {
            //                throw new Exception();
            //            }
            //        }
            //        else
            //        {
            //            throw new Exception();
            //        }
            //    }
            //    else
            //    {
            //        throw new Exception();
            //    }
            //}
            //public static equaldate operator !=(equaldate a, equaldate b)
            //{
            //    if (a.year != b.year)
            //    {
            //          return new equaldate(a.year, a.month, a.day);
            //    }
            //    else
            //    {

            //        if (a.month != b.month)
            //        {
            //            return new equaldate(a.year, a.month, a.day);

            //        }
            //        else
            //        {
            //            if (a.day != b.day)
            //            {
            //                return new equaldate(a.year, a.month, a.day);

            //            }
            //            else
            //            {
            //                throw new Exception();

            //            }
            //        }
            //    }
            //}


            //switch (Symbol)
            //{
            //    case "-":
            //        int resul = Day - dayformines;

            //        if (Month <= 6)
            //        {
            //            if (resul <= 0)
            //            {
            //                Month--;
            //            }
            //            int realday = resul + 31;
            //            Day = realday;

            //        }
            //        else if (Month > 6)
            //        {
            //            if (resul <= 0)
            //            {
            //                Month--;
            //            }
            //            int realday = resul + 30;
            //            Day = realday;

            //            if (dayformines == 31 && Day == 1 && Month > 6)
            //            {
            //                int realmonth = Month - 2;
            //                Month = realmonth;
            //                if (Month <= 0)
            //                {
            //                    Year--;
            //                    Month = 12;
            //                }
            //            }
            //        }
            //        Day = resul;



            //        // return Day;
            //        int monthresul = Month - monthformines;
            //        if (monthresul <= 0)
            //        {
            //            Year--;
            //            int realmonth = monthresul + 12;
            //            Month = realmonth;
            //            return Month;

            //        }
            //        else
            //        {
            //            Month = monthresul;

            //        }
            //        //return Month;
            //        int yearresult = Year - yearformines;
            //        if (yearresult < 0)
            //        {
            //            return "this year is unvailible";
            //        }
            //        else
            //        {
            //            Year = yearresult;

            //        }
            //        return "don";
            //    case "+":
            //        int resday = Day + dayformines;
            //        if (resday < 31 && Month<7)
            //        {
            //            Day = resday;
            //        }
            //        if (resday < 32 && Month > 6)
            //        {
            //            Day = resday;
            //        }
            //        if (Month <= 6 && resday>=31)
            //        {
            //            int realday = resday % 31;
            //            Day = resday;
            //            Month++;
            //        }
            //        else if(Month>6 && resday >= 30)
            //        {
            //            int realday = resday % 30;
            //            Day = realday;
            //            Month++;
            //            if (Month > 12)
            //            {
            //                Year++;
            //            }
            //        }
            //        else if(Month==6 && Day==31 && dayformines==31)
            //        {
            //            int realday = resday % 30;
            //            Day = resday;
            //            Month= Month + 2;
            //            if (Month > 12)
            //            {
            //                Year++;
            //            }
            //        }
            //        int resmonth = Month + monthformines;
            //        if (resmonth < 13)
            //        {
            //            Month = resmonth;

            //        }
            //        if (resmonth > 12)
            //        {
            //            Month = resmonth % 12;
            //            Year++;
            //        }
            //        else if(Month==12 && monthformines == 12)
            //        {
            //            Month = 12;
            //            Year++;
            //        }
            //        Month = resmonth;
            //        int resyear = Year + yearformines;
            //        Year = resyear;
            //        return "don";
            //    case">":

            //        if (Year > yearformines)
            //        {
            //           return("yes its biger");
            //        }
            //        if (Year == yearformines)
            //        {
            //            if (Month > monthformines)
            //            {
            //                Console.WriteLine("yes its biger");
            //            }
            //        }
            //        if(Year==yearformines && Month == monthformines)
            //        {
            //            if (Day > dayformines)
            //            {
            //                Console.WriteLine("yes its biger");
            //            }
            //        }
            //        if (Year == yearformines && Month == monthformines && Day == dayformines)
            //        {
            //            Console.WriteLine("these are equal");
            //        }
            //        return "don";

            //    case "<":
            //        if (Year < yearformines)
            //        {
            //            return ("yes its biger");
            //        }
            //        if (Year == yearformines)
            //        {
            //            if (Month < monthformines)
            //            {
            //                Console.WriteLine("yes its biger");
            //            }
            //        }
            //        if (Year == yearformines && Month == monthformines)
            //        {
            //            if (Day < dayformines)
            //            {
            //                Console.WriteLine("yes its biger");
            //            }
            //        }
            //        if (Year == yearformines && Month == monthformines && Day == dayformines)
            //        {
            //            Console.WriteLine("these are equal");
            //        }
            //        return "don";
            //    case "=":
            //        if(Year== yearformines && Month==monthformines&& Day == dayformines)
            //        {
            //            Console.WriteLine("yes these date are equal");
            //        }
            //        else
            //        {
            //            Console.WriteLine("no these date are not equal");

            //        }
            //        return "don";

            //    default:
            //        break;
            //}

            // return "don";


     //   }
    }
    
}
