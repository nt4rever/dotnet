using NetFundamental;
using NetFundamental.Attributes;
using NetFundamental.MultiThreading;
//using NetFundamental.OOP;

//var varType = new VariableType
//{
//    Level = 10,
//    Age = 10,
//};

//Console.ForegroundColor = ConsoleColor.Green;
//Console.WriteLine("Is Private: {0}", VariableType.isPrivate);
//Console.ResetColor();
//Console.WriteLine($"Age : {varType.Age}, Level : {varType.Level}");

//VariableType.Sum(1, 5);
//Console.WriteLine(VariableType.MAX_AGE_TOKEN);


//var operatorExample = new Operator();
//operatorExample.Example();
//ArrayPractice.TestFindAll();


//int a = 5, b = 6;
//Ref.SwapGeneral(ref a, ref b);
//Console.WriteLine($"{a} {b}");

//int timeOut;
//Ref.TimeOut(out timeOut, 12);
//Console.WriteLine(timeOut.ToString());
//List<int> listInt = new() { 1, 2, 4 };
//List<double> listDouble = new() { 1, 2.5, 4 };

//Console.WriteLine(OverLoading.Sum(listInt));
//Console.WriteLine(OverLoading.Sum(listDouble));


//FormRequest formRequest = new();
//formRequest.Rules();
//formRequest.Validation();


//SingleTon.Instance.Id = 298;

//FormRequest loginRequest = new LoginRequest("hello");
//loginRequest.Rules();
//loginRequest.Validation();


//StringRegex stringRegex = new StringRegex();
//stringRegex.TestRegex();

//Log? log = new();
//log.TestShowLog();

//int[] numbers = new int[5] { 1, 2, 4, 5, 2 };

//Console.WriteLine(MyArray.Count(numbers));
//Console.WriteLine(MyArray.IndexOf(numbers, 15));
////MyArray.ForEach(numbers, (value, index) => Console.Write($"numbers[{index}]={value}\n"));
//Console.WriteLine(MyArray.Reduce(numbers, (x) => x * 2, 0));
//MyArray.ForEach(MyArray.Map( numbers, x => x * 3), (x, _) => Console.WriteLine(x));

//string text = "Pretty girl";
//text.Print(ConsoleColor.Green);

//IndexerExam indexerExam = new IndexerExam();
//Console.WriteLine($"{indexerExam["firstName"]} - {indexerExam["lastName"]}");
//indexerExam["firstName"] = "Ashley";
//indexerExam["lastName"] = "Tan";
//Console.WriteLine($"{indexerExam["firstName"]} - {indexerExam["lastName"]}");

//using (WriteData writeData = new WriteData("filename.txt"))
//{
//    // do something
//}

//var products = new List<Product>            // khởi tạo 1 phần tử
//{
//    new Product(1, "Iphone 6", 100, "Trung Quốc"),
//    new Product(2, "Glaxy 4", 500, "Việt Nam")
//};
//var arrayProducts = new Product[]                  // Mảng 2 phần tử
//{
//    new Product(4, "Glaxy 7", 500, "Việt Nam"),
//    new Product(5, "Glaxy 8", 700, "Việt Nam"),
//};
//products.AddRange(arrayProducts);
//products.Sort();
//foreach (var product in products)
//{
//    Console.WriteLine(product.ToString(format: "O"));
//}


//var stackAndQueue = new StackAndQueue();
//stackAndQueue.TestQueue();
//stackAndQueue.TestStack();
//stackAndQueue.Example();

//var linkedList = new LinkedListDemo();
//linkedList.TestLinkedList();

//var linkedList = new MyLinkedList<string>();
//linkedList.AddFirst("1");
//linkedList.AddFirst("2");
//linkedList.AddFirst("3");
//linkedList.AddFirst("4");
//linkedList.AddLast("5");
//linkedList.AddFirst("6");
////6 -> 4 -> 3 -> 2 -> 1 -> 5
//linkedList.Remove("5");
//var len = linkedList.Count;
//linkedList.ForEach((x, index) =>
//{
//    var arrow = index == len ? "" : " -> ";
//    Console.Write($"{x}{arrow}");
//});

//var demoCollection = new Collection();
//demoCollection.DemoDictionary();

//var demoLinq = new LINQ();
//demoLinq.ProductPriceEqual400();
//demoLinq.ProductGroup();

//DownloadWebsite.Test();

//Task<string> t1 = TestAsync.Async1("a", "b");
//Task<string> t2 = TestAsync.Async1("c", "d");
//t1.Start();
//t1.Wait();
//t2.Start();
//Console.WriteLine(t1.Result);
//Console.WriteLine(t2.Result);
//TestAsync.DemoToken();
AttrDemo.Demo();
