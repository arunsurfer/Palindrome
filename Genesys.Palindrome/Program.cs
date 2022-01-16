using Genesys.Palindrome.Repository;
using SimpleInjector;
using System;

namespace Genesys.Palindrome
{
    static class Program
    {       


        private static readonly Container container;

        static Program()
        {
            container = new Container();

            container.Register<IPalindromeFeatures, PalindromeFeatures>();
          

            container.Verify();
        }
        static void Main(string[] args)
        {
            var service = container.GetInstance<IPalindromeFeatures>();

            string userInfo = Constant.MsgUserInfo;

            Console.WriteLine(userInfo);


            var input = Console.ReadLine();

            bool isPalindrome = service.IsPalindrome(Convert.ToString(input));

            if (isPalindrome)
            {
                Console.WriteLine(Constant.MsgPalindrome);            

                Console.WriteLine(Constant.MsgQuestionFeature);

                Console.WriteLine(Constant.MsgFeatures);

                while (true)
                {

                    var choice = Console.ReadLine();

                    switch (Convert.ToString(choice))
                    {
                        case Constant.CharacterCount:
                            int count = service.GetCharacterCount(Convert.ToString(input));
                            Console.WriteLine(Constant.MsgCharacterCount + " " + count);
                            break;
                        case Constant.DataType:
                            string dataType = service.CheckDataType(Convert.ToString(input));
                            Console.WriteLine(dataType);
                            break;
                        case Constant.InputType:
                            string inputType = service.CheckInputType(Convert.ToString(input));
                            Console.WriteLine(inputType);
                            break;
                        default:
                            return;                            
                    }
                }
            }
            else
            {
                Console.WriteLine(Constant.MsgNotPalindrome);
            }
        }
    }
}
