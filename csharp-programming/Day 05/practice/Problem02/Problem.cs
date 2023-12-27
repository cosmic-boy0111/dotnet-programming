
namespace csharp_programming
{
    internal class Problem
    {
        public static void Main()
        {
            TowerFactory tf = new TowerFactory();
            Tower t = tf.CreateProperty();
            t.Render();
        }
    }
}
