using System;

class Person
{
    public double Selary { get; set; }
    public string Input { get; set; }

    public Person(double selary, string input)
    {
        this.Selary = selary;
        this.Input = input;
    }
}

class Salaries
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Person[] personnel = new Person[N];
        double sum = 0;
        for (int i = 0; i < N; i++)
        {
            personnel[i] = new Person(0, Console.ReadLine());
            if (personnel[i].Input.IndexOf('Y') == -1)
            {
                personnel[i].Selary = 1;
                sum += personnel[i].Selary;
            }
        }

        bool cont = false;
        for (int i = 0; i < N; i++)
        {
            if (personnel[i].Selary == 0)
            {
                double selary = 0;
                for (int j = 0; j < N; j++)
                {
                    if (personnel[i].Input[j] == 'Y')
                    {
                        if (personnel[j].Selary == 0)
                        {
                            selary = 0;
                            break;
                        }
                        selary += personnel[j].Selary;
                    }
                }

                personnel[i].Selary = selary;
                sum += personnel[i].Selary;
                cont = true;
            }
            if (cont && i == N - 1)
            {
                cont = false;
                i = -1;
            }
        }

        Console.WriteLine(sum);
    }
}