namespace sanJuanBeers.DTOs.BeerDTOs
{
    public class BeerDTO
    {
        public int BeerID { get; set; }
        public string Name { get; set; }
        public int BrandID { get; set; }
        public decimal Alcohol { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public Boolean IsActive { get; set; }
    }
}
