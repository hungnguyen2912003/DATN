using API.Models.Common;
using API.Models.Entities;
using API.Repositories.Interfaces;

namespace API.Repositories.Implementations
{
    public class MedicineRepository : BaseRepository<Medicine>, IMedicineRepository
    {
        public MedicineRepository(HospitalDBContext context) : base(context)
        {
        }
    }
}
