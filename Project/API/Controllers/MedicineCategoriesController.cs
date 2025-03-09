using API.Models.DTOs.Request.Create;
using API.Models.DTOs.Response;
using API.Models.Entities;
using API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineCategoriesController : ControllerBase
    {
        private readonly IMedicineCategoryRepository medicineCategoryRepository;

        public MedicineCategoriesController(IMedicineCategoryRepository medicineCategoryRepository)
        {
            this.medicineCategoryRepository = medicineCategoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetMedicineCategories()
        {
            var medicineCategories = await medicineCategoryRepository.GetAllAsync();
            return Ok(medicineCategories);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetMedicineCategoryById([FromRoute] Guid id)
        {
            var medicineCategory = await medicineCategoryRepository.GetByIdAsync(id);
            if (medicineCategory == null)
            {
                return NotFound();
            }
            return Ok(medicineCategory);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedicineCategory([FromBody] MedicineCategoryRequestDTO request)
        {
            //Map DTO <-> Domain: Create MedicineCategory
            var medicineCategory = new MedicineCategory
            {
                MedicineCategoryCode = request.MedicineCategoryCode,
                Name = request.Name,
                Description = request.Description,
                Image = request.Image,
                Status = request.Status,
                CreatedBy = "ADMIN",
                CreatedAt = DateTime.Now
            };
            await medicineCategoryRepository.CreateAsync(medicineCategory);

            // Map Domain <-> DTO: Response MedicineCategory

            var response = new MedicineCategoryResponseDTO
            {
                Id = medicineCategory.Id,
                MedicineCategoryCode = medicineCategory.MedicineCategoryCode,
                Name = medicineCategory.Name,
                Description = medicineCategory.Description,
                Image = medicineCategory.Image,
                Status = medicineCategory.Status
            };

            return Ok(response);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateMedicineCategory([FromRoute] Guid id, [FromBody] MedicineCategoryRequestDTO request)
        {
            var medicineCategory = await medicineCategoryRepository.GetByIdAsync(id);
            if (medicineCategory == null)
            {
                return NotFound();
            }
            //Map DTO <-> Domain: Update MedicineCategory
            medicineCategory.MedicineCategoryCode = request.MedicineCategoryCode;
            medicineCategory.Name = request.Name;
            medicineCategory.Description = request.Description;
            medicineCategory.Image = request.Image;
            medicineCategory.Status = request.Status;
            medicineCategory.UpdatedBy = "ADMIN";
            medicineCategory.UpdatedAt = DateTime.Now;
            await medicineCategoryRepository.UpdateAsync(medicineCategory);
            // Map Domain <-> DTO: Response MedicineCategory
            var response = new MedicineCategoryResponseDTO
            {
                Id = medicineCategory.Id,
                MedicineCategoryCode = medicineCategory.MedicineCategoryCode,
                Name = medicineCategory.Name,
                Description = medicineCategory.Description,
                Image = medicineCategory.Image,
                Status = medicineCategory.Status
            };
            return Ok(response);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteMedicineCategory([FromRoute] Guid id)
        {
            var medicineCategory = await medicineCategoryRepository.GetByIdAsync(id);
            if (medicineCategory == null)
            {
                return NotFound();
            }
            await medicineCategoryRepository.DeleteAsync(id);
            return Ok();
        }
    }
}
