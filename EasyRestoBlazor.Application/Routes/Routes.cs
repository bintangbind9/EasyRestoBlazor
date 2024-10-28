namespace EasyRestoBlazor.Application.Routes
{
    public class Routes
    {
        public const string Root = "/";
        public const string Login = $"{Root}login";
        public const string Register = $"{Root}register";
        public const string Dashboard = $"{Root}dashboard";
        public const string Food = $"{Root}food";
        public const string FoodCategory = $"{Food}/category";
        public const string FoodCategoryCreate = $"{FoodCategory}/create";
        public const string FoodCategoryUpdate = $"{FoodCategory}/update";
    }
}
