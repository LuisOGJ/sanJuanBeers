﻿namespace sanJuanBeers.DTOs.UserDTOs
{
    public class UserInsertDto
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Boolean IsActive { get; set; }
        public int RoleID { get; set; }
    }
}