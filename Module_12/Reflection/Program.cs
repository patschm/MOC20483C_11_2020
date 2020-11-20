using System;
using System.Linq;
using System.Reflection;

namespace Reflection
{
 
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom("E:\\release\\EF.dll");
            Console.WriteLine(asm.FullName);
            //ShowContent(asm);
            DoeErIetsMee(asm);
            //EF.Entities.Person p = new EF.Entities.Person();
        }

        private static void DoeErIetsMee(Assembly asm)
        {
            Type tp = asm.GetType("EF.Entities.Person");
            Type ta = asm.GetType("EF.MyAttribute");

            dynamic atr = tp.GetCustomAttribute(ta);
            if (atr.Age > 50)
            {
                Console.WriteLine("Te oud");
            }
            else
            {
                Console.WriteLine("Te jong");
            }

            FieldInfo fi = tp.GetFields(BindingFlags.Instance | BindingFlags.NonPublic).FirstOrDefault();
            Console.WriteLine(fi.Name);
            
            object p = Activator.CreateInstance(tp);
            dynamic p2 = Activator.CreateInstance(tp);

            p2.ID = 200;
            Console.WriteLine(p2.ID);
            string vals = p2.ToString();

            fi.SetValue(p, 100);
            PropertyInfo pi =  tp.GetProperty("ID");
            //pi.SetValue(p, 45);
            object res = pi.GetValue(p);
            Console.WriteLine(res);

            MethodInfo ts = tp.GetMethod("ToString");
            object result = ts.Invoke(p, new object[] { });
            Console.WriteLine(result);


        }

        private static void ShowContent(Assembly asm)
        {
            foreach(Type tp in asm.GetTypes())
            {
                Console.WriteLine(tp.FullName);
                foreach(MemberInfo mi in tp.GetMembers())
                {
                    Console.WriteLine(mi.Name);
                }
            }
        }
    }
}
