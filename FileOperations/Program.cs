var lines = File.ReadAllLines("data.txt");

StreamReader reader = new StreamReader("data.txt");

while (reader.ReadLine() != null)
{

}

reader.Close();

string tmp = "";
for (int i = 0; i < lines.Length; i++)
{
    var line = lines[i].Split(';');
    if (int.TryParse(line[3], out int parsed) && parsed % 2 == 0)
    {
        tmp += $"{lines[i]}\n";
    }
}

File.WriteAllText("newData.txt", tmp);