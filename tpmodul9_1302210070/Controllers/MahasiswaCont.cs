using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302210070.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Muhammad Risjad Shidqi Febian","1302213067"),
            new Mahasiswa ("Zhafran Hafizh Izdihar Riyadi","1302210125"),
            new Mahasiswa ("Stevent Rangga Ramaditya","1302210097"),
            new Mahasiswa ("Ashar Syahbudi Saleh","1302213016"),
            new Mahasiswa ("Gifari Juliandri","1302213074"),
            new Mahasiswa ("Surya Aulia","1302213116" )
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return ListMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return ListMahasiswa[id];
        }


        [HttpPost]
        public void Post(Mahasiswa m)
        {
            ListMahasiswa.Add(m);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ListMahasiswa.RemoveAt(id);
        }


    }
}
