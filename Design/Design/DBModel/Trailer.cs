//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Design.DBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trailer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trailer()
        {
            this.TrailerDriver = new HashSet<TrailerDriver>();
        }
    
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public string CarCompany { get; set; }
        public string CarNumber { get; set; }
        public int Сarrying { get; set; }
        public decimal FuelConsumption { get; set; }
        public decimal Length { get; set; }
        public decimal CostDelivery { get; set; }
        public Nullable<int> Experience { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrailerDriver> TrailerDriver { get; set; }
    }
}
