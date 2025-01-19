using System;

namespace HotelApplication.Models;

public class Hospedagem
{
    public Quarto QuartoSelecionado { get; set; }
    public int QtdAdultos { get; set; }
    public int QtdCriancas { get; set; }
    public DateTime DataCheckIn { get; set; }
    public DateTime DataCheckOut { get; set; }

    public int Estadia {
        get => DataCheckOut.Subtract(DataCheckIn).Days;
    }

    public double ValorTotal {
        get {
            double valorAdultos = QtdAdultos * QuartoSelecionado.ValorDiariaAdulto;
            double valorCriancas = QtdCriancas * QuartoSelecionado.ValorDiariaCrianca;

            double total = (valorAdultos + valorCriancas) * Estadia;

            return total;
        }
    }
}
