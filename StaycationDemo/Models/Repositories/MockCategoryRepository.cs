using StaycationDemo.Models.Abstractions;
using System.Collections.Generic;

namespace StaycationDemo.Models.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Houses with beauty backyard", Description="Beautiful and spacious backyards."},
                new Category{CategoryId=2, CategoryName="Hotels with large living room", Description="Excusit living rooms."},
                new Category{CategoryId=3, CategoryName="Apartments with kitchen set", Description="The perfect kitchen."}
            };
    }
}
