using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Core21_BenchApp.Models
{
    public static class BenchProperties
    {

        public static string BenchPath { get; set; } = @"C:\bench_backup_22-11-2019\";
        public static string BenchPathDefaultValue { get; set; } = @"C:\bench_backup_22-11-2019\";
        public static string CampaignsPath { get; set; } = @"C:\bench_backup_22-11-2019\Campaigns";
        public static string searchCampaignsPattern { get; set; } = "*.xcamp";
    }
}
