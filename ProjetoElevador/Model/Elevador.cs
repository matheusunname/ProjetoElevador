using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model
{
    public class Elevador
    {
        
        public int AndarAtual { get; set; } //andar atual
        public int TotalDeAndares { get; set; } //total de andares
        public int CapacidadeDoElevador { get; set; } //capacidade max do elevador
        public int QuantidadeDePessoas { get; set; } //quantidade max de pessoas

        public void Inicializar(int totalDeAndares, int capacidadeDoElevador)
        {
            TotalDeAndares = totalDeAndares;
            CapacidadeDoElevador = capacidadeDoElevador;
        }
        public void Entrar()
        {
            if (this.QuantidadeDePessoas < this.CapacidadeDoElevador)
            {
                this.QuantidadeDePessoas++;
            }
        }
        public void Sair()
        {
            if (this.QuantidadeDePessoas > 0)
            {
                this.QuantidadeDePessoas--;
            }
        }
        public void Subir()
        {
            if (this.AndarAtual < TotalDeAndares)
            {
                this.AndarAtual++;
            }
        }
        public void Descer()
        {
            if (this.AndarAtual > 0)
            {
                this.AndarAtual--;
            }
        }

    }
}
