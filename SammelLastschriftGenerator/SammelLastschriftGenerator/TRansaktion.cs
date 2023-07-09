namespace SammelLastschriftGenerator
{
    public class Transaktion
    {
        public int Id { get; set; }
        public string MitgliedId { get; set; }
        public string Transaktionsdatum { get; set; }
        public string Transaktionsart { get; set; }
        public string Zweck { get; set; }
        public decimal Betrag { get; set; }
    }
}
