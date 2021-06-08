using NTierProject.CORE.Entity.Abstract;
using NTierProject.CORE.Enum;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace NTierProject.CORE.Entity.Concrete
{
    public class CoreEntity : IEntity<Guid>
    {
        public CoreEntity()
        {
            this.Status = Status.None;
            this.CreatedDate = DateTime.Now;
            this.CreatedADUserName = WindowsIdentity.GetCurrent().Name;
            this.CreatedComputerName = Environment.MachineName;
            this.CreatedIP = "127.0.0.1";
            this.CreatedBy = 1;
        }


        public Guid ID { get; set; }
        public Guid? MasterID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Status Status { get; set; }



        public string CreatedComputerName { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedADUserName { get; set; }
        public int? CreatedBy { get; set; }



        public DateTime? ModifiedDate { get; set; }
        public string ModifiedComputerName { get; set; }
        public string ModifiedIP { get; set; }
        public string ModifiedADUserName { get; set; }
        public int? ModifiedBy { get; set; }
        

    }
}
