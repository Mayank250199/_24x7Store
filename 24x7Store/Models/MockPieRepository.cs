using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _24x7Store.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {
                    PieID = 1, 
                    Name="Strawberry Pie",
                    Price=15.95M, 
                    ShortDescription="Lorem Ipsum", 
                    LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 
                    AllergyInfromation = "None", 
                    Instock=true, 
                    ImageUrl="https://www.thecountrycook.net/wp-content/uploads/2019/04/slice-Shoneys-Strawberry-Pie.jpg", 
                    ImageThumbnailUrl="https://therecipecritic.com/wp-content/uploads/2019/06/freshstrawberrypie_hero.jpg",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    CategoryId=102, 
                    IsPieOfTheWeek=true
                },
                 new Pie {
                    PieID = 2,
                    Name="Chocolate Pie",
                    Price=18.95M,
                    ShortDescription="Lorem Ipsum",
                    LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    AllergyInfromation = "None",
                    Instock=true, 
                    ImageUrl="https://tastykitchen.com/recipes/wp-content/uploads/sites/2/2014/10/DSC_6395-420x279.jpg",
                    ImageThumbnailUrl="https://beyondfrosting.com/wp-content/uploads/2019/03/Chocolate-Pie-Recipe-045.jpg",
                    Category = _categoryRepository.AllCategories.ToList()[1],
                    CategoryId=101,
                    IsPieOfTheWeek=true
                },
                  new Pie {
                    PieID = 3,
                    Name="Pineapple Pie",
                    Price=15.95M,
                    ShortDescription="Lorem Ipsum",
                    LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    AllergyInfromation = "None",
                    Instock=true, 
                    ImageUrl="https://img.sndimg.com/food/image/upload/c_thumb,q_80,w_412,h_232/v1/img/recipes/32/99/44/pic2xhIrj.jpg",
                    ImageThumbnailUrl="https://cdn3.tmbi.com/toh/GoogleImagesPostCard/Creamy-Pineapple-Pie_EXPS_BDSMZ17_231_D03_02_1b.jpg",
                    Category = _categoryRepository.AllCategories.ToList()[2],
                    CategoryId=103,
                    IsPieOfTheWeek=true
                },
                   new Pie {
                    PieID = 4,
                    Name="Coconut Pie",
                    Price=15.95M,
                    ShortDescription="Lorem Ipsum",
                    LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    AllergyInfromation = "None",
                    Instock=true,
                    ImageUrl="https://www.kingarthurflour.com/sites/default/files/recipe_legacy/1030-3-large.jpg",
                    ImageThumbnailUrl="https://images-gmi-pmc.edge-generalmills.com/fa2cc190-1988-4cb1-92a1-b946f603e556.jpg",
                    Category = _categoryRepository.AllCategories.ToList()[0],
                    CategoryId=103,
                    IsPieOfTheWeek=true
                },
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieID == pieId);
        }
    }
}
