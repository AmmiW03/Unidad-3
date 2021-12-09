class program
{

    static void Main(string[]argls)
    {
        if (argls is null)
        {
            throw new ArgumentNullException(nameof(argls));
        }
    }
}