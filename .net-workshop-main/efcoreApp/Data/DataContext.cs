using Microsoft.EntityFrameworkCore;

namespace efcoreApp.Data{

    public class DataContex : DbContext{

        public DataContex(DbContextOptions<DataContex>options):base(options){}
        public DbSet<Bootcamp> Bootcamps => Set<Bootcamp>();
        public DbSet<Ogrenci> Ogrenciler => Set<Ogrenci>();
        public DbSet<BootcampKayit> KursKayitlari => Set<BootcampKayit>();
    }
}