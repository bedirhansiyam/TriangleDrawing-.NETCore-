namespace TriangleDrawing;
class Program
{
    static void Main(string[] args)
    {
        bool result;
        int height;
        Console.Write("Please enter the height of the triangle : ");
        do
        {
            result = int.TryParse(Console.ReadLine(),out height);

            if(result == false || height < 1)
                Console.WriteLine("Please enter the positive number : ");
            
        }while(result == false || height < 1);
        
        for(int k = 1; k <= height; k++)
        {
            for(int i = 0; i < height-k; i++)
            {
                Console.Write(" ");            
            }
            for(int j = 0; j < k; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
    }
}
