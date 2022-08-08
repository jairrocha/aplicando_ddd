using Restaurante.Dominio.Entidades;

namespace Restaurante.Aplicacao.DTO.PratoDia
{
    public class ReadPratoDiaDTO:DTOBase
    {
        public Cardapio Cardapio { get; set; }
        public Prato Prato { get; set; }
    }
}
