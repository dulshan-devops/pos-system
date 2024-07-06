﻿namespace pos_system.Models.Entities
{
    public class UpdateUser
    {
        public int UserId { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }
    }
}
