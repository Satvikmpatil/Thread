// class Program1
// {
//     public static void Main(String[] args)
//     {
//         int a =90;
//         void MyFunction()
//         {   
//             a=30;
//             Console.WriteLine(a);
//         }
//         void MyFunction2()
//         {
//             a=20;
//             Console.WriteLine(a);
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
