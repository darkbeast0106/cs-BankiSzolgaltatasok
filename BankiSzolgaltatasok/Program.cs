using BankiSzolgaltatasok;

Bank bank = new Bank();
Tulajdonos t1 = new Tulajdonos("Gipsz Jakab");
Tulajdonos t2 = new Tulajdonos("Teszt Elek");
Szamla sz1 = bank.SzamlaNyitas(t1, 0);
Szamla sz2 = bank.SzamlaNyitas(t1, 150000);

Szamla sz3 = bank.SzamlaNyitas(t2, 0);
Szamla sz4 = bank.SzamlaNyitas(t2, 75000);

sz1.Befizet(200000);
sz2.Befizet(300000);
sz3.Befizet(300000);
sz4.Befizet(250000);

Kartya k1 = sz1.UjKartya("1234");
Kartya k2 = sz2.UjKartya("4321");
Kartya k3 = sz3.UjKartya("6789");
Kartya k4 = sz4.UjKartya("9876");

Console.WriteLine(k1.Vasarlas(50000));
Console.WriteLine(sz1.AktualisEgyenleg);
Console.WriteLine(sz3.Kivesz(100000));

Console.WriteLine(bank.GetOsszEgyenleg(t1));
Console.WriteLine(bank.GetLegnagyobbEgyenleguSzamla(t2).AktualisEgyenleg);
Console.WriteLine(bank.OsszHitelkeret);