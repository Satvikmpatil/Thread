// class Program3
// {
//     private static readonly object lockObj = new();

//     public static void Main(String[] args)
//     {
//         int a = 90;
//         var done1 = new ManualResetEvent(false);
//         var done2 = new ManualResetEvent(false);

//         void MyFunction()
//         {
//             lock (lockObj)
//             {
//                 a = 30;
//                 Console.WriteLine($"MyFunction: {a}");
//             }
//             done1.Set();
//         }

//         void MyFunction2()
//         {
//             lock (lockObj)
//             {
//                 a = 20;
//                 Console.WriteLine($"MyFunction2: {a}");
//             }
//             done2.Set();
//         }

//         Console.WriteLine($"Before: {a}");

//         ThreadPool.QueueUserWorkItem(_ => MyFunction());
//         ThreadPool.QueueUserWorkItem(_ => MyFunction2());

//         WaitHandle.WaitAll(new[] { done1, done2 });

//         Console.WriteLine($"After: {a}");
//     }
// }
