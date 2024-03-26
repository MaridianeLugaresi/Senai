namespace LHPet.Models;

public class Cliente
{

    public int Id {get; set;}
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Email { get; set; }
    public string? Paciente { get; set; }

    public Cliente(int Id, string nome, string cpf, string email, string Paciente)
    {
        this.Id = Id;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Email = email;
        this.Paciente = Paciente;
    }
}