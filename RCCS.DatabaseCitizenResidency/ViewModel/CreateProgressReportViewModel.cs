﻿namespace RCCS.DatabaseCitizenResidency.ViewModel
{
    public class CreateProgressReportViewModel
    {
        //Citizen
        public long CPR { get; set; }
        
        //ProgressReport
        public string Title { get; set; }
        public string Report { get; set; }
        public string ResponsibleCaretaker { get; set; }

        
    }
}
