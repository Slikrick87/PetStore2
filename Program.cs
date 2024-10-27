
using PetStore;

//Console.WriteLine("Press 1 to add a product.");
//Console.WriteLine("Type 'exit' to quit");
//var ProductLogic = new ProductLogic(); //use lowercase to not confuse instance with class underline if private
//string userInput = null;
string userInput = string.Empty;
var EvaluateInput = new EvaluateInput();


while (userInput == null || userInput.ToLower().Trim() != "exit")
{
    Console.WriteLine("Press 1 to add a product.");
    Console.WriteLine("Press 8 to view entered products");
    Console.WriteLine("Type 'exit' to quit");
    userInput = Console.ReadLine();
    EvaluateInput.CheckInput(userInput);
    //if (userInput.ToLower().Trim() != "exit");
    //{ 
    //    //Console.WriteLine("Press 1 to add a product.");
    //    //Console.WriteLine("Type 'exit' to quit");
    //    //userInput = Console.ReadLine();

    //}
    //if (userInput == "1")
    //{
    //    Console.WriteLine("Please type Product type to be added.\n*Compatible Types: Dog Leash, Cat Food");
    //    userInput = Console.ReadLine();


    //    if (userInput.ToLower().Replace(" ", "") == "dogleash")
    //    {
    //        newDogLeash.NewDogLeash(ProductLogic);
    //    }
    //    else if (userInput.ToLower().Replace(" ", "") == "catfood")
    //    {
    //        newCatFood.NewCatFood(ProductLogic);
    //    }
    //}
    //else if (userInput == "8")
    //{
    //    Console.WriteLine("hey");
    //    ProductLogic.GetAllProducts(ProductLogic._products);
    //}

}
