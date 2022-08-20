//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Employees = new HashSet<Employee>();
            this.Finance_payment_histories = new HashSet<Finance_payment_histories>();
            this.Invoices = new HashSet<Invoice>();
            this.Leave_requests = new HashSet<Leave_requests>();
            this.Liabilities = new HashSet<Liability>();
        }
    
        public int id { get; set; }
        public string profile_pic { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string position { get; set; }
        public string type { get; set; }
        public string password { get; set; }
        public Nullable<int> organization_id { get; set; }
        public string user_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Finance_import_histories Finance_import_histories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Finance_payment_histories> Finance_payment_histories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave_requests> Leave_requests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Liability> Liabilities { get; set; }
    }
}
