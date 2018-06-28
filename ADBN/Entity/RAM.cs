//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADBN.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class RAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RAM()
        {
            this.NoteBook = new HashSet<NoteBook>();
            this.PC = new HashSet<PC>();
        }
    
        public int Id { get; set; }
        public string manufacture { get; set; }
        public Nullable<int> value { get; set; }
        public Nullable<int> frequency { get; set; }
        public Nullable<int> cost { get; set; }
        public Nullable<int> DDR_generationID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoteBook> NoteBook { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PC> PC { get; set; }
        public virtual MemoryGeneration MemoryGeneration { get; set; }
    }
}