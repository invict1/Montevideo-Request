using System.Collections.Generic;

namespace IMMRequest.Domain
{
    public class Topic
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public Area Area { get; set; }
        
        public virtual ICollection<Type> Types { get; set; }

        public Topic() 
        {
            this.Types = new List<Type>();
        }
    }
}
