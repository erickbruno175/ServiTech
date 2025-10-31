using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiTech.Util
{
    public class ProcessarImagemProduto
    {

        public static byte[] ConvertImageByte(Image imageProduto)
        {
            if (imageProduto == null)
                return null;

            using (var ms = new MemoryStream())
            {
                // Usa formato padrão se o formato original não estiver definido
                var formato = imageProduto.RawFormat ?? System.Drawing.Imaging.ImageFormat.Jpeg;

                try
                {
                    imageProduto.Save(ms, formato);
                }
                catch
                {
                    // Se o formato original falhar, tenta forçar para JPEG
                    imageProduto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                return ms.ToArray();
            }
        }


        public static Image ConvertFotoImage(byte[] imagemProduto)
        {
            if (imagemProduto == null || imagemProduto.Length == 0)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream(imagemProduto))
                {
                    return Image.FromStream(ms);
                }
            }
            catch
            {
                // Caso os bytes estejam corrompidos ou não sejam uma imagem válida
                return null;
            }
        }


        public static Image RedimensionarImagem(Image imagemOriginal, int novaLargura, int novaAltura)
        {
            if (imagemOriginal == null)
                return null;

            // Cria o novo bitmap com o novo tamanho
            Bitmap imagemRedimensionada = new Bitmap(novaLargura, novaAltura);

            using (Graphics g = Graphics.FromImage(imagemRedimensionada))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;

                // Desenha a imagem original redimensionada
                g.DrawImage(imagemOriginal, 0, 0, novaLargura, novaAltura);
            }

            return imagemRedimensionada;
        }
        public static Image RemoverFundoCinza(Image imagemOriginal, int tolerancia = 30)
        {
            if (imagemOriginal == null)
                return null;

            Bitmap bmp = new Bitmap(imagemOriginal);
            bmp.MakeTransparent(); // limpa transparência anterior

            // define a cor base do fundo (ex: cinza médio)
            Color corFundo = Color.FromArgb(200, 200, 200);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);

                    // verifica se o pixel é próximo do cinza base
                    if (Math.Abs(pixel.R - corFundo.R) < tolerancia &&
                        Math.Abs(pixel.G - corFundo.G) < tolerancia &&
                        Math.Abs(pixel.B - corFundo.B) < tolerancia)
                    {
                        bmp.SetPixel(x, y, Color.Transparent);
                    }
                }
            }

            return bmp;
        }


    }
}
