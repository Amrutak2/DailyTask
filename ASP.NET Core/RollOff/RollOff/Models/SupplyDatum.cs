﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RollOff.Models
{
    public partial class SupplyDatum
    {
        public SupplyDatum()
        {
            Rolls = new HashSet<Roll>();
        }

        public string Country { get; set; }
        public double GlobalGroupId { get; set; }
        public double? EmployeeNo { get; set; }
        public string Name { get; set; }
        public string LocalGrade { get; set; }
        public string MainClient { get; set; }
        public string Email { get; set; }
        public DateTime? JoiningDate { get; set; }
        public double? ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public string PeopleManagerPerformanceReviewer { get; set; }
        public string Practice { get; set; }
        public string PspName { get; set; }
        public string NewGlobalPractice { get; set; }
        public string OfficeCity { get; set; }

        public virtual ICollection<Roll> Rolls { get; set; }
    }
}
