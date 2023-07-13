namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Specification
    {
        public int SpecificationId { get; set; }
        public string SpecificationTitle { get; set; }
        public string SpecificationDescription { get; set; }
        public string SpecificationImageUrl { get; set; }
        public bool IsMainFeature { get; set; }

    }
}