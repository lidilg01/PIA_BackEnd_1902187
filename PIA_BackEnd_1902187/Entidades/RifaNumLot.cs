namespace PIA_BackEnd_1902187.Entidades
{
    public class RifaNumLot
    {
        public int RifaId { get; set; }
        public int  NumeroLotId { get; set; }
        public Rifa Rifa { get; set; }
        public NumeroLot NumeroLot { get; set; }

    }
}
