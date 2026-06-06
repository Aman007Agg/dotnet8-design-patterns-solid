using MementoPattern;

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        History history = new History();

        //Version-1
        editor.Content = "Hello, World!";
        history.Push(editor.Save());

        //Version-2
        editor.Content = "Hello, C#!";
        history.Push(editor.Save());

        //Version-3
        editor.Content = "Hello, Aman Agrawal!";
        history.Push(editor.Save());
        Console.WriteLine(editor.Content);

        editor.Restore(history.Pop());
        Console.WriteLine(editor.Content);

        editor.Restore(history.Pop());
        Console.WriteLine(editor.Content);

    }
}