using K205_Telebe.Methods;
using K205_Telebe.Models;

TelebeManager telebeManager = new();


Telebe student = new Telebe(){
    Id = 1,
    Name = "Aytac",
    Surname = "Rustemli",
    Fenn = "Proqramlasdirmanin esaslari",
    Bal = 51
};


Evvele:
Console.WriteLine("1. Telebenin giris balini mueyyen et.");
Console.WriteLine("2. Telebenin Hansi qiymet aldigini mueyyen et.");
Console.WriteLine("3. Telebe info");

string daxilEdilenReqem = Console.ReadLine();


switch (Convert.ToInt32(daxilEdilenReqem))
{
    case 1:
        telebeManager.HereketeBasla(student);
        goto Evvele;
        break;
    case 2:
        telebeManager.Davam(student);
        goto Evvele;
        break;
    case 3:
        telebeManager.TelebeInfo(student);
        break;
    default:
        Console.WriteLine("Dogru reqem daxil edin.");
        break;
}

