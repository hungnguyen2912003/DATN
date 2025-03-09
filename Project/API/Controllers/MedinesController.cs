using API.Models.DTOs.Request.Create;
using API.Models.DTOs.Response;
using API.Models.Entities;
using API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedinesController : ControllerBase
    {
        private readonly IMedicineRepository medicineRepository;

        public MedinesController(IMedicineRepository medicineRepository)
        {
            this.medicineRepository = medicineRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetMedicines()
        {
            var medicines = await medicineRepository.GetAllAsync();
            return Ok(medicines);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetMedicineById([FromRoute]Guid id)
        {
            var medicine = await medicineRepository.GetByIdAsync(id);
            if (medicine == null)
            {
                return NotFound();
            }
            return Ok(medicine);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMedicine([FromBody] MedicineRequestDTO request)
        {
            //Map DTO <-> Domain: Create Medicine
            var medicine = new Medicine
            {
                MedicineCode = request.MedicineCode,
                Name = request.Name,
                Description = request.Description,
                Image = request.Image,
                Price = request.Price,
                InStock = request.InStock,
                UnitQuantity = request.UnitQuantity,
                UnitType = request.UnitType,
                DosageQuantity = request.DosageQuantity,
                DosageUnit = request.DosageUnit,
                Manufacturer = request.Manufacturer,
                ManufacturedDate = request.ManufacturedDate,
                ActiveIngredient = request.ActiveIngredient,
                ExpiryDate = request.ExpiryDate,
                Status = request.Status,
                MedicineCategoryId = request.MedicineCategoryId,
                CreatedBy = "ADMIN",
                CreatedAt = DateTime.Now,
                UpdatedBy = null
            };

            await medicineRepository.CreateAsync(medicine);

            // Map Domain <-> DTO: Response Medicine

            var response = new MedicineResponseDTO
            {
                Id = medicine.Id,
                MedicineCode = medicine.MedicineCode,
                Name = medicine.Name,
                Description = medicine.Description,
                Image = medicine.Image,
                Price = medicine.Price,
                InStock = medicine.InStock,
                UnitQuantity = medicine.UnitQuantity,
                UnitType = medicine.UnitType,
                DosageQuantity = medicine.DosageQuantity,
                DosageUnit = medicine.DosageUnit,
                Manufacturer = medicine.Manufacturer,
                ManufacturedDate = medicine.ManufacturedDate,
                ActiveIngredient = medicine.ActiveIngredient,
                ExpiryDate = medicine.ExpiryDate,
                Status = medicine.Status,
                MedicineCategoryId = medicine.MedicineCategoryId
            };

            return Ok(response);
        }
    }
}
