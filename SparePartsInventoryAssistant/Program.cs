Console.WriteLine("Hej. Welcome to the spare parts inventory! ");
bool partAvailable = false;

while (!partAvailable)
{
    Console.Write("Which part do you need? ");
    string input = Console.ReadLine();
    
    if (input == "hydraulic pump" || input == "PLC module" || input == "servo motor")
    {
        Console.WriteLine($"I have got {input} here for you. Bye!");
        partAvailable = true;
    }
   
    else if (input == "Do you actually have any parts?" || input == "Is there anything in stock at all?")
    {
        Console.WriteLine("""
                          We have 3 part(s)!
                          hydraulic pump
                          PLC module
                          servo motor
                          """);
    }

    else                                                                                    
    {
        Console.WriteLine($"I am afraid we don’t have any {input} in the inventory");
    }
}





























