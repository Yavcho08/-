Console.WriteLine("Vuvedete purvonachalna skorost (Maks 300 km/h ):");
double speed = int.Parse(Console.ReadLine());
Console.WriteLine("Pyrvoto vreme v minuti:");
double firstTime = int.Parse(Console.ReadLine());
Console.WriteLine("Vtoroto vreme v minuti:");
double secondTime = int.Parse(Console.ReadLine());
Console.WriteLine("Tretoto vreme v minuti:");
double thirdTime = int.Parse(Console.ReadLine());
double secondspeed = speed * 1.10;
double thirdspeed = secondspeed * 0.95;
double firstdistance = speed * (firstTime / 60);
double seconddistance = secondspeed * (secondTime / 60);
double thirddistance = thirdspeed * (thirdTime / 60);
Console.WriteLine(firstdistance);
Console.WriteLine(seconddistance);
Console.WriteLine(thirddistance);
Console.WriteLine(Math.Round(firstdistance + seconddistance + thirddistance, 2));


