Console.Clear();

string[] Merge(string[] a)
{
    string[] name = new string[a.Length];

    for (int i = 0; i <= a.Length - 1; i++)

        if (i % 2 == 0) name[i] = a[i] + a[i + 1];
        
    return name;
}

void ShowName(string[] a)
{
    for (int i = 0; i < a.Length; i++)
        Console.Write(a[i] + " ");
}

string[] alphabet = { "A", "a", "B", "b", "C", "c"};
ShowName(Merge(alphabet));
