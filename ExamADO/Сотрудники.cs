//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamADO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Сотрудники
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Сотрудники()
        {
            this.Втемя_роботы_сотрудника = new HashSet<Втемя_роботы_сотрудника>();
            this.Принятие_на_работу = new HashSet<Принятие_на_работу>();
            this.Увольнение = new HashSet<Увольнение>();
            this.Фотогафии_Сотрудников = new HashSet<Фотогафии_Сотрудников>();
        }
    
        public int Id { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public System.DateTime Дата_рождения { get; set; }
        public string Должность { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Втемя_роботы_сотрудника> Втемя_роботы_сотрудника { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Принятие_на_работу> Принятие_на_работу { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Увольнение> Увольнение { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Фотогафии_Сотрудников> Фотогафии_Сотрудников { get; set; }

       
        public override string ToString()
        {
            return $"{Id} {Фамилия} {Имя} {Отчество} {Дата_рождения} {Должность}";
        }

    }
}
