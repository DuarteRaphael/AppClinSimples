// See https://aka.ms/new-console-template for more information
using AppClinSimples.Entities;

var consulta = new Consulta();
consulta.paciente = new Paciente();
consulta.medico = new Medico();
{
    consulta.paciente.IdPaciente = Guid.NewGuid();
    consulta.paciente.Nome = "Raphael Santos Duarte";
    consulta.medico.IdMedico = Guid.NewGuid();
    consulta.medico.Nome = "Dr. Acapulco";
    consulta.IdConsulta = Guid.NewGuid();
    consulta.DataConsulta = DateTime.Now;

    Console.WriteLine($"Id da consulta............: {consulta.IdConsulta}");
    Console.WriteLine($"Data da consulta..........: {consulta.DataConsulta}");
    Console.WriteLine("---");
    Console.WriteLine("---");
    Console.WriteLine($"Id do médico..............: {consulta.medico.IdMedico}");
    Console.WriteLine($"Nome do médico............: {consulta.medico.Nome}");
    Console.WriteLine("---");
    Console.WriteLine("---");
    Console.WriteLine($"Id do paciente............: {consulta.paciente.IdPaciente}");
    Console.WriteLine($"Nome do paciente..........: {consulta.paciente.Nome}");

    Console.ReadKey();
}
