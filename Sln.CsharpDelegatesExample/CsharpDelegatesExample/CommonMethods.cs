namespace CsharpDelegatesExample
{
    public class CommonMethods
    {
        public int AdditionNum(int x, int y)
        {
            return x + y;
        }

        public int SubtractionNum(int x, int y)
        {
            if (y > x) return y - x;
            return x - y;
        }

        public int MultiplicationNum(int x, int y)
        {
            return x * y;
        }
        
        public int DivisionNum(int x, int y)
        {
            if (y > x) return y / x;
            return x / y;
        }

    }
}
