using System.Collections.Generic;
using IMMRequest.Domain;
using System.Linq;
using System;

namespace IMMRequest.WebApi.Models
{
    public class TopicModel : Model<Topic, TopicModel>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TypeModel> Types { get; set; }

        public TopicModel() 
        {
            Types = new List<TypeModel>();
        }

        public TopicModel(Topic entity)
        {
            SetModel(entity);
        }

        public override Topic ToEntity() => new Topic()
        {
            Id = this.Id,
            Name = this.Name,
            Types = this.Types.ToList().ConvertAll(m => m.ToEntity())
        };

        protected override TopicModel SetModel(Topic entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Types = entity.Types.ToList().ConvertAll(m => new TypeModel(m));
            return this;
        }
    }
}