using System;
class Program
{
    static void Main(string[] args)
    {
        Menu newMenu = new Menu();
        Journal newJournal = new Journal();
        newMenu.StartMenu(newJournal);
    }
}