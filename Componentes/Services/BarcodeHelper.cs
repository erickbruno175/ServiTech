using System;
using System.Drawing;
using ZXing;
using ZXing.Common;

namespace ServiTech.Componentes.Services
{
    public static class BarcodeHelper
    {
        // Gera um código EAN-13 válido a partir de um número inteiro
        public static string GerarEan13(int numero)
        {
            // Preenche com zeros à esquerda até 12 dígitos
            string baseNumber = numero.ToString().PadLeft(12, '0');

            // Calcula dígito verificador
            int checkDigit = CalcularDigitoVerificador(baseNumber);

            return baseNumber + checkDigit.ToString();
        }

        // Calcula o dígito verificador do EAN-13
        private static int CalcularDigitoVerificador(string baseNumber)
        {
            int soma = 0;
            for (int i = 0; i < baseNumber.Length; i++)
            {
                int digito = int.Parse(baseNumber[i].ToString());

                if ((i % 2) == 0) // posições pares
                    soma += digito;
                else // posições ímpares
                    soma += digito * 3;
            }

            int resto = soma % 10;
            return (resto == 0) ? 0 : 10 - resto;
        }

        // Gera a imagem do código de barras
        // Gera a imagem do código de barras com os números embaixo
        public static Bitmap GerarImagem(string codigo, BarcodeFormat formato)
        {
            var writer = new BarcodeWriterPixelData // Usando PixelData para maior controle
            {
                Format = formato, // Exemplo: BarcodeFormat.EAN_13
                Options = new EncodingOptions
                {
                    Width = 300,
                    Height = 100,
                    Margin = 2,
                    PureBarcode = true
                }
            };

            var pixelData = writer.Write(codigo);

            // Cria o bitmap só do código de barras
            var bmp = new Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            var bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                System.Drawing.Imaging.ImageLockMode.WriteOnly, bmp.PixelFormat);
            try
            {
                System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bmpData.Scan0, pixelData.Pixels.Length);
            }
            finally
            {
                bmp.UnlockBits(bmpData);
            }

            // Agora cria uma nova imagem maior para caber o texto embaixo
            int alturaComTexto = bmp.Height + 20; // espaço extra para o número
            var finalImage = new Bitmap(bmp.Width, alturaComTexto);
            using (Graphics g = Graphics.FromImage(finalImage))
            {
                g.Clear(Color.White);
                g.DrawImage(bmp, 0, 0);

                // Desenha o número (EAN-13) centralizado
                using (Font fonte = new Font("Arial", 12, FontStyle.Regular))
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    SizeF tamanhoTexto = g.MeasureString(codigo, fonte);
                    float x = (finalImage.Width - tamanhoTexto.Width) / 2;
                    float y = bmp.Height; // logo abaixo do código
                    g.DrawString(codigo, fonte, brush, x, y);
                }
            }

            return finalImage;
        }

    }
}
