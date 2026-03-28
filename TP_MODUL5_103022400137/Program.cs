using System;

namespace TP_MODUL5_103022400137
{
   
    public class HaloGeneric
    {
        public void SapaUser<T>(T input)
        {
            Console.WriteLine($"Halo user {input}");
        }
    }

   
    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            // PANGGILAN BAGIAN D (Ganti "Danu" dengan nama panggilanmu)
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Danu");

            // PANGGILAN BAGIAN F (Isi dengan NIM-mu)
            DataGeneric<string> dataObj = new DataGeneric<string>("103022400137");
            dataObj.PrintData();
        }
    }
}