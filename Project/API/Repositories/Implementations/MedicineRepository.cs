using API.Models.Common;
using API.Models.Entities;

namespace API.Repositories.Implementations
{
    public class MedicineRepository : BaseRepository<Medicine>
    {
        public MedicineRepository(HospitalDBContext context) : base(context)
        {
        }
    }
}
