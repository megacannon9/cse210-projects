class Bin
{
    //attributes (variables)
    private string _denomination;
    private double _value;
    private int _count;

    //behaviors (functions)
    //every object oriented language uses a method that has the same name
    //as the class. 例えば class Bin uses Bin() methods.
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }
    //modifier method "Alter" Set method. Used to change the amount in the till.
    public void Alter(int delta)//delta is a measure of change
    {
        _count += delta;
    }
    //accessor "getter" methods
    public string GetDenomination() { return _denomination; }
    public string GetCount() { return _count; }
}