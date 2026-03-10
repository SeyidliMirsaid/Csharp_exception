[Throw.txt](https://github.com/user-attachments/files/25885063/Throw.txt)
catch(ArithmeticException arex)
{
    throw new NullReferenceException("Operations is Aricmetic.");
    Console.WriteLine(arex.Message);
    throw;
}
catch(System.Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}

difference between throw and throw e. 
It is a list that shows which steps the program went through before reaching the error when a program error occurs.
Stack trace – proqramda xəta baş verəndə, proqramın hansı addımlardan keçərək o xətaya çatdığını göstərən siyahıdır.
