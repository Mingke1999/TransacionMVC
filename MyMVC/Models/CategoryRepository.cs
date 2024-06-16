namespace MyMVC.Models
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category{ Id = 1,Name="Fish Oil", Description="1500mg"},
            new Category{ Id = 2,Name="CUMIN", Description="25g"},
            new Category{ Id = 3,Name="Calcuim & Vitamin D3", Description="2-a-day"},
            new Category{ Id = 4,Name="CLINIQUE", Description="BB-gel"},


        };

        public static void AddCategory(Category category)
        {
            var maxId = _categories.Max(x => x.Id);
            category.Id = maxId + 1;
            _categories.Add(category);
        }
        //return all categories
        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategoryById(int categoryId)
        {
            var category = _categories.FirstOrDefault(x => x.Id == categoryId);
            if (category != null)
            {
                return new Category
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description,
                };
            }
            return null;
        }

        public static void UpdateCategory(int categoryId, Category category)
        {
            if(categoryId != category.Id) { return; }

            var categoryToUpdate = _categories.FirstOrDefault(x => x.Id == categoryId);
            if (categoryToUpdate!=null)
            {   
                categoryToUpdate.Description = category.Description;
                categoryToUpdate.Name = category.Name;
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            var categoryToRemove = _categories.FirstOrDefault(x => x.Id == categoryId);
            if (categoryToRemove != null)
            {
                _categories.Remove(categoryToRemove);
            }
        }
    }
}
