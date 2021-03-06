//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zoo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Animal_Feed_Care
    {
        public System.Guid Animal_ID { get; set; }
        [Required]
        public Nullable<decimal> quantity_fed { get; set; }
        public System.Guid Employee_ID { get; set; }
        public string food_type { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<System.TimeSpan> time { get; set; }
        public int Record_ID { get; set; }
        public string ErrorMessage { get; set; }

        public virtual Animal Animal { get; set; }
    }
}
