﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VuelaWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<cuenta> cuenta { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<equipaje> equipaje { get; set; }
        public virtual DbSet<lineavuelo> lineavuelo { get; set; }
        public virtual DbSet<pais> pais { get; set; }
        public virtual DbSet<pase> pase { get; set; }
        public virtual DbSet<vuelo> vuelo { get; set; }
        public virtual DbSet<bitacoravueloscliente> bitacoravueloscliente { get; set; }
    
        public virtual int cancelarVuelo(Nullable<int> idPase, string pasaporte)
        {
            var idPaseParameter = idPase.HasValue ?
                new ObjectParameter("idPase", idPase) :
                new ObjectParameter("idPase", typeof(int));
    
            var pasaporteParameter = pasaporte != null ?
                new ObjectParameter("pasaporte", pasaporte) :
                new ObjectParameter("pasaporte", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cancelarVuelo", idPaseParameter, pasaporteParameter);
        }
    
        public virtual int checkIn(Nullable<int> idPase, string pasaporte)
        {
            var idPaseParameter = idPase.HasValue ?
                new ObjectParameter("idPase", idPase) :
                new ObjectParameter("idPase", typeof(int));
    
            var pasaporteParameter = pasaporte != null ?
                new ObjectParameter("pasaporte", pasaporte) :
                new ObjectParameter("pasaporte", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("checkIn", idPaseParameter, pasaporteParameter);
        }
    
        public virtual ObjectResult<consultaBitacoraVuelos_Result> consultaBitacoraVuelos(string cliente)
        {
            var clienteParameter = cliente != null ?
                new ObjectParameter("cliente", cliente) :
                new ObjectParameter("cliente", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaBitacoraVuelos_Result>("consultaBitacoraVuelos", clienteParameter);
        }
    
        public virtual ObjectResult<consultaGeneralVuelos_Result> consultaFitradaVuelos(string nbrPaisOrigen, string nbrPaisDestino)
        {
            var nbrPaisOrigenParameter = nbrPaisOrigen != null ?
                new ObjectParameter("nbrPaisOrigen", nbrPaisOrigen) :
                new ObjectParameter("nbrPaisOrigen", typeof(string));
    
            var nbrPaisDestinoParameter = nbrPaisDestino != null ?
                new ObjectParameter("nbrPaisDestino", nbrPaisDestino) :
                new ObjectParameter("nbrPaisDestino", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaGeneralVuelos_Result>("consultaFitradaVuelos", nbrPaisOrigenParameter, nbrPaisDestinoParameter);
        }
    
        public virtual ObjectResult<consultaGeneralVuelos_Result> consultaGeneralVuelos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaGeneralVuelos_Result>("consultaGeneralVuelos");
        }
    
        public virtual ObjectResult<Nullable<int>> insertarAdministrador(Nullable<decimal> idEmpleado, string usuario, string nombre, string clave)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("idEmpleado", idEmpleado) :
                new ObjectParameter("idEmpleado", typeof(decimal));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("insertarAdministrador", idEmpleadoParameter, usuarioParameter, nombreParameter, claveParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> insertarCliente(string nbrUsuario, string clave, string nombre, string correo, Nullable<int> paisResidencia, string pasaporte)
        {
            var nbrUsuarioParameter = nbrUsuario != null ?
                new ObjectParameter("nbrUsuario", nbrUsuario) :
                new ObjectParameter("nbrUsuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("clave", clave) :
                new ObjectParameter("clave", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("correo", correo) :
                new ObjectParameter("correo", typeof(string));
    
            var paisResidenciaParameter = paisResidencia.HasValue ?
                new ObjectParameter("paisResidencia", paisResidencia) :
                new ObjectParameter("paisResidencia", typeof(int));
    
            var pasaporteParameter = pasaporte != null ?
                new ObjectParameter("pasaporte", pasaporte) :
                new ObjectParameter("pasaporte", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("insertarCliente", nbrUsuarioParameter, claveParameter, nombreParameter, correoParameter, paisResidenciaParameter, pasaporteParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> insertarEquipaje(Nullable<int> idEquipaje, string pasaporte, Nullable<decimal> peso, Nullable<int> idLineaVuelo)
        {
            var idEquipajeParameter = idEquipaje.HasValue ?
                new ObjectParameter("idEquipaje", idEquipaje) :
                new ObjectParameter("idEquipaje", typeof(int));
    
            var pasaporteParameter = pasaporte != null ?
                new ObjectParameter("pasaporte", pasaporte) :
                new ObjectParameter("pasaporte", typeof(string));
    
            var pesoParameter = peso.HasValue ?
                new ObjectParameter("peso", peso) :
                new ObjectParameter("peso", typeof(decimal));
    
            var idLineaVueloParameter = idLineaVuelo.HasValue ?
                new ObjectParameter("idLineaVuelo", idLineaVuelo) :
                new ObjectParameter("idLineaVuelo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("insertarEquipaje", idEquipajeParameter, pasaporteParameter, pesoParameter, idLineaVueloParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> insertarLineaVuelo(Nullable<int> idLineaVuelo, Nullable<int> idVuelo, Nullable<System.DateTime> horaPartida, Nullable<System.DateTime> horaLlegada, Nullable<decimal> cantEscalas, Nullable<decimal> precio)
        {
            var idLineaVueloParameter = idLineaVuelo.HasValue ?
                new ObjectParameter("idLineaVuelo", idLineaVuelo) :
                new ObjectParameter("idLineaVuelo", typeof(int));
    
            var idVueloParameter = idVuelo.HasValue ?
                new ObjectParameter("idVuelo", idVuelo) :
                new ObjectParameter("idVuelo", typeof(int));
    
            var horaPartidaParameter = horaPartida.HasValue ?
                new ObjectParameter("horaPartida", horaPartida) :
                new ObjectParameter("horaPartida", typeof(System.DateTime));
    
            var horaLlegadaParameter = horaLlegada.HasValue ?
                new ObjectParameter("horaLlegada", horaLlegada) :
                new ObjectParameter("horaLlegada", typeof(System.DateTime));
    
            var cantEscalasParameter = cantEscalas.HasValue ?
                new ObjectParameter("cantEscalas", cantEscalas) :
                new ObjectParameter("cantEscalas", typeof(decimal));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("precio", precio) :
                new ObjectParameter("precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("insertarLineaVuelo", idLineaVueloParameter, idVueloParameter, horaPartidaParameter, horaLlegadaParameter, cantEscalasParameter, precioParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> insertarPaseAbordar(Nullable<int> idPase, Nullable<int> idLineaVuelo, string numeroAsiento, string pasaporte)
        {
            var idPaseParameter = idPase.HasValue ?
                new ObjectParameter("idPase", idPase) :
                new ObjectParameter("idPase", typeof(int));
    
            var idLineaVueloParameter = idLineaVuelo.HasValue ?
                new ObjectParameter("idLineaVuelo", idLineaVuelo) :
                new ObjectParameter("idLineaVuelo", typeof(int));
    
            var numeroAsientoParameter = numeroAsiento != null ?
                new ObjectParameter("numeroAsiento", numeroAsiento) :
                new ObjectParameter("numeroAsiento", typeof(string));
    
            var pasaporteParameter = pasaporte != null ?
                new ObjectParameter("pasaporte", pasaporte) :
                new ObjectParameter("pasaporte", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("insertarPaseAbordar", idPaseParameter, idLineaVueloParameter, numeroAsientoParameter, pasaporteParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> insertarVuelo(Nullable<int> idVuelo, Nullable<int> paisOrigen, Nullable<int> paisDestino)
        {
            var idVueloParameter = idVuelo.HasValue ?
                new ObjectParameter("idVuelo", idVuelo) :
                new ObjectParameter("idVuelo", typeof(int));
    
            var paisOrigenParameter = paisOrigen.HasValue ?
                new ObjectParameter("paisOrigen", paisOrigen) :
                new ObjectParameter("paisOrigen", typeof(int));
    
            var paisDestinoParameter = paisDestino.HasValue ?
                new ObjectParameter("paisDestino", paisDestino) :
                new ObjectParameter("paisDestino", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("insertarVuelo", idVueloParameter, paisOrigenParameter, paisDestinoParameter);
        }
    
        public virtual int cambiarVuelo(Nullable<int> idPase, string pasaporte, Nullable<int> idLineaVuelo)
        {
            var idPaseParameter = idPase.HasValue ?
                new ObjectParameter("idPase", idPase) :
                new ObjectParameter("idPase", typeof(int));
    
            var pasaporteParameter = pasaporte != null ?
                new ObjectParameter("pasaporte", pasaporte) :
                new ObjectParameter("pasaporte", typeof(string));
    
            var idLineaVueloParameter = idLineaVuelo.HasValue ?
                new ObjectParameter("idLineaVuelo", idLineaVuelo) :
                new ObjectParameter("idLineaVuelo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cambiarVuelo", idPaseParameter, pasaporteParameter, idLineaVueloParameter);
        }
    
        public virtual ObjectResult<string> tipoUsuario(string usuario)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("tipoUsuario", usuarioParameter);
        }
    }
}
