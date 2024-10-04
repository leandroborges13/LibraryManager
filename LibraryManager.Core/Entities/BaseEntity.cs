using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            DateCreated = DateTime.Now;
            IsDeleted = false;
        }
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
