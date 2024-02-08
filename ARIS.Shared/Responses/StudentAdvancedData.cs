namespace ARIS.Shared.Responses
{
    public record StudentAdvancedData
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public FormData? Form { get; set; }
        public DateTime BirthDate { get; set; }
        public ParentData? Mother { get; set; }
        public ParentData? Father { get; set; }
        public ParentData? Guardian { get; set; }
    }
}
