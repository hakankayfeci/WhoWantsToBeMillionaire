//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IOT.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class User
    {
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string TcNo { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string Job { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string RoleName { get; set; }
    }
}
