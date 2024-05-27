using eAgenda.ConsoleApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioTarefas<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissosFuturos()
        {
            return registros.FindAll(c => c.Data >= DateTime.Today);
        }

        public List<Compromisso> SelecionarCompromissosPassados()
        {
            return registros.FindAll(c => c.Data < DateTime.Today);
        }
    }
}
