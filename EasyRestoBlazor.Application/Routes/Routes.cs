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
        public const string DiningTable = $"{Root}dining-table";
        public const string DiningTableCreate = $"{DiningTable}/create";
        public const string DiningTableUpdate = $"{DiningTable}/update";
        public const string AppUser = $"{Root}app-user";
        public const string AppUserCreate = $"{AppUser}/create";
        public const string AppUserUpdate = $"{AppUser}/update";
    }
}
