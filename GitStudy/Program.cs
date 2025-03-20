namespace GitStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.Write("숫자을 입력해주세요 :");
            bool Isstring = int.TryParse(Console.ReadLine(), out  input);
            Console.WriteLine(input);
            
        }
    }
}
