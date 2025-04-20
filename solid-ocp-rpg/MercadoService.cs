using solid_ocp_rpg.Itens;

namespace solid_ocp_rpg
{
    public class MercadoService
    {
        public void ExibirItens()
        {
            List<Item> itens = new List<Item>
        {
            new Arma { Nome = "Espada de Ferro", Dano = 10 },
            new Arma { Nome = "Machado Orc", Dano = 12 },
            new Magia { Nome = "Congelar", CustoDeMana = 5 },
            new Pocao { Nome = "Pocao de Cura", PontosDeCura = 2 }
        };

            foreach (var item in itens)
            {
                if (item is Arma arma)
                {
                    Console.WriteLine($"[ARMA] {arma.Nome} - Dano: {arma.Dano}");
                }
                else if (item is Magia magia)
                {
                    Console.WriteLine($"[MAGIA] {magia.Nome} - Custo: {magia.CustoDeMana}");
                }
                else if (item is Pocao pocao)
                {
                    Console.WriteLine($"[POÇÃO] {pocao.Nome} - Cura: {pocao.PontosDeCura}");
                }
            }
        }
    }
}
