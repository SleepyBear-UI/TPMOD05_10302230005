// See https://aka.ms/new-console-template for more information
<<<<<<< HEAD

using TPMOD05_103022300056;

// Membuat Object Halo agar dapat menggunakan
// Funsi Sapa User yang berada di HaloGeneric.
HaloGeneric halo = new HaloGeneric();

// Input Nama user.
String User = Console.ReadLine();

// memanggil fungsi sapa user.
halo.SapaUser(User);
=======
using TPMOD05_103022300056;

// Membuat objek DataGeneric dengan tipe string kemudian mengisi Data dengan Pribadi
DataGeneric<string> dataNIM = new DataGeneric<string>("103022300056");

// Memanggil method PrintData untuk mencetak Data yang berada di DataGeneric
dataNIM.PrintData();
>>>>>>> generic-class
