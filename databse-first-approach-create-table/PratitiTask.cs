//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace databse_first_approach_create_table
{
    using System;
    using System.Collections.Generic;
    
    public partial class PratitiTask
    {
        public int PratitiTaskId { get; set; }
        public string PratitiTaskHeading { get; set; }
        public string PratitiTaskDescription { get; set; }
        public string PratitiTaskAssignedBy { get; set; }
        public string PratitiTaskAssignedTo { get; set; }
        public System.DateTime PratitiTaskAssignedDate { get; set; }
        public int PratitiTaskDays { get; set; }
        public System.DateTime PratitiTaskDeadLineDate { get; set; }
    }
}
