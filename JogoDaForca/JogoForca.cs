using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoDaForca
{
    internal class JogoForca
    {
        private string palavra;
        private string categoria;
        private HashSet<char> letrasReveladas = new HashSet<char>();

        public JogoForca()
        {
            SortearPalavra();
        }

        private void SortearPalavra()
        {
            Dictionary<string, List<string>> categorias = new Dictionary<string, List<string>>()
            {
                { "Profissão", new List<string> { "professor", "engenheiro", "medico", "advogado", "bombeiro", "policia", "padeiro", "motorista", "arquiteto", "garcom" } },
                { "Carro", new List<string> { "ferrari", "volkswagen", "chevrolet", "ford", "toyota", "honda", "renault", "jeep", "mercedes", "audi" } },
                { "Esporte", new List<string> { "futebol", "tenis", "basquete", "natacao", "volei", "golfe", "boxe", "ciclismo", "corrida", "surf" } },
                { "País", new List<string> { "brasil", "canada", "mexico", "argentina", "japao", "china", "italia", "alemanha", "franca", "egito" } },
                { "Objeto", new List<string> { "cadeira", "mesa", "livro", "laptop", "garrafa", "chave", "copo", "telefone", "garfo", "colher" } },
                { "Fruta", new List<string> { "banana", "manga", "uva", "morango", "abacaxi", "pera", "melao", "kiwi", "ameixa", "goiaba" } },
                { "Animal", new List<string> { "gato", "cachorro", "leao", "tigre", "elefante", "coelho", "jacare", "papagaio", "coruja", "pinguim" } },
                { "Filme", new List<string> { "avatar", "titanic", "vingadores", "rocky", "aladdin", "matrix", "shrek", "jumper", "madmax", "jumanji" } },
                { "Cor", new List<string> { "vermelho", "azul", "amarelo", "verde", "roxo", "preto", "branco", "cinza", "marrom", "rosa" } },
                { "Instrumento", new List<string> { "violao", "guitarra", "piano", "bateria", "flauta", "violino", "teclado", "saxofone", "trompete" } }
            };

            Random rnd = new Random();
            List<string> chaves = new List<string>(categorias.Keys);
            categoria = chaves[rnd.Next(chaves.Count)];

            List<string> palavras = categorias[categoria];
            palavra = palavras[rnd.Next(palavras.Count)];
        }

        public string GetPalavra() => palavra;
        public string GetCategoria() => categoria;
        public int GetTamanho() => palavra.Length;

        public bool VerificarLetra(char letra)
        {
            bool contem = palavra.Contains(letra);
            if (contem)
                letrasReveladas.Add(letra);
            return contem;
        }

        public bool LetraEstaRevelada(int posicao)
        {
            return letrasReveladas.Contains(palavra[posicao]);
        }

        public char GetLetra(int posicao)
        {
            return palavra[posicao];
        }
    }
}
