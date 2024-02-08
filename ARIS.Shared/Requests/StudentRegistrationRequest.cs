namespace ARIS.Shared.Requests
{
    public record StudentRegistrationRequest
    {
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; }
        public string MothersName { get; set; } = string.Empty;
        public string FathersName { get; set; } = string.Empty;
        public string GuardiansName { get; set; } = string.Empty;
        public string MothersPhoneNumber { get; set; } = string.Empty;
        public string FathersPhoneNumber { get; set; } = string.Empty;
        public string GuardiansPhoneNumber { get; set; } = string.Empty;
    }
}
