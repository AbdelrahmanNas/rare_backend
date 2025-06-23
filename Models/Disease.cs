namespace RareDiseasesAPI.Models
{
    public class Disease
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Definition { get; set; }
        public string? Etiology { get; set; }
        public string? Pathophysiology { get; set; }
        public string? Symptoms { get; set; }
        public string? Complications { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public string? RiskFactors { get; set; }
        public string? Prevention { get; set; }
        public string? Lifestyle { get; set; }
        public string? EmergencyGuide { get; set; }
        public string? References { get; set; }
    }
}
