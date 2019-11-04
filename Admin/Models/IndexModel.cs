using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class IndexModel
    {
        public List<WeekSales> WeekUserEntry { get; set; }
        public List<MonthSales> MonthSales { get; set; }
        public List<MonthRegister> MonthRegister { get; set; }
        public List<TopCategory> TopCategory { get; set; }
        public List<User> Users { get; set; }

        public int UserCount { get; set; }
        public int YearUserEntryCount { get; set; }

        public int SurveyCount { get; set; }
        public int VoteYearCount { get; set; }
    }

    public class WeekSales
    {
        public string Day { get; set; }
        public double Income { get; set; }
    }
    public class MonthSales
    {
        public string  Month { get; set; }
        public double  Income { get; set; }
    }
    public class MonthRegister
    {
        public string Month { get; set; }
        public string  No { get; set; }
    }

    public class TopCategory
    {
        public string Sale { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}


