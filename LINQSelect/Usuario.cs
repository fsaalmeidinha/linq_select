using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQSelect
{
    public class Usuario
    {
        private static int id = 1;
        private static List<Usuario> _usuarios;
        private static List<Usuario> usuarios
        {
            get
            {
                if (_usuarios == null)
                {
                    _usuarios = new List<Usuario>();
                    _usuarios.Add(new Usuario("Felipe Almeida", "felipe.silvalmeida@gmail.com"));
                    _usuarios.Add(new Usuario("Ana Paula", "ana.paula@gmail.com"));
                    _usuarios.Add(new Usuario("Carlos Alberto", "carlos.alberto@gmail.com"));
                    _usuarios.Add(new Usuario("Karen Silva", "karen.silva@gmail.com"));
                }

                return _usuarios;
            }
        }

        public Usuario(string nome, string email)
        {
            this.Id = id++;
            this.Nome = nome;
            this.Email = email;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public static List<Usuario> SelecionarUsuarios()
        {
            return usuarios;
        }
    }
}
