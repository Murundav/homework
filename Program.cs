int Akerman(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }

    else if ( x > 0 && y == 0)
    {
        return Akerman(x - 1, 1);
    }

    else if (x > 0 && y > 0)
    {
        return Akerman(x - 1, Akerman(x, y - 1));
    }

    else 
    {
        return 0;
    }
}

int m = 3;
int n = 2;

int function = Akerman(m, n);

System.Console.WriteLine(function);