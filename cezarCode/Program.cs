
var CodedLines = File.ReadAllLines("data.txt");

List<char> alphabet = new List<char> {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

List<string> cesarDecode(string[] linesToDecode, int jump)
{
    List<string> decodedData = new List<string>();
    for (int i = 0; i < linesToDecode.Length; i++)
    {
        string tmp = "";
        var lineToDecode = linesToDecode[i].ToUpper();
        for (int j = 0; j < lineToDecode.Length; j++)
        {
            var currentLetter = alphabet.FindIndex(x => x == lineToDecode[j]);
            if (currentLetter != -1)
                if (currentLetter - jump >= 0)
                    tmp += alphabet[currentLetter - jump];
                else
                    tmp += alphabet[(alphabet.Count - 1) + (currentLetter - jump)];
            else
                tmp += lineToDecode[j];
        }
        decodedData.Add(tmp);
    }
    File.WriteAllLines("decodedData.txt", decodedData);
    return decodedData;
}

cesarDecode(CodedLines, 3);








