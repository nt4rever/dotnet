using EF_Model.Models;

var shopContext = new ShopContext();
await shopContext.DeleteDatabase();
await shopContext.CreateDatabase();

//var testDB = new EF_Model.TestDB();
////await testDB.InsertSample();
//var item = await testDB.FindProduct(1);
//var cate = await testDB.FindCategory(1);
//Console.WriteLine(item.Category);