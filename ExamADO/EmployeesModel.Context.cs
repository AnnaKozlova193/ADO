﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyEmployeesEntities : DbContext
    {
        public MyEmployeesEntities()
            : base("name=MyEmployeesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Втемя_роботы_сотрудника> Втемя_роботы_сотрудника { get; set; }
        public virtual DbSet<Принятие_на_работу> Принятие_на_работу { get; set; }
        public virtual DbSet<Сотрудники> Сотрудники { get; set; }
        public virtual DbSet<Увольнение> Увольнение { get; set; }
        public virtual DbSet<Фотогафии_Сотрудников> Фотогафии_Сотрудников { get; set; }
    }
}