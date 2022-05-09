using System;
namespace RegixValidationDemo
{
    class program
    {
        static void Main(string[] args)
        {
            PinCodeValidation validation = new PinCodeValidation();
            validation.Validate("425404");
            //validation.Validate("A42540");
            //validation.Validate("42540B");
            //validation.Validate("425 404");
            //validation.ValidateEmail("b");
            //validation.ValidateEmail("abc@gmail.com.in");
            validation.ValidateEmail("harshalapatil2796@gmail.com");
        }
    }
}