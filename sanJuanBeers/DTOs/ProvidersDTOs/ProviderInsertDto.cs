﻿namespace sanJuanBeers.DTOs.ProvidersDTOs
{
    public class ProviderInsertDto
    {
        public int ProviderID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public Boolean IsActive { get; set; }
    }
}
