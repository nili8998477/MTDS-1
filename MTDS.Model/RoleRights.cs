//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTDS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class RoleRights
    {
        public System.Guid RoleId { get; set; }
        public Nullable<System.Guid> ModuleID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public string ModifyBy { get; set; }
    }
}