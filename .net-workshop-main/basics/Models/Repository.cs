namespace basics.Models{

    public class Repository{

        private static readonly List<Bootcamp> _bootcamps = new();

        static Repository(){
            _bootcamps = new List<Bootcamp>(){
                 new Bootcamp(){Id = 1, Title = "Aspnet Core Workshop", Description = "Güzel bir Workshop", Image = "1.png"},
                 new Bootcamp(){Id = 2, Title = "Unity Workshop", Description = "Güzel bir Workshop", Image = "2.png"},
                 new Bootcamp(){Id = 3, Title = "Backend Workshop", Description = "Güzel bir Workshop", Image = "3.jpg"},
            };
        }
        public static List<Bootcamp> Bootcamps{
            get{
                return _bootcamps;
            }
        }

        public static Bootcamp? GetById(int id){
            return _bootcamps.FirstOrDefault(b=>b.Id == id);
        }
    }
}