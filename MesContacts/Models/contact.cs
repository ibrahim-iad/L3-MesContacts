//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MesContacts.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class contact
    {
        public int id { get; set; }
        [Required]
        public string nom { get; set; }
        [Required]
        public string telephone { get; set; }
        public string email { get; set; }
        [Required]
        public Nullable<int> groupe_id { get; set; }
    
        public virtual groupe groupe { get; set; }
    }
}