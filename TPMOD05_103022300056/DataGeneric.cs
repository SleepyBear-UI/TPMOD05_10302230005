using System;
namespace TPMOD05_103022300056
{
	public class DataGeneric<T>
	{
		private T data;
        // Konstruktor dengan parameter data nantinya akan mengembalikan nilai data
        public DataGeneric(T data)
        {
            this.data = data;
        }

        // Method PrintData untuk memberikan output berupa
        // " Data yang tersimpan adalah: " data yang berasal dari class Data Generic
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
}

