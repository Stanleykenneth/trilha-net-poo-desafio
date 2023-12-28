using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "12365478", modelo: "Modelo A", imei: "36985428", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");


System.Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "Modelo XR", imei: "753695124", memoria: 168);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");

