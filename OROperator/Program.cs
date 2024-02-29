

int math, biology, chemistry;

Console.WriteLine("Entre your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Entre your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Entre your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got Accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}
