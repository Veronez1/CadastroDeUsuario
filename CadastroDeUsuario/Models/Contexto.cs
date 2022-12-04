﻿using Microsoft.EntityFrameworkCore;

namespace CadastroDeUsuario.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; } 
    }
}
