using System;

namespace Test;

public static class Program
{
    private static void Main()
    {
        // IDE0059 and IDE0007
        int x = 0;

        throw new NotImplementedException();
    }
}
