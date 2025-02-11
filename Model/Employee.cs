﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PrimeiraAPI.Model
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        public int id { get; private set; }
        public string nome { get; private set; }
        public int idade { get; private set; }
        public string? foto { get; private set; }

        public Employee(string nome, int idade, string foto)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.idade = idade;
            this.foto = foto;
        }
    }
}
