using System;

namespace Casgem_CodeFirstProject.DAL.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime MessageDate { get; set; }
    }
}