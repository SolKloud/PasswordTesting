// See https://aka.ms/new-console-template for more information

using System;
namespace VerifyPassword
{
    public class Password
    {
        //static string password = "soL44Sol";
        static int MaxPasswordLength = 8;
        static bool isValid = true;
        public static bool Verify(string password)
        {
            // string password="solaris";     

            //TO CHECK PASSWORD LENGTH
            try
            {
                if (password.Length < MaxPasswordLength)
                {
                    throw new Exception("The password is less than 8 digits");
                    isValid = false;
                }

                ValidateNull();
            }
            catch (Exception e)
            {
              //  Console.WriteLine(e.Message);
            }

            //TO CHECH PASSWORD NULL OR NOT
            void ValidateNull()
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(password))
                    {
                        throw new Exception("The password cannot be null");
                        isValid = false;
                    }

                    ValidateDigit();
                }
                catch (Exception e)
                {
                //    Console.WriteLine(e.Message);
                }
            }

            //TO CHECK PASSWORD CONTAINS DIGIT
            void ValidateDigit()
            {
                try
                {
                    if (!password.Any(char.IsDigit))
                    {
                        throw new Exception("The password should have atleast one digit");
                        isValid = false;
                    }

                    ValidateUpper();
                }
                catch (Exception e)
                {
                  //  Console.WriteLine(e.Message);
                }
            }

            //TO CHECK IT CONTAINS UPPER CASE OR NOT
            void ValidateUpper()
            {
                try
                {
                    if (!password.Any(char.IsUpper))
                    {
                        throw new Exception("The password should contain uppercase");
                        isValid = false;
                    }

                    ValidateLower();
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                }
            }

            //TO CHECK IT CONTAINS LOWER CASE OR NOT
            void ValidateLower()
            {
                try
                {
                    if (!password.Any(char.IsLower))
                    {
                        throw new Exception("The password should contain lower case");
                        isValid = false;
                    }

                    //Console.WriteLine("The password is valid");
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
                }
            }
            return isValid;

        }
    }
}
