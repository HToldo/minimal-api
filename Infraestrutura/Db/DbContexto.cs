using Microsoft.EntityFrameworkCore;
using MinimalApi.Dominio.Entidades;



namespace MinimalApi.Infraestrutura.Db;



public class DbContexto : DbContext
{


    public DbContexto(DbContextOptions<DbContexto> options) : base(options)
    {
    }

    public DbSet<Administrador> Administradores { get; set; } = default!;

    public DbSet<Veiculo> Veiculos { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador
            {
                Id = 1,
                Email = "adm@teste.com",
                Password = "123456",
                Perfil = "Adm"
            }
        );
    }

    /* private readonly IConfiguration _configuracaoAppSettings;
    public DbContexto(IConfiguration configuracaoAppSettings)
    {
        _configuracaoAppSettings = configuracaoAppSettings;
    }*/
     

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var stringConexao = _configuracaoAppSettings.GetConnectionString("mysql")?.ToString();
            if (!string.IsNullOrEmpty(stringConexao))
            {
                optionsBuilder.UseMySql(
                    stringConexao,
                    ServerVersion.AutoDetect(stringConexao));
            }
        }
    }*/

}