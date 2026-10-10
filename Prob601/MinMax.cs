class MinMax
{
    public int Max(int n1, int n2, int n3)
    {
        if (n1 >= n2 && n1 >= n3)
        {
            return n1;
        }
        else if (n2 >= n1 && n2 >= n3)
        {
            return n2;
        }
        return n3;
    }

    public int Min(int n1, int n2, int n3)
    {
        if (n1 <= n2 && n1 <= n3)
        {
            return n1;
        }
        else if (n2 <= n1 && n2 <= n3)
        {
            return n2;
        }
        return n3;
    }
}