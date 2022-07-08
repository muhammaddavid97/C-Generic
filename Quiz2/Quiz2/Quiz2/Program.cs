using Quiz2;

// membuat instance dari kelas SUV
Suv suv1 = new Suv("D 1001 UM", 2015, "SUV", 500000, 100000);
Suv suv2 = new Suv("D 1002 UM", 2019, "SUV", 500000, 100000);

// membuat instance dari kelas Taxi
Taxi taxi1 = new Taxi("D 88 UK", 2018, "TAXI", 5, 4500, 40, 10000);
Taxi taxi2 = new Taxi("D 87 UK", 2018, "TAXI", 10, 4500, 100, 10000);

// membuat instance dari kelas Angkot
Angkot angkot1 = new Angkot("D 55 UJ", 2016, "ANGKOT", 4500, 35);
Angkot angkot2 = new Angkot("D 55 UJ", 2015, "ANGKOT", 4500, 40);

// membuat referensi dari kelas Car
Car[] cars = new Car[]
{
    suv1,
    suv2,
    taxi1,
    taxi2,
    angkot1,
    angkot2
};

// membuat instance dari kelas CarImplementation
CarImplementation carImplementation = new CarImplementation();

carImplementation.printListCar(cars);

Console.WriteLine("\n");
Console.WriteLine("============== Daftar Total Pendapatan masing-masing jenis mobil ==========================");
Console.WriteLine("Jenis Angkot : Rp." + carImplementation.totalPendapatan(cars, "ANGKOT"));
Console.WriteLine("Jenis SUV : Rp." + carImplementation.totalPendapatan(cars, "SUV"));
Console.WriteLine("Jenis Taxis : Rp." + carImplementation.totalPendapatan(cars, "TAXI"));

TotalMobil<CarImplementation> total = null;
foreach (var item in cars)
{
     total = new TotalMobil<CarImplementation>(carImplementation.totalPendapatan(cars, null));
}

Console.WriteLine(total.TotalPendapatan);