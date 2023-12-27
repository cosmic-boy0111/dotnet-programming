
namespace csharp_programming
{
    public class TowerFactory : Tower, IPropertyFactory
    {
        public Tower CreateProperty()
        {
            Tower tower = new Tower();
            return tower;
        }
    }
}
