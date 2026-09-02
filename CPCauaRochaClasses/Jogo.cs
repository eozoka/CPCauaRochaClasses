// Cauã Rocha do Amaral
// RM567593
// 2tdspa
using System;
using System.Collections.Generic;
using System.Text;

namespace CPCauaRochaClasses
{
    public class Jogo
    {
        String nome;
        int dataDeLancamento;
        String desenvolvedora;
        int classificacaoIndicativa;
        String genero;
        double preco;

        public Jogo(String nome, int dataDeLancamento, String desenvolvedora, int classificacaoIndicativa, String genero, double preco){

            this.nome= nome;
            this.dataDeLancamento= dataDeLancamento;
            this.desenvolvedora= desenvolvedora;
            this.classificacaoIndicativa= classificacaoIndicativa;
            this.genero= genero;    
            this.preco= preco;

        }
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Data de Lançamento: {dataDeLancamento}");
            Console.WriteLine($"Desenvolvedora: {desenvolvedora}");
            Console.WriteLine($"Classificação Indicativa: {classificacaoIndicativa}");
            Console.WriteLine($"Genero: {genero}");
            Console.WriteLine($"Preço: {preco}");

        }
    }
}
