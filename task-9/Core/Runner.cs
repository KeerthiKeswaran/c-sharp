using System;
using System.Linq;
using System.Reflection;
using Attributes;

namespace Core
{
    public class Runner
    {
        public void ExecuteAll()
        {
            // STEP 1: Get current assembly (compiled project)
            var assembly = Assembly.GetExecutingAssembly();

            // STEP 2: Get all types (classes)
            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                // Skip non-class types (optional safety)
                if (!type.IsClass)
                    continue;

                // STEP 3: Get all methods of class
                var methods = type.GetMethods();

                foreach (var method in methods)
                {
                    // STEP 4: Check if method has [Runnable]
                    bool isRunnable = method
                        .GetCustomAttributes(typeof(RunnableAttribute), false)
                        .Any();

                    if (!isRunnable)
                        continue;

                    // STEP 5: Validate method signature (important safety)
                    if (method.GetParameters().Length > 0)
                        continue;

                    if (method.ReturnType != typeof(void))
                        continue;

                    Console.WriteLine($"Executing: {type.Name}.{method.Name}");

                    try
                    {
                        // STEP 6: Create instance dynamically
                        var instance = Activator.CreateInstance(type);

                        // STEP 7: Invoke method
                        method.Invoke(instance, null);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error executing {method.Name}: {ex.Message}");
                    }
                }
            }
        }
    }
}