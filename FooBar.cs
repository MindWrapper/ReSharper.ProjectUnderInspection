public class FooBar
{
    public bool MethodWithHighCyclomaticComplexity(bool b1, bool b2, bool b3)
    {
        int i = 50;
        switch (i)
        {
            case 0:
                if (b1 || b2 && !b3)
                    return false;
                return true;
            case 1:
                if (b1 || b2 && !b3)
                    return false;
                return true;
            case 2:
                if (b1 || b2 && !b3)
                    return false;
                return true;
            case 4:
                if (b1 || b2 && !b3)
                    return false;
                return true;
            case 5:
                if (b1 || b2 && !b3)
                    return false;
                return true;
            case 6:
                if (b1 || b2 && !b3)
                    return false;
                return true;
            case 7:
                if (b1 || b2 && !b3)
                    return false;
                return true;
        }

        if (b1 || b2 || !b3)
            return false;
        return true;
    }
}

