using System;
using System.Collections.Generic;

namespace IMMRequest.Domain
{
    public class Request
    {
        public Guid Id { get; set; }
        public string State { get; set; }
        public string RequestorsName { get; set; }
        public string RequestorsEmail { get; set; }
        public string RequestorsPhone { get; set; }
        public string Description { get; set; }
        public TypeEntity Type { get; set; }
        public Guid TypeId { get; set; }
        public ICollection<FieldRangeValue> FieldRangeValues { get; set; }

        public Request()
        {
            this.Id = Guid.NewGuid();
        }

        public Request(string RequestorsName, string RequestorsEmail, string RequestorsPhone, 
        TypeEntity Type, string State, string Description, List<FieldRangeValue> FieldRangeValues) 
        {
            this.Id = Guid.NewGuid();
            this.RequestorsName = RequestorsName;
            this.RequestorsEmail = RequestorsEmail;
            this.RequestorsPhone = RequestorsPhone;
            this.Type = Type;
            this.State = State;
            this.Description = Description;
            this.FieldRangeValues = FieldRangeValues;
        }

        public bool IsValid() 
        {
            return true;
        }

        public override bool Equals(Object obj) 
        {
			Request request = obj as Request;
			bool equals = false;
			if (obj == null) {
				equals = false;
			}
			else {
				equals = this.RequestorsName == request.RequestorsName 
                && this.RequestorsEmail == request.RequestorsEmail
                && this.RequestorsPhone == request.RequestorsPhone
                && this.TypeId == request.TypeId
                && this.State == request.State
                && this.Description == request.Description;
			}
			return equals;
		}
    }
}
