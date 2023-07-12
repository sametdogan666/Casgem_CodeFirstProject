using System.Collections.Generic;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Guide
    {
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string GuideTitle { get; set; }
        public string GuideImageUrl { get; set; }
        public List<SocialMedia> SocialMedia { get; set; }
    }
}