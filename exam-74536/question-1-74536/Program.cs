/*
 =============================
        Stu n° 74536
 Gaspard TORTERAT SLANDA
 ============================= */
 /*
  Answer to A)
 Declearing a class sealed means that no class can inherit from it.
  */    
using question_1_74536;
using Faker;

    int i = 0;
    List<BuildingCodes> buildings = new List<BuildingCodes>();
    while (i < 10)
    {
        var buildingId = RandomNumber.Next(0, 10000); ;
        var buildingLocation = Address.City();
        var buildingCode = RandomNumber.Next(0, 1000000).ToString();

        var building = new BuildingCodes(buildingId, buildingLocation, buildingCode);
        buildings.Add(building);
        i++;
    }

    buildings.OrderBy(x => x.BuildingId);
    foreach (var building in buildings)
    {
        building.Show();
    }
    while (true)
    {
        Console.WriteLine("Please either press (A) to add a building or (R) to remove one");
        char inp = 'B';
        while (inp != 'A' && inp != 'R')
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("");
            inp = keyInfo.KeyChar;
        }
        switch (inp)
        {
            case 'A':
                var buildingId = RandomNumber.Next(0, 10000); ;
                var buildingLocation = Address.City();
                var buildingCode = RandomNumber.Next(0, 1000000).ToString();
                var building = new BuildingCodes(buildingId, buildingLocation, buildingCode);
            buildings.Add(building);
                Console.WriteLine("A building was Added !");
                break;
            case 'R':
                buildings.RemoveAt(0);
                Console.WriteLine("A building was removed !");
                break;
            default:
                break;
        }
        buildings.OrderBy(x => x.BuildingId);
        foreach (var building in buildings)
        {
            building.Show();
        }
    Console.WriteLine("");
}