//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOOMuscle.DBMuscle
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Sostav = new HashSet<Sostav>();
        }
    
        public int OrderID { get; set; }
        public System.DateTime DataZakaza { get; set; }
        public System.DateTime DataDostavki { get; set; }
        public string FIO { get; set; }
        public int Code { get; set; }
        public int AddressID { get; set; }
        public int StatusID { get; set; }
    
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sostav> Sostav { get; set; }
        public virtual Status Status { get; set; }
    }
}
