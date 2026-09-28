using QRCoder;

Console.WriteLine("=== GENERADOR DE QR ===");

Console.Write("Ingrese el enlace: ");
string enlace = Console.ReadLine() ?? "";

QRCodeGenerator generador = new QRCodeGenerator();

using (QRCodeData datosQR = generador.CreateQrCode(
    enlace,
    QRCodeGenerator.ECCLevel.Q))
{
     PngByteQRCode qr = new PngByteQRCode(datosQR);

    byte[] imagenQR = qr.GetGraphic(20);

    File.WriteAllBytes("codigo-qr.png", imagenQR);
}

Console.WriteLine("Enlace recibido:");
Console.WriteLine(enlace);