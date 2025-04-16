// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Numerics;
using modul8_103022300003;

BankTransferConfig bt = new BankTransferConfig();

bt.ReadJSON();


Console.WriteLine("Silahkan pilih bahasa: ");
Console.WriteLine("1. Indonesia");
Console.WriteLine("2. English");
int pb = int.Parse(Console.ReadLine());

if (pb == 1)
{
    if (bt.lang == "en")
    {
        bt.UbahBahasa();
    }
}
else
{
    if (bt.lang == "id")
    {
        bt.UbahBahasa();
    }
}

if (bt.lang == "en")
{
    Console.WriteLine("Please insert the amount of money to transfer:");
}
else
{
    Console.WriteLine("Masukkan jumlah uang yang akan di - transfer:");
}

int transfermoney = int.Parse(Console.ReadLine());

if (transfermoney <= bt.transfer.threshold)
{
    //low fee
    if (bt.lang == "en")
    {
        Console.WriteLine("Transfer fee = "+bt.transfer.low_fee+" dan Total amount = "+ (transfermoney+bt.transfer.low_fee));
    }
    else
    {
        Console.WriteLine("Biaya t ransfer = "+ bt.transfer.low_fee +" dan Total biaya = "+(transfermoney + bt.transfer.low_fee));
    }
}
else
{
    //high fee
    if (bt.lang == "en")
    {
        Console.WriteLine("Transfer fee = " + bt.transfer.high_fee + " dan Total amount = " + (transfermoney + bt.transfer.high_fee));
    }
    else
    {
        Console.WriteLine("Biaya t ransfer = " + bt.transfer.high_fee + " dan Total biaya = " + (transfermoney + bt.transfer.high_fee));
    }
}


if (bt.lang == "en")
{
    Console.WriteLine("Select transfer method:");
}
else
{
    Console.WriteLine("Pilih metode transfer:");
}


int i = 1;
foreach (var item in bt.methods)
{
    Console.WriteLine(i + ". " + item);
    i++;
}

int pilihan = int.Parse(Console.ReadLine());

if (bt.lang == "en")
{
    Console.WriteLine("Please type "+ bt.confirmation.en+" to confirm the transaction");
    string conf = Console.ReadLine();
    if (conf == bt.confirmation.en)
    {
        Console.WriteLine("The transfer is completed");
    }
    else
    {
        Console.WriteLine("Transfer is cancelled");
    }
}
else
{
    Console.WriteLine("Ketik " + bt.confirmation.id + " untuk mengkonfirmasi transaksi");
    string conf = Console.ReadLine();
    if (conf == bt.confirmation.id)
    {
        Console.WriteLine("Proses transfer berhasil");
    }
    else
    {
        Console.WriteLine("Transfer dibatalkan");
    }
}

