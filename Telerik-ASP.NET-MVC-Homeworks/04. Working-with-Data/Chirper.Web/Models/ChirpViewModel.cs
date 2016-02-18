namespace Chirper.Web.Models
{
    using System;
    using System.Collections.Generic;
    using Data.Models;
    using Infrastructure.Mapping;

    public class ChirpViewModel : IMapFrom<Chirp>
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public DateTime CreationDate { get; set; }

        public  ICollection<Tag> Tags { get; set; }

        public virtual User Creator { get; set; }
    }
}