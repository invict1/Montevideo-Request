using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using IMMRequest.Domain;
using System.Linq;
using System;
using IMMRequest.Exceptions;

namespace IMMRequest.DataAccess
{
    public class TopicRepository : BaseRepository<Topic, Area>
    {
        private readonly DbSet<Topic> dbSetTopic;
        public TopicRepository(DbContext context) 
        {
            this.Context = context;
            this.dbSetTopic = context.Set<Topic>();
        }

        public override Topic Get(Guid id)
        {
            try
            {
                return Context.Set<Topic>()
               .Include(topic => topic.Types)
               .ThenInclude(type => type.AdditionalFields)
               .ThenInclude(additionalField => additionalField.Ranges)
               .First(topic => topic.Id == id);
            }
            catch (InvalidOperationException)
            {
                throw new ExceptionController(DataAccessExceptions.NOT_FOUND_TOPIC);
            }
        }

        public override IEnumerable<Topic> GetAll()
        {
            return Context.Set<Topic>()
            .Include(topic => topic.Types)
            .ThenInclude(type => type.AdditionalFields)
            .ThenInclude(additionalField => additionalField.Ranges)
            .ToList();
        }
        public override Area GetParent(Guid id)
        {
            return Context.Set<Area>()
            .Include( area => area.Topics)
            .First(area => area.Id == id);
        }

        public override bool Exist(Topic topic)
        {
            Topic topicToFind = Context.Set<Topic>().Where(a => a.Id == topic.Id).FirstOrDefault();
            return !(topicToFind == null);
        }
    }
}
