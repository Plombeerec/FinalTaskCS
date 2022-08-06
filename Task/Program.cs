/* 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры или задать на старте
выполнения алгоритма.
*/

string[] Massive = {"qwezes", "werzy", "ertre", "rtyuuu", "tyu", "yu", "%)"};

string[] CheckElement(string[] massive)
{
    string[] result = new string[massive.Length];

    for(int i = 0; i < massive.Length; i++)
    {
        if(massive[i].Length <=3)
        {
            
            result[i] = massive[i];
            
        }
    }

    return result;
}

void ShowResult(string[] res)
{
    for(int i = 0; i < res.Length; i++)
        Console.Write($" {res[i]}  {" "}");
}
ShowResult(CheckElement(Massive));
