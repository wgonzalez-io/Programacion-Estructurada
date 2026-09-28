using System.Runtime.CompilerServices;
using QRCoder;

namespace CodigoQR;

public partial class MainPage : ContentPage
{
	private byte[]? imagenQR;
    public MainPage()
    {
        InitializeComponent();
	}
	private void OnGenerarQRClicked(object? sender, EventArgs e)
	{
		string enlace = EnlaceEntry.Text ?? "";

		QRCodeGenerator generador = new QRCodeGenerator();

    using (QRCodeData datosQR = generador.CreateQrCode(
        enlace,
        QRCodeGenerator.ECCLevel.Q))
    {
        PngByteQRCode qr = new PngByteQRCode(datosQR);

       imagenQR= qr.GetGraphic(20);

        QrImage.Source = ImageSource.FromStream(
            () => new MemoryStream(imagenQR));
		
		GuardarBtn.IsEnabled = true;
    }

	}

    private void OnGuardarQRClicked(object? sender, EventArgs e)
    {
        
    }
}