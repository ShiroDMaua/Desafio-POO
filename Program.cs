using DesafioPOO.Models;



Console.WriteLine("Celular Nokia: ");
Smartphone nokia = new Nokia(numero:"974244608", modelo:"G60", imei:"351108332426788", memoria: 128 );
nokia.Ligar();
nokia.InstalarAplicativo("Wild Rift");

Console.WriteLine("\n");

Console.WriteLine("Celular Iphone: ");
Smartphone iphone = new Iphone(numero:"974224608", modelo:"XR", imei:"356423106346103", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Pou");

