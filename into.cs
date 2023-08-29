

namespace Into
{
    class into
    {
        int num1 = 0;
        int num2 = 1;
        public  into(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int GetResult()
        {
            return num1 * num2;
        }
    }
}
