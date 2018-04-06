namespace RC.FacElecCol.ModeloDatos
{
    using System.Data.Entity;    

    public class RentingModel : DbContext
    {
        // Your context has been configured to use a 'RentingFeCoModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Renting.FeCo.ModeloDatos.RentingModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'RentingModel' 
        // connection string in the application configuration file.
        public RentingModel() : base("name=RentingFeCoModel")
        {
        }

        //// Add a DbSet for each entity type that you want to include in your model. For more information 
        //// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        //public virtual DbSet<FeCoTareas> FeCoTareas { get; set; }
        //public virtual DbSet<FeCoActividades> FeCoActividades { get; set; }
        //public virtual DbSet<FeCoEstadosActividades> FeCoEstadosActividades { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<FeCoEstadosActividades>()
        //        .Property(e => e.NombreEstado)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FeCoEstadosActividades>()
        //        .HasMany(e => e.Actividad)
        //        .WithOptional(e => e.EstadoActividad)
        //        .HasForeignKey(e => e.CodigoEstado);

        //    modelBuilder.Entity<FeCoTareas>()
        //        .Property(e => e.NombreTarea)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<FeCoTareas>()
        //        .HasMany(e => e.Actividad)
        //        .WithOptional(e => e.Tarea)
        //        .HasForeignKey(e => e.CodigoTarea);

            
        //}
    }
}

