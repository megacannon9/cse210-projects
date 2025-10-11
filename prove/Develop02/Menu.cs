using System;

public class Menu
{
    public string _write;

    public string _display;

    public string _save;

    public string _load;

    public string _prompt;

    public string _help;

    public string _quit;

    public void DisplayMenu()
    {
        Console.WriteLine($"{_write}");
        Console.WriteLine($"{_display}");
        Console.WriteLine($"{_save}");
        Console.WriteLine($"{_load}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_help}");
        Console.WriteLine($"{_quit}");
    }
}
