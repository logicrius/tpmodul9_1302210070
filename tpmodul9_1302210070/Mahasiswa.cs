namespace tpmodul9_1302210070
{
    public class Mahasiswa
    {
        public String Nama { get; private set; }
        public String Nim { get; private set; }

        public Mahasiswa(String nama, String nim)
        {
            this.Nama = nama;
            this.Nim = nim;
        }
    }
}
