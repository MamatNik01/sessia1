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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.Sostav = new HashSet<Sostav>();
        }
    
        public int ArticleID { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Sale { get; set; }
        public int ProizvoditelID { get; set; }
        public int PostavshikID { get; set; }
        public int CategoryID { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Postavshik Postavshik { get; set; }
        public virtual Proizvoditel Proizvoditel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sostav> Sostav { get; set; }
    }
}