# Vi bruger console.writeline, bool og string, som vi kender fra tidligere opgaver, hvor jeg har forklaret dem. Vi har igen et scenarie hvor konsollen spørger om noget og vi får input fra brugeren som konsollen så læser. 

# Vi laver bool variabel som vi sætter til at være false. Dette gør vi for at kontrollere om vi har fundet den ønskede reservedel.
# Når konsollen finder delen så ændrer vi den til true for at stoppe vores loop. 
# Vi bruger while loopen, der siger at while we havent found part, keep asking user. 
# !PartAvailable betyder igen at når vi ikke har fundet available part, så kører loopen (derfor udråbstegn). 
Console.WriteLine("Hej. Welcome to the spare parts inventory! ");
bool partAvailable = false;

while (!partAvailable)
{
    Console.Write("Which part do you need? ");
    string input = Console.ReadLine();
# Vi laver string til vores input, og tjekker om input matcher nogen af vores 3 dele.|| betyder eller.
# Vi bruger if funktionen til at sætte denne betingelse.
# Hvis partAvailable = true (delen findes), så siger vi input findes. 
# Vi bruger string interpolation til at gøre dette ($ og input som indsættes i tekst)
    
    if (input == "hydraulic pump" || input == "PLC module" || input == "servo motor")
    {
        Console.WriteLine($"I have got {input} here for you. Bye!");
        partAvailable = true;
    }

# Nu sætter vi anden betingelse som er hvis brugeren spørger om vi har dele overhovedet, dette er kun hvis første if er false. 
# Så hvis input er en af spørgsmålene, så svarer konsollen med antallet af parts og navnene.
# """ er for at skrive det op i flere linjer, ligesom vi kiggede på tabellen i undervisning (4 lektion) og hvordan man kan skrive det ind. 
    else if (input == "Do you actually have any parts?" || input == "Is there anything in stock at all?")
    {
        Console.WriteLine("""
                          We have 3 part(s)!
                          hydraulic pump
                          PLC module
                          servo motor
                          """);
    }

# Den sidste betingelse er (else), som dækker alle andre tilfælde, så hvis input ikke matcher nogen part og heller ikke er en af spørgsmålene. 
# Så giv konsollen besked på at delen ikke findes på lager. 
# Her bruger vi også string interpolation til at indsætte brugerens input ind i beskeden. 


    else                                                                                    
    {
        Console.WriteLine($"I am afraid we don’t have any {input} in the inventory");
    }
}

# ekstra info: Man kunne også bruge contains med spørgsmålene, så hvis inputtet indeholder "any" så svarer konsollen med listen over parts. Jeg prøvede på dette, men kunne ikke få det til at fungere, så derfor har jeg gjort det på den simple måde. 
# Jeg forstod ikke helt program logic, med const string, så det er derfor jeg undgik at bruge det. 
# Skal nok spørge i næste undervisning. 


























