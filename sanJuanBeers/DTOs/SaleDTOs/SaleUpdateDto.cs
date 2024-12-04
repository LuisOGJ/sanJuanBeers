namespace sanJuanBeers.DTOs.SaleDTOs
{
    public class SaleUpdateDto
    {
        public int SaleID { get; set; }
        public int ClientID { get; set; }
        public int UserID { get; set; }
        public DateTime DateTimeSale { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
    }
}
