
namespace csharp_programming
{
    internal class Program
    {
        public void F() { }
        public static void G() { }

        public void H() { 
            F();
            G();
        }

        public static void I() {
            F();
            G();
        }
        
    }
}

// A non-static member can access another static and non-static member.
// A static member can access only another static member.
