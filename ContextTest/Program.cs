using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContextTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example();
            example.Test();
            ContextBound contextBound = new ContextBound();
            contextBound.Test("ContentBound Test\n");

            example.Sync(contextBound);

            Console.ReadLine();
        }
        public class Example
        {
            public void Test()
            {
                ContextMessage("Example Test\n");
            }
            /// <summary>
            /// 访问上下文绑定对象测试
            /// </summary>
            /// <param name="contextBound"></param>
            public void Sync(ContextBound contextBound)
            {
                contextBound.Test("Example call on contextBound\n");
            }
        }
        [Synchronization]
        public class ContextBound : ContextBoundObject
        {
            public void Test(string message)
            {
                ContextMessage(message);
            }
        }
        public static void ContextMessage(string message)
        {
            Context context = Thread.CurrentContext;
            Console.WriteLine($"{message} contenxtid is {context.ContextID}");
            Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}");

            foreach (var pro in context.ContextProperties)
            {
                Console.WriteLine(pro.Name);
            }

            Console.WriteLine();
        }
    }
    
}
