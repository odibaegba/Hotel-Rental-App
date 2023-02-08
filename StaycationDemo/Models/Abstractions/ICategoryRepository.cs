using System.Collections.Generic;

namespace StaycationDemo.Models.Abstractions
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
