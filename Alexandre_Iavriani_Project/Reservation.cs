//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Alexandre_Iavriani_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int reservation_id { get; set; }
        public string name { get; set; }
        public string lname { get; set; }
        public Nullable<long> personalNumber { get; set; }
        public string phone { get; set; }
        public Nullable<int> country_id { get; set; }
        public Nullable<int> manager_id { get; set; }
        public Nullable<int> airline_id { get; set; }
    
        public virtual Airline Airline { get; set; }
        public virtual Country Country { get; set; }
        public virtual Manager Manager { get; set; }
    }
}
