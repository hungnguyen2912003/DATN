using API.Models.Common;
using API.Models.Entities;
using API.Repositories.Interfaces;

namespace API.Repositories.Implementations
{
    public class MedicineCategoryRepository : BaseRepository<MedicineCategory>, IMedicineCategoryRepository
    {
        public MedicineCategoryRepository(HospitalDBContext context) : base(context)
        {
        }
    }
}
