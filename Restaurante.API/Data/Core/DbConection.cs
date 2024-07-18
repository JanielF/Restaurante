using Microsoft.EntityFrameworkCore;
using Restaurante.API.Data.Models;

namespace Restaurante.API.Data.Core
{
    public class DbConection : DbContext
    {
        public DbConection()
        { }

        public DbConection(DbContextOptions<DbConection> options)
            : base(options) 
        {

        }
        public DbSet<UsuariosModels> Usuarios { get; set; }
        public DbSet<RolesModels> Roles { get; set; }
        public DbSet<UsuarioRolesModels> UsuarioRoles { get; set; }
        public DbSet<MesasModels> Mesas { get; set; }
        public DbSet<ReservasModels> Reservas { get; set; }
        public DbSet<PagosModels> Pagos { get; set; }
        public DbSet<NotificacionesModels> Notificaciones { get; set; }
        public DbSet<MenusModels> Menus { get; set; }
        public DbSet<ReservasMenusModels> ReservasMenus { get; set; }
    }
}
