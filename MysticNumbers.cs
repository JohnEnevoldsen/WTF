namespace WTF
{
    public class MysticNumbers
    {
        #region Methods
        public static int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if(TwoNumbers(a,b) > c){
                result = TwoNumbers(a,b);
            }else{
                result = c;
            }
            return result;
        }
        public static int TwoNumbers(int a, int b){
            int result;
            if(a > b){
                result = a;
            }else{
                result = b;
            }
            return result;
        }
        public static int FourNumbers(int a, int b, int c, int d){
            return TwoNumbers(TwoNumbers(a,b),TwoNumbers(c,d));
        }
        #endregion
    }
}