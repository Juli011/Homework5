using Delegate_Event_Lambda.Model;

ArrayHandler arrayHandler = new ArrayHandler(1, 3, 6, 9, 4, 100, 64);
arrayHandler.Notify += DisplayMessage;
var result = arrayHandler.SquareRoots(x => (x % 1 == 0) && x > 5).ToList();



void DisplayMessage(ArrayHandler sender, ArrayEventArgs e)
{
    Console.WriteLine($"SquareRoots number {e.Number} is {e.Number.Root()}");
}
