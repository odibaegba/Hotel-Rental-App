using System.Collections.Generic;
using System.IO.Pipelines;

namespace StaycationDemo.Models.Abstractions
{
    public interface IHotelRepository
    {
        IEnumerable<Suite> AllHotels { get; }
        IEnumerable<Suite> MostPickedHotels { get; }
        Suite GetHotelById(int hotelId);
        bool SaveHotel(Suite hotel);
    }
}
