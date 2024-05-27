﻿namespace eAgenda.ConsoleApp.Compartilhado
{
    public abstract class RepositorioTarefas<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();

        protected int contadorId = 1;

        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId++;

            registros.Add(novoRegistro);
        }

        public bool Editar(int id, T novaEntidade)
        {
            T registroParaEditar = SelecionarPorId(id);

            if (registroParaEditar == null)
                return false;

            registroParaEditar.AtualizarRegistro(novaEntidade);

            return true;
        }

        public bool Excluir(int id)
        {
            return registros.Remove(SelecionarPorId(id));
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public T SelecionarPorId(int id)
        {
            return registros.Find(x => x.Id == id);
        }

        public bool Existe(int id)
        {
            return registros.Exists(x => x.Id == id);
        }
    }
}
