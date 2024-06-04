using ConsoleApp7;

class Proqram
{
    static void Main(string[] args)
    {
        p p1= new p();
        Hekim hekim1 = new Hekim("Arzu", "Hesenova", 3);
        Hekim hekim2 = new Hekim("Akif", "Elmirov", 5);
        Pediatriya pe1=new Pediatriya(hekim1);
        Pediatriya pe2 =new Pediatriya(hekim2);
        p1.AddP(pe1 );
        p1.AddP(pe2 );

        Console.WriteLine(p1 );
    }

    
}