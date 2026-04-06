// class Program2
// {
//     private static object lockObj = new object();

//     public static void Main(String[] args)
//     {
//         int a = 90;

//         void MyFunction()
//         {
//             lock (lockObj)
//             {
//                 a = 30;
//                 Console.WriteLine(a);
//             }
//         }
//         void MyFunction2()
//         {
//             lock (lockObj)
//             {
//                 a = 20;
//                 Console.WriteLine(a);
//             }
//         }

//         async Task MyAsyncFunction()
//         {
//             await Task.Run(() => MyFunction());
//             await Task.Run(() => MyFunction2());
//         }

//         Console.WriteLine(a);
//         MyAsyncFunction().Wait();
//         Console.WriteLine(a);
//     }
// }
