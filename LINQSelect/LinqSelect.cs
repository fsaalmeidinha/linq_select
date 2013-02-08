using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQSelect
{
    public class LinqSelect
    {

        public static void TesteLinqSelect()
        {
            List<Usuario> usuarios = Usuario.SelecionarUsuarios();
            List<int> idsUsuarios = usuarios.Select(usuario => usuario.Id).ToList();

            Console.WriteLine("Os ids dos usuários são: " + String.Join(", ", idsUsuarios));
        }

        public static void TesteLinqSlectAnonimo()
        {
            List<Usuario> usuarios = Usuario.SelecionarUsuarios();
            var usuariosComDescricaoTratada = usuarios.Select(usuario =>
            new
            {
                Id = usuario.Id,
                Descricao = String.Format("{0}({1})", usuario.Nome, usuario.Email)
            });

            Console.WriteLine("As descrições dos usuários são: \n" + String.Join(Environment.NewLine, usuariosComDescricaoTratada.Select(usr => usr.Descricao)));
        }

        public static void TesteLinqSelectComIndice()
        {
            List<Usuario> usuarios = Usuario.SelecionarUsuarios();
            List<KeyValuePair<int, string>> usuariosComIndices = usuarios.Select((usuario, indice) => new KeyValuePair<int, string>(indice, usuario.Nome)).ToList();

            foreach (KeyValuePair<int, string> usuarioComIndice in usuariosComIndices)
            {
                Console.WriteLine("O usuário {0} está no índice {1} da lista de usuários", usuarioComIndice.Value, usuarioComIndice.Key);
            }
        }

    }
}
