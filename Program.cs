// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

double getDistancefromCoordinate3D(int userAX, int userAY, int userAZ, int userBX, int userBY, int userBZ)
{
    double result = Math.Sqrt(Math.Pow((userAX-userBX), 2)+Math.Pow((userAY-userBY), 2)+Math.Pow((userAZ-userBZ), 2));
    return result;
}

int userAX = getUserValue("Введите X");
int userAY = getUserValue("Введите Y");
int userAZ = getUserValue("Введите Z");

int userBX = getUserValue("Введите X");
int userBY = getUserValue("Введите Y");
int userBZ = getUserValue("Введите Z");

double DistancefromCoordinate3D = Math.Round(getDistancefromCoordinate3D(userAX, userAY, userAZ, userBX, userBY, userBZ),2);
Console.WriteLine($"Расстояние между точками равно {DistancefromCoordinate3D}");