using System;
using System.ComponentModel.DataAnnotations;

namespace Sepidar.Domain.Entities.Base
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
            IsActive = true;
            IsDeleted = false;
        }

        public BaseEntity(DateTime now)
        {
            CreationDate = now;
            IsActive = true;
            IsDeleted = false;
        }

        [Key]
        public Guid Id { get; set; }
        public Guid BusinessId { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
