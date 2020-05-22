﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RCCS.DatabaseCitizenResidency.Model
{
    public class CitizenOverview
    {
        [Key]
        public int Id { get; set; }
        public string CareNeed { get; set; }
        public string PurposeOfStay { get; set; }
        public int NumberOfReevaluations { get; set; }

        [JsonIgnore]
        public Citizen Citizen { get; set; }
        public long CitizenCPR { get; set; }
    }
}
