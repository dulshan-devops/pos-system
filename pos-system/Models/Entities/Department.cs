﻿namespace pos_system.Models.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public required string DepartmentName { get; set; }
        public string? Desc { get; set; }
    }
}