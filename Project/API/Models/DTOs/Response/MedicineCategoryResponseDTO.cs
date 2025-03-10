﻿namespace API.Models.DTOs.Response
{
    public class MedicineCategoryResponseDTO
    {
        public Guid Id { get; set; }
        public string? MedicineCategoryCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool Status { get; set; }
    }
}
