namespace ARIS.Shared.Responses
{
    public record StudentBasicData
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string MiddleName { get; set; }
        public required string LastName { get; set; }
        public required string Gender { get; set; }
        public required DateTime BirthDate { get; set; }
    }
}
