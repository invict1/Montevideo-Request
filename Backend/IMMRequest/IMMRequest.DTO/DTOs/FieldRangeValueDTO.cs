using IMMRequest.Domain;
using System;

namespace IMMRequest.DTO
{
    public class FieldRangeValueDTO : DTO<AdditionalFieldValue, FieldRangeValueDTO>
    {
        public Guid Id { get; set; }
        public Guid RequestId { get; set; }
        public Guid AdditionalFieldId { get; set;}
        public string Value { get; set; }

        public FieldRangeValueDTO() { }

        public FieldRangeValueDTO(AdditionalFieldValue entity)
        {
            SetModel(entity);
        }

        public override AdditionalFieldValue ToEntity() => new AdditionalFieldValue()
        {
            Id = this.Id,
            RequestId = this.RequestId,
            AdditionalFieldId = this.AdditionalFieldId,
            Value = this.Value
        };

        protected override FieldRangeValueDTO SetModel(AdditionalFieldValue entity)
        {
            Id = entity.Id;
            RequestId = entity.RequestId;
            AdditionalFieldId = entity.AdditionalFieldId;
            Value = entity.Value;
            
            return this;
        }
    }
}