using FinProjectBaseDev;

string[] havingArray = {"srtu", "uiy", "oiuy", "oiuo", "uiyrer", "d", "", "ad"};
PrintString(havingArray);
int lengthLimit = 3;
Console.WriteLine();
string[] resultArray = FindShortStrings(havingArray, lengthLimit);
PrintString(resultArray);

/// <summary>
/// метод собирает из массива строки 3 и менее символов длиной и собирает в новый массив
/// </summary>
/// <param name="startArray">массив строк</param>
/// <param name="lengthLimit">ограничения длины строк для сборки нового массива</param>
/// <returns>Метод вернёт массив из строк с ограниченной длинной</returns>

string[] FindShortStrings (string[] startArray, int lengthLimit){
    StringArr tempStringArr = new StringArr();
    for (int i = 0; i < startArray.Length; i++){
        if ((startArray[i]).Length <= lengthLimit){
            tempStringArr.Add(startArray[i]);
        }
    }
    string[] res = tempStringArr.PackInNewArr();
    
    return res;
}

/// <summary>
/// метод для вывода элементов массива в консоль
/// </summary>
/// <param name="array">массив строк</param>
void PrintString (string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}