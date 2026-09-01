
class Program
{   
static void Main(string[] args)
{
    string name = "";
    int age = 0;
    double niveau = 0.0;
    double gold = 0.0;
    bool isNew = false;

    Program program = new Program();
    string msg = program.fichePerso(ref name, ref age, ref niveau, ref gold, ref isNew);
    program.Communicate(msg);
}

string fichePerso(ref string name, ref int age, ref double niveau, ref double gold, ref bool isNew)
{
    name = "Pascal";
    age = 30;
    niveau = 5.5;
    gold = 100.0;
    isNew = true;
    string msg = $"Nom: {name}, Âge: {age}, Niveau: {niveau}, Or: {gold}, Nouveau: {isNew}";
    return msg;

}

void Communicate(string message)
{
    Console.WriteLine(message);
}



}