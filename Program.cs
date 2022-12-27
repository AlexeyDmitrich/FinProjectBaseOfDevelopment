using FinProjectBaseDev;

string[] havingArray = {"srtu", "uiy", "oiuy", "oiuo", "uiyrer", "d", "", "ad"};
PrintString(havingArray);
int lengthLimit = 3;
Console.WriteLine();
string[] resultArray = FindShortStrings(havingArray, lengthLimit);
PrintString(resultArray);

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

void PrintString (string[] array){
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}