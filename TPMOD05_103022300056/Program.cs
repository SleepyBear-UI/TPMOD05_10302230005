// See https://aka.ms/new-console-template for more information
using TPMOD05_103022300056;

// Membuat objek DataGeneric dengan tipe string kemudian mengisi Data dengan Pribadi
DataGeneric<string> dataNIM = new DataGeneric<string>("103022300056");

// Memanggil method PrintData untuk mencetak Data yang berada di DataGeneric
dataNIM.PrintData();