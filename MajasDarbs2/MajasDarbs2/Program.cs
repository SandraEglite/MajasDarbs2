
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Mājas darbs");

Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();

Console.WriteLine("1.uzdevums - Sasveicināšanās");


Console.WriteLine("Kā Tevi sauc?");

string userName = Console.ReadLine();

string userGreeting = "Sveiks " + userName + "!";
Console.WriteLine(userGreeting);

Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();

Console.WriteLine("2.uzdevums - Vecums");

Console.WriteLine("Cik Tev ir gadu?");

string UserNumberText = Console.ReadLine();

int UserNumber = int.Parse(UserNumberText);

int result = UserNumber + 1;
Console.WriteLine("Nākamgad Tev paliks " + result + ", Tu esi pilngadīgs!");

Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();

Console.WriteLine("3.uzdevums - Matemātikas uzdevums");
Console.WriteLine("Lielakais skaitlis");

Console.WriteLine("Lūdzu ievadi pirmo skaitli");

string UserNumberOne = Console.ReadLine();
int A = int.Parse(UserNumberOne);


Console.WriteLine("Lūdzu ievadi otro skaitli");

string UserNumberTwo = Console.ReadLine();
int B = int.Parse(UserNumberTwo);

int resultLargest = Math.Max(A, B);

Console.WriteLine("Lielākais no Taviem skaitļiem ir " + resultLargest);

Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();

Console.WriteLine("Mazākais skaitlis");
Console.WriteLine("Lūdzu ievadi pirmo skaitli");

string UserNumberC = Console.ReadLine();
int C = int.Parse(UserNumberC);


Console.WriteLine("Lūdzu ievadi otro skaitli");

string UserNumberD = Console.ReadLine();
int D = int.Parse(UserNumberD);

int resultSmallest = Math.Min(C, D);
Console.WriteLine("Mazākais no Taviem skaitļiem ir " + resultSmallest);

Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();

Console.WriteLine("Dalījuma atlikums");

Console.WriteLine("Lūdzu ievadi pirmo skaitli");

string UserNumberE = Console.ReadLine();
int E = int.Parse(UserNumberE);

Console.WriteLine("Lūdzu ievadi otro skaitli");

string UserNumberF = Console.ReadLine();
int F = int.Parse(UserNumberF);

int leftAfter = E % F;
Console.WriteLine("Dalījuma atlikums ir " + leftAfter);


Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();

Console.WriteLine("Pāra vai nepāra skatlis");

Console.WriteLine("Lūdzu ievadi savu skaitli");

string UserNumberG = Console.ReadLine();
int G = int.Parse(UserNumberG);
string Z = "Nepara";
if (G % 2 == 0)
{ Z = "Para"; }


Console.WriteLine("Tavs skaitlis ir " + Z);



Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();

Console.WriteLine("Taisnstūra laukums");

Console.WriteLine("Lūdzu ievadi taisnstūra garākās malas garumu centimetros");

string UserNumberI = Console.ReadLine();
double I = double.Parse(UserNumberI);

Console.WriteLine("Lūdzu ievadi taisnstūra īsākās malas garumu centimetros");
string UserNumberJ = Console.ReadLine();
double J = double.Parse(UserNumberJ);

double Laukums = I * J;

Console.WriteLine("Taisnstūra laukums ir " + Math.Round(Laukums,2));


Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();


Console.WriteLine("Trijstrūra laukums");

Console.WriteLine("Lūdzu ievadi trijstūra vienas katetes garumu centimetros");

string UserNumberK = Console.ReadLine();
int K = int.Parse(UserNumberK);

Console.WriteLine("Lūdzu ievadi trijstūra otras katetes garumu garumu centimetros");
string UserNumberL = Console.ReadLine();
int L = int.Parse(UserNumberL);

double TrijsturaLaukums = (K * L) / 2;
Console.WriteLine("Trijstūra laukums ir " + TrijsturaLaukums);


Console.WriteLine();
Console.WriteLine("........................");
Console.WriteLine();

Console.WriteLine("Interpolācija");

Console.WriteLine("Kā Tevi sauc?");
string Name = Console.ReadLine();

Console.WriteLine("Kāds ir Tavs vecums?");
string AgeText = Console.ReadLine();
int Age = int.Parse(AgeText);


Console.WriteLine($"Sveiks {Name}, Tavs vecums ir {Age}!"); 


