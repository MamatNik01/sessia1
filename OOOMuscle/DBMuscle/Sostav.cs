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
    
    public partial class Sostav
    {
        public int NomerID { get; set; }
        public int OrderID { get; set; }
        public int ArticleID { get; set; }
        public int Count { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}