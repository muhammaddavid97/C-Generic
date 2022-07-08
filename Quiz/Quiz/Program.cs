using Quiz.Quiz_1;

Console.WriteLine("Masukan nama pembeli : ");
Console.Write("Nama pembeli : ");
string inputName = Console.ReadLine();

Makanan makanan = new Makanan();
Minuman minuman = new Minuman();


Console.WriteLine("----------------- Menu Makanan ---------------------");
Makanan[] foods = new Makanan[]
{
    new Makanan(1, "Nasi Goreng", 15000),
    new Makanan(2, "Soto", 9000),
    new Makanan(3, "Mie Ayam", 11000)
};

foreach(var item in foods)
{
    Console.WriteLine($"{item.Pilihan}. {item.Menu} - Rp.{item.Harga}");
}

Console.Write("Masukan pilihan menu " );
string inputMenu = Console.ReadLine();
makanan.Pilihan = Convert.ToInt32(inputMenu);

Console.Write("Berapa porsi : " );
string inputPorsi = Console.ReadLine();
makanan.Banyak = Convert.ToInt32(inputPorsi);

Makanan makanan1 = new Makanan(makanan.Pilihan, makanan.Banyak);
Console.WriteLine(makanan1.ToString());

Console.WriteLine("\n");
Console.WriteLine("------------------ Menu Minuman ---------------------");

Minuman[] drinks = new Minuman[]
{
    new Minuman(1, "Es Teh", 2000),
    new Minuman(2, "Es Jeruk", 3500),
    new Minuman(3, "Es Kopi", 4000)
};

foreach(var item in drinks)
{
    Console.WriteLine($"{item.Pilihan}. {item.Minum} - Rp.{item.Harga}");
}

Console.Write("Masukan pilihan minuman " );
string inputMinum = Console.ReadLine();
minuman.Pilihan = Convert.ToInt32(inputMinum);

Console.Write("Berapa gelas : " );
string inputGelas = Console.ReadLine();
minuman.Banyak = Convert.ToInt32(inputGelas);

Minuman minuman1 = new Minuman(minuman.Pilihan, minuman.Banyak);
Console.WriteLine(minuman1.ToString());

Console.WriteLine("\n");

Kasir[] kasirs = new Kasir[]
{
    makanan1,
    minuman1
};

KasirImplementation obj = new KasirImplementation();
Console.WriteLine(obj.printBayar(kasirs, 50000));

Console.WriteLine("\n");
Console.WriteLine("=======================================================");
Console.WriteLine("================= S T R U K  B E L I ==================");
Console.WriteLine("=======================================================");


Struk<KasirImplementation> struk = null;

Console.WriteLine("Beli : ");
foreach(var item in kasirs)
{
    struk = new Struk<KasirImplementation>(inputName, item.ToString(), obj.TotalBayar(kasirs), obj.BayarTunai(50000), obj.TotalKembalia(kasirs, 50000));
    Console.Write(struk.printOrders() + "\n");
}

struk.printStruk();