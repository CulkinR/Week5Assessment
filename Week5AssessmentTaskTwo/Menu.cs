namespace Week5AssessmentTaskTwo;

using static System.Console;

public class Menu
{

    public string[] menuSelect { get; set; }


    public Menu(string[] menuSelect)
    {
        this.menuSelect = menuSelect;
    }

    public void menu()
    {
        for (int i = 0; i < menuSelect.Length; i++)
        {
            WriteLine($"{i + 1}.) {menuSelect[i]}");
        }
    }
}