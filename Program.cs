
//write a program to implement a stack by using array with
//push and pop operations - non descript?

// have concept? - vending machine
//define variables
//build stack - keep it simple

namespace Assignment_6._2_Question_1
{
    public class VendingMachine
    {
        //build stack
        private Stack<string> items; 

        public VendingMachine()
        {
            items = new Stack<string>();
        }

        //push items
        public void PushItem(string item)
        {
            items.Push(item); 
            //plural or singular?
            Console.WriteLine($"{item} have been stocked in the vending machine.");
        }

        //pop items - pop pop?
        public void PopItem()
        {
            if (items.Count > 0)
            {
                string item = items.Pop();
                Console.WriteLine($"Dispensing '{item}'...");
            }
            else
            {
                Console.WriteLine("It's totally empty.");
            }
        }

        //items.peek?

        //show the stack
        public void ShowItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("It's totally empty.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Items currently in the vending machine:");
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            //virtual vending machine?
            VendingMachine vendingMachine = new VendingMachine();

            Console.WriteLine("The Virtual Vending Machine console app is being stocked: ");
            Console.WriteLine("");

            //drinks availible like options?
            //costs?
            vendingMachine.PushItem("Energy Drinks");
            vendingMachine.PushItem("Cokes");
            vendingMachine.PushItem("Coldbrew Coffees");
            vendingMachine.PushItem("Waters");
            vendingMachine.PushItem("Haterades");
            //vendingMachine.PushItem("");

            //display
            vendingMachine.ShowItems();

            //how to pick specific items? - pointers? order on stack
            Console.WriteLine("");
            Console.WriteLine("Attempting to dispense items:");
            vendingMachine.PopItem();
            vendingMachine.PopItem(); 
            vendingMachine.PopItem();

            //display remaining item on stack?
            vendingMachine.ShowItems();
        }
    }
}
