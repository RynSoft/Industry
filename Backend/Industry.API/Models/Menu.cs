

namespace Industry.API
{
    public class Menu : BaseFullModel<Guid>
    {
        public Menu()
        {
        }

        public int Order { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string? Icon { get; set; }
        public Guid? ParentMenuId { get; set; }

        public virtual ICollection<Menu> SubMenus { get; set; }
        public virtual Menu ParentMenu { get; set; }

    }
}
