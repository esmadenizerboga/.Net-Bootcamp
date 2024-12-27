using System.ComponentModel.DataAnnotations;

namespace efcoreApp.Data{

    public class Bootcamp{

        [Key]
        public int BootcampId { get; set; }
        public string? Baslik {get;set;}
        public ICollection<BootcampKayit> KursKayitlari {get;set;} = new List<BootcampKayit>();
    }
}