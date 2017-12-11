using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSI.Mobile.SD.UWP.ViewModels
{
    public class LaborLog
    {
        public string SubmitStatus { get; set; }
        public DateTime Date { get; set; }
        public string Technician { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int BillingHours { get; set; }
        public string Description { get; set; }
        public string Equipment { get; set; }
        public double HourlyCost { get; set; }
        public string PriceLevel { get; set; }
        public double BillingRate { get; set; }
        public string Shift { get; set; }
        public string Phase { get; set; }
        public string CostCode { get; set; }
        public string EarnCode { get; set; }
        public double PayrollHours { get; set; }
    }

    public class LaborLogManager
    {
        public static List<LaborLog> GetLaborLog()
        {
            var laborLogs = new List<LaborLog>();

            laborLogs.Add(new LaborLog
            {
                SubmitStatus = "S",
                Date = new DateTime(2017, 11, 27),
                Technician = "Jim Jam",
                StartTime = "9:00",
                EndTime = "10:00",
                BillingHours = 1,
                Description = "Did lots of work",
                Equipment = "None",
                HourlyCost = 50.50,
                PriceLevel = "2 - big moneys",
                BillingRate = 1,
                Shift = "reg",
                Phase = "0 - No phase",
                CostCode = "1200",
                EarnCode = "REG",
                PayrollHours = 1
            });
            laborLogs.Add(new LaborLog
            {
                SubmitStatus = "N",
                Date = new DateTime(2017, 11, 27),
                Technician = "Mike Orange",
                StartTime = "9:00",
                EndTime = "10:00",
                BillingHours = 2,
                Description = "Worked it real good",
                Equipment = "None",
                HourlyCost = 25.50,
                PriceLevel = "1 - Normal moneys",
                BillingRate = 1,
                Shift = "reg",
                Phase = "0 - No phase",
                CostCode = "1700",
                EarnCode = "REG",
                PayrollHours = 1
            });
            laborLogs.Add(new LaborLog
            {
                SubmitStatus = "S",
                Date = new DateTime(2017, 11, 27),
                Technician = "Mr Green",
                StartTime = "11:00",
                EndTime = "12:00",
                BillingHours = 1,
                Description = "Did lots of work",
                Equipment = "None",
                HourlyCost = 25.50,
                PriceLevel = "1 - Normal moneys",
                BillingRate = 1,
                Shift = "reg",
                Phase = "0 - No phase",
                CostCode = "200",
                EarnCode = "REG",
                PayrollHours = 1
            });
            laborLogs.Add(new LaborLog
            {
                SubmitStatus = "S",
                Date = new DateTime(2017, 11, 27),
                Technician = "Larry Loud",
                StartTime = "8:00",
                EndTime = "10:00",
                BillingHours = 2,
                Description = "Worked on things AND stuff",
                Equipment = "None",
                HourlyCost = 75.50,
                PriceLevel = "3 - Extra big moneys",
                BillingRate = 1,
                Shift = "reg",
                Phase = "0 - No phase",
                CostCode = "2700",
                EarnCode = "REG",
                PayrollHours = 2
            });

            return laborLogs;

        }
    }
}
