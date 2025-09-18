Enemy eddi = new();

eddi.Name = "Eddi";
eddi.Hp = 5;
eddi.Damage = -1;

Enemy gurre = new()
{
    Name = "Gurre",
    Hp = 100,
    Damage = 10

};

eddi.Hp++;

eddi.Hp -= gurre.Damage;

