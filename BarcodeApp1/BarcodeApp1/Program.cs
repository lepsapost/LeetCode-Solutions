using System;
using System.Drawing;
using System.IO;
using QRCoder;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Generate QR Code");
            Console.WriteLine("2. Read QR Code");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    GenerateQRCode();
                    break;
                case "2":
                    ReadQRCode();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void GenerateQRCode()
    {
        Console.Write("Enter the text for the QR code: ");
        string? qrText = Console.ReadLine();
        if (string.IsNullOrEmpty(qrText)) return;

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
        PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
        byte[] qrCodeImage = qrCode.GetGraphic(20);

        File.WriteAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "qrcode.png"), qrCodeImage);

        Console.WriteLine("QR code generated and saved as 'qrcode.png'");
    }

    static void ReadQRCode()
    {
        Console.WriteLine("QR code reading is not implemented in this version.");
        Console.WriteLine("You can use an online QR code reader or a mobile app to read the generated QR code.");
    }
}
