//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_SYS_GROUP
    {
        public int GROUP { get; set; }
        public int MENBER { get; set; }
    
        public virtual tb_SYS_USER tb_SYS_USER { get; set; }
    }
}
