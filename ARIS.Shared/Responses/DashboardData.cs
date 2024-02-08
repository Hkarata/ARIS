namespace ARIS.Shared.Responses
{
    public record DashboardData
    {
        public int NumberOfStudents { get; set; }
        public int NumberOfGirls { get; set; }
        public int NumberOfBoys { get; set; }
        public int NumberOfReports { get; set; }
        public int NumberOfSick { get; set; }
        public int NumberOfAdmitted { get; set; }
        public int NumberOfOutpatient { get; set; }
    }
}
