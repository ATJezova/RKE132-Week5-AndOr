//math >= 90 or chem >= 90;

//mat && chem || math && bio || bio && chem

int math, biology, chemistry;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemstry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (biology >= 90 && chemistry >= 90))
{
    Console.WriteLine("Congratulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application can not be approved.");
}