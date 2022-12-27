using FinProjectBaseDev;

string[] havingArray = {"srtu", "uiy", "oiuy", "oiuo", "uiyrer", "d", "", "ad"};

int lengthLimit = 3;
Console.WriteLine();
string[] resultArray = FindShortStrings(havingArray, lengthLimit);


string[] FindShortStrings (string[] startArray, int lengthLimit){
    StringArr tempStringArr = new StringArr(0);
    for (int i = 0; i < startArray.Length; i++){
        if ((startArray[i]).Length <= lengthLimit){
            tempStringArr.Add(startArray[i]);
        }
    }
    string[] res = tempStringArr.Pack;
    return res;
}

