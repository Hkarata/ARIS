namespace ARIS.Shared.Responses
{
    public record FormData
    {
        public int Id { get; set; }
        public string ClassName { get; set; } = string.Empty;
        public string Stream { get; set; } = string.Empty;
    }
}
