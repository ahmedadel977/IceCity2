using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCity.EFCore.Entities.contrac
{
    public interface IsSoftDeletable
    {
        public bool IsDeleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public void Delete()
        {
            IsDeleted = true;
            DateTime? dateDeleted = DateTime.Now;
        }
        public void UndoDelete()
        {
            IsDeleted = false;
            DateDeleted = null;
        }

    }


}
