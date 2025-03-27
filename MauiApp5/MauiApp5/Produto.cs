using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MauiApp5
{
    internal class Produto
    {
        public double Preco { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Descricao { get; set; }

        public string Data { get; set; }
        public string Imagem { get; set; }

        public static List<Produto> Lista
        {
            get
            {
                List<Produto> lista = new List<Produto>();
                lista.Add(new Produto()
                {
                    Nome = "Assassins Creed Shadows",
                    Preco = 349.95,
                    Data = "20/03/2025",
                    Empresa = "Ubisoft",
                    Descricao = "Situado no Japão do século XVI, no final do período Sengoku, o jogo se concentra na luta milenar da Irmandade dos Assassinos,\nque luta pela paz e pela liberdade, e pela Ordem dos Templários, que deseja a paz através do controle.",
                    Imagem = "https://store-images.s-microsoft.com/image/apps.31384.14601317961808017.7b103743-3dbd-479d-b77a-f82e7f0548c6.1c8584d1-df69-4c36-aaef-fef657295a0f",
                });
                lista.Add(new Produto()
                {
                    Nome = "Terraria",
                    Preco = 32.99,
                    Data = "16/05/2011",
                    Empresa = "Re-Logic",
                    Descricao = "Terraria é um jogo sandbox que combina exploração, construção, mineração e batalhas contra inimigos e chefes. Com um mundo gerado proceduralmente,\nos jogadores podem criar e modificar o ambiente ao seu redor, coletando recursos, fabricando itens e enfrentando desafios variados.",
                    Imagem = "https://upload.wikimedia.org/wikipedia/pt/e/ee/Terraria_capa.png"
                });
                lista.Add(new Produto()
                {
                    Nome = "Bloons TD6",
                    Preco = 27.89,
                    Data = "14/06/2018",
                    Empresa = "Ninja Kiwi",
                    Descricao = "Bloons TD 6 é um jogo de estratégia do gênero tower defense, onde os jogadores precisam posicionar macacos e torres para estourar ondas de balões (\"bloons\") antes\nque eles alcancem o final do caminho.",
                    Imagem = "https://m.media-amazon.com/images/M/MV5BZWM2ZDRiMjMtMTk5Mi00ZDMyLTk1NmMtZjI1NTlmMzQ2YTE0XkEyXkFqcGc@._V1_.jpg"
                });
                lista.Add(new Produto()
                {
                    Nome = "Elden ring",
                    Preco = 229.90,
                    Data = "25/02/2022",
                    Empresa = "FromSoftware",
                    Descricao = "Elden Ring é um RPG de ação em mundo aberto que combina exploração, combate desafiador e narrativa imersiva em um cenário de fantasia sombria. O jogo apresenta um\nvasto mundo interconectado, repleto de segredos, inimigos formidáveis e chefes épicos, além de permitir uma abordagem livre para explorar e interagir com seu ambiente.",
                    Imagem = "https://www.europanet.com.br/image_gen/resizeimg.php?cod_produto=100960"
                });
                lista.Add(new Produto()
                {
                    Nome = "Plants vs Zombies Garden Warfare 2",
                    Preco = 159,
                    Data = "23/02/2016",
                    Empresa = "PopCap Games",
                    Descricao = "Plants vs. Zombies: Garden Warfare 2 é um jogo de tiro em terceira pessoa com elementos de estratégia e multiplayer da franquia Plants vs Zombies. Sequência do primeiro\nGarden Warfare, ele expande a fórmula ao introduzir novos personagens jogáveis, modos de jogo e um mundo mais aberto para exploração.",
                    Imagem = "https://products.eneba.games/resized-products/9QeIYr9_350x200_3x-0.jpg"
                });
                lista.Add(new Produto()
                {
                    Nome = "Devil May Cry 5",
                    Preco = 99.00,
                    Data = "08/03/2019",
                    Empresa = "Capcom",
                    Descricao = "Devil May Cry 5 é um jogo de ação e hack and slash que continua a saga da famosa franquia Devil May Cry.O jogo acompanha Dante, Nero e o novo personagem V, que enfrentam\nhordas de demônios para impedir a ascensão do Rei Demônio Urizen. ",
                    Imagem = "https://image.api.playstation.com/vulcan/ap/rnd/202009/1710/UUnpHLJqLAIJX5HioswiPuAm.png"
                });
                return lista;
            }
        }
    }
}
