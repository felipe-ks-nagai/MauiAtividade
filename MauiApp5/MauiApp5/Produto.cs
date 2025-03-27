using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5
{
    internal class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }


        public string Imagem { get; set; }

        public static List<Produto> Lista
        {
            get
            {
                List<Produto> lista = new List<Produto>();
                lista.Add(new Produto() { Nome = "Assassins Creed Shadows", Preco = 349.95, Imagem = "https://store-images.s-microsoft.com/image/apps.31384.14601317961808017.7b103743-3dbd-479d-b77a-f82e7f0548c6.1c8584d1-df69-4c36-aaef-fef657295a0f" });
                lista.Add(new Produto() { Nome = "Terraria", Preco = 32.99, Imagem = "https://upload.wikimedia.org/wikipedia/pt/e/ee/Terraria_capa.png" });
                lista.Add(new Produto() { Nome = "Bloons TD6", Preco = 27.89, Imagem = "https://m.media-amazon.com/images/M/MV5BZWM2ZDRiMjMtMTk5Mi00ZDMyLTk1NmMtZjI1NTlmMzQ2YTE0XkEyXkFqcGc@._V1_.jpg" });
                lista.Add(new Produto() { Nome = "Elden ring", Preco = 229.90, Imagem = "https://www.europanet.com.br/image_gen/resizeimg.php?cod_produto=100960" });
                lista.Add(new Produto() { Nome = "Plants vs Zombies Garden Warfare 2", Preco = 159, Imagem = "https://products.eneba.games/resized-products/9QeIYr9_350x200_3x-0.jpg" });
                return lista;
            }
        }
    }
}
