class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        int x = 40;
        return x;
    }

    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return 40 - actualMinutesInOven;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int actualMinutesInOven)
    {
        var cookingMinutes = PreparationTimeInMinutes(layers);
        return cookingMinutes + actualMinutesInOven;
    }
}
