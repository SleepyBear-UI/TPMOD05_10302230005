// See https://aka.ms/new-console-template for more information

using TPMOD05_103022300056;

// Membuat Object Halo agar dapat menggunakan
// Funsi Sapa User yang berada di HaloGeneric.
HaloGeneric halo = new HaloGeneric();

// Input Nama user.
String User = Console.ReadLine();

// memanggil fungsi sapa user.
halo.SapaUser(User);