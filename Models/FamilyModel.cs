namespace Lab_AutoMapper.Models
{
    public class FamilyModel
    {
        public string Address { get; set; } = string.Empty;
        public List<PersonModel>? Member { get; set; }
    }
}
