using System;
using System.Reflection;

namespace csharp_training {
    class Program {
        static void Main() {
            AppDomain newDomain = AppDomain.CreateDomain("NewDomain");
            Assembly a = newDomain.Load("MyMath");

            Assembly[] assemblies = newDomain.GetAssemblies();

            Console.WriteLine("Number of Assemblies loaded in NewDomain: {0}", assemblies.Length);
            foreach (Assembly assembly in assemblies) {
                Console.WriteLine(assembly.FullName);
            }
            Type MathType = a.GetType("MyMath.Math");

            object obj = Activator.CreateInstance(MathType);

            MethodInfo myMethod = MathType.GetMethod("Add");
            object[] parameters = { 2, 3 };
            int n = (int)myMethod.Invoke(obj, parameters);

            Console.WriteLine("The sum of two numbers is: {0}", n);
            AppDomain.Unload(newDomain);
        }
    }
}

/*
 * AppDomain is a logical container in which a set of assemblies
 * can be loaded as one unit.
 * 
 * When an application starts, a default AppDomain is automatically
 * created to host the application's main entry point. Additional
 * AppDomains can be created programmatically using the
 * AppDomain.CreateDomain method.
 * 
 * Each AppDomain has its own set of properties and methods, such as Unload,
 * which can be used to unload the AppDomain and release its resources.
 */