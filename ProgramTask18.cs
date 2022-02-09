// 18.	Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] arrayX = {false, true};
bool[] arrayY = {false, true};
bool flag = true;

// bool Num1;
// bool Num2;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        bool F1 = !(arrayX[i] || arrayY[j]);
        bool F2 = (!arrayX[i] && !arrayY[j]);
        if (F1 !=F2)
        {
            flag = false;
        }
        System.Console.WriteLine("{0, 8} {1, 8} {2, 8} {3, 8}", arrayX[i], arrayY[j], F1, F2);
        System.Console.WriteLine();
    }
}

if (flag == true)
{
    System.Console.WriteLine("Выражение верно для всех значений X и Y");
}
else System.Console.WriteLine("Выражение неверно для всех значений X и Y");




// if (flag == true)
// }
//     System.Console.WriteLine("Выражение верно для всех значений X и Y");
// }
// else System.Console.WriteLine("Выражение неверно для всех значений X и Y");
