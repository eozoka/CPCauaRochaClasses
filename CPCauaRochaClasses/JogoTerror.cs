using System;

namespace CPCauaRochaClasses
{
    public class JogoTerror : Jogo
    {
        String tipoDeTerror;
        int nivelDeMedo;
        bool possuiJumpscare;

        public JogoTerror(
            String nome,
            int dataDeLancamento,
            String desenvolvedora,
            int classificacaoIndicativa,
            String genero,
            double preco,
            String tipoDeTerror,
            int nivelDeMedo,
            bool possuiJumpscare)
            : base(
                nome,
                dataDeLancamento,
                desenvolvedora,
                classificacaoIndicativa,
                genero,
                preco)
        {
            this.tipoDeTerror = tipoDeTerror;
            this.nivelDeMedo = nivelDeMedo;
            this.possuiJumpscare = possuiJumpscare;
        }

        public override void Apresentar()
        {
            base.Apresentar();

            Console.WriteLine($"Tipo de Terror: {tipoDeTerror}");
            Console.WriteLine($"Nivel de Medo do Jogo: {nivelDeMedo}");
            Console.WriteLine($"Possui jumpscares no Jogo?: {possuiJumpscare}");
        }
    }
}