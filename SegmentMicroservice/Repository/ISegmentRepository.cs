using System.Collections.Generic;
using System.Threading.Tasks;
using SegmentMicroservice.Models;

namespace SegmentMicroservice.Repository
{
    public interface ISegmentRepository : IEntityRepository<Segment>
    {
        Task<ICollection<Segment>> FindRefundSegmentsWithSameTicketNumberAsync(string str);
        
    }
}