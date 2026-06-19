int VidaDoJogador = 100;
int AtaqueBasico = 10;
int AtaqueEspecial = 25;    

Console.WriteLine ("\n Voce Adentra a Masmorra escura e é surpreendido...\n " );
Thread.Sleep(2000);

VidaDoJogador -= AtaqueBasico ;
Console.WriteLine ($"Voce levou {AtaqueBasico} de dano de um Goblin");
Thread.Sleep(900);

Console.WriteLine ("Quando recupera a consciencia   e percebe que o Goblin se aproxima para um segundo ataque...");
Thread.Sleep(2300);

VidaDoJogador -= AtaqueEspecial;
Console.WriteLine ($"Sua vida atual é {VidaDoJogador}");
Thread.Sleep(2000);


Console.WriteLine ("É melhor descansar em uma fogueira...");
