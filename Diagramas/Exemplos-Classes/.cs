// Abstração de um brinquedo eletrônico
public class CarrinhoControleRemoto 
{
    // ATRIBUTOS (O que o brinquedo TEM)
    public string Cor;
    public int Velocidade;
    public int NivelBateria;

    // MÉTODOS (O que o brinquedo FAZ)
    public void Acelerar() 
    {
        if (NivelBateria > 0) {
            this.Velocidade += 10;
            this.NivelBateria -= 1; // Ação consome energia
        }
    }

    public void Buzinar() 
    {
        Console.WriteLine("Beep! Beep!");
    }
}

