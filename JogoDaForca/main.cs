using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca
{
    internal class main
    {
        static String chaveSorteada;
        public static String lista()
        {
            //Criação do dicionário
            Dictionary<String, List<String>> valores = new Dictionary<String, List<String>>();
            valores["Profissão"] = new List<String> { "professor", "engenheiro", "medico", "advogado", "bombeiro", "policia", "padeiro", "motorista", "arquiteto", "garcom" };
            valores["Carro"] = new List<string> { "ferrari", "volkswagen", "chevrolet", "ford", "toyota", "honda", "renault", "jeep", "mercedes", "audi" };
            valores["Esporte"] = new List<string> { "futebol", "tenis", "basquete", "natacao", "volei", "golfe", "boxe", "ciclismo", "corrida", "surf" };
            valores["País"] = new List<string> { "brasil", "canada", "mexico", "argentina", "japao", "china", "italia", "alemanha", "franca", "egito" };
            valores["Objecto"] = new List<string> { "cadeira", "mesa", "livro", "laptop", "garrafa", "chave", "copo", "telefone", "garfo", "colher" };
            valores["Fruta"] = new List<string> { "banana", "manga", "uva", "morango", "abacaxi", "pera", "melao", "kiwi", "ameixa", "goiaba" };
            valores["Animal"] = new  List<String>{"gato", "cachorro", "leao", "tigre", "elefante","coelho", "jacare", "papagaio", "coruja", "pinguim"};
            valores["Filme"] = new List<String>{"avatar", "titanic", "vingadores", "rocky", "aladdin","matrix", "shrek", "jumper", "madmax", "jumanji"};
            valores["Cor"] = new List<String>{"vermelho", "azul", "amarelo", "verde", "roxo","preto", "branco", "cinza", "marrom", "rosa"};
            valores["Instrumento"] = new List<String>{"violao", "guitarra", "piano", "bateria", "flauta","violino", "teclado", "saxofone", "trompete", "flauta"};

            //Chamar a biblioteca random
            Random rd = new Random();

            //Obter todas as chaves
            List<String> chaves = new List<string>(valores.Keys);
            int iKey = rd.Next(0, chaves.Count);
            chaveSorteada = chaves[iKey];

            List<String> valoresDaChave = valores[chaveSorteada];
            int iValue = rd.Next(0,valoresDaChave.Count);
            String valorSoertado = valoresDaChave[iValue];
            return valorSoertado;
        }

        public static int tamanho()
        {
            String palavra = lista();
            return palavra.Length;
        }

        public static String chave()
        {
            return chaveSorteada;
        }
    }
}

