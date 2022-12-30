Console.Clear();
/*Напишите программу, которая принимает на вход цифру, обозначающую 
день недели, и проверяет, является ли этот день выходным.
void weekend(int number)
{
    Console.Write("Введите число от 1 до 7:");
    number = int.Parse(Console.ReadLine() ?? "");
    if (number < 7) Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}
weekend(7);*/
/*1.Составить программу вывода на экран в одну строку 
четырех любых чисел с тремя пробелами между ними.
Console.Write("4    78    21    25");*/
/*2.Составить программу вывода на экран «столбиком» 
пяти любых чисел, введенных пользователем с клавиатуры.
Console.WriteLine("Введите число;");
string a = Console.ReadLine() ?? "";
Console.WriteLine("Введите число;");
string b = Console.ReadLine() ?? "";
Console.WriteLine("Введите число;");
string c = Console.ReadLine() ?? "";
Console.WriteLine("Введите число;");
string d = Console.ReadLine() ?? "";
Console.WriteLine("Введите число;");
string e = Console.ReadLine() ?? "";
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);*/
/*3.Вывести на экран число «ПИ» с точностью до сотых.
double pi = 22 / 3;
Console.Write(pi);*/
/*4.Составить программу вывода на экран числа, вводимого с клавиатуры.
 Выводимому числу должно предшествовать сообщение «Вы ввели число».
Console.Write("Введите число: ");
string num = Console.ReadLine() ?? "";
Console.Write($"Вы ввели число: {num}");*/
/*5.Вывести на экран число e (основание натурального логарифма) 
с точностью до десятых.
Console.WriteLine(Math.E);*/
/*6.Даны два действительных числа x и у. Вычислить их сумму, 
разность, произведение и частное.
int x = 5;
int y = 4;
Console.WriteLine($"x + y = {x + y}");
Console.WriteLine($"x - y = {x - y}");
Console.WriteLine($"x * y = {x * y}");
Console.WriteLine($"x / y = {x / y}");*/
/*??? 7.Ввести любой символ и определить его порядковый номер, 
а также указать предыдущий и последующий символы.*/
/*8. Составить программу вывода на экран числа, вводимого с клавиатуры. 
После выводимого числа должно следовать сообщение « – вот какое 
число Вы ввели».
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine($"{num}– вот какое число Вы ввели");*/
/*9. Составить программу обмена значениями двух переменных величин.
int a = 2;
int b = 5;
a = b;
b = a;*/
/*10. Составить программу обмена значениями трех переменных величин 
а, b, c по следующей схеме: b присвоить значение а, с присвоить 
значение b, а присвоить значение с.
Console.WriteLine("Введите значение а: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите значение b: ");
int b = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите значение c: ");
int c = int.Parse(Console.ReadLine() ?? "");
int t = b;
b = a;
a = c;
c = t;

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");
Console.WriteLine($"c = {c}"); */
/*11. Составить программу обмена значениями трех переменных величин 
а, b, c по следующей схеме: b присвоить значение c, а присвоить 
значение b, с присвоить значение а.
Console.Write("Введите переменную а:");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите переменную b:");
int b = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите переменную c:");
int c = int.Parse(Console.ReadLine() ?? "");
int x = a;
a = b;
b = c;
c = x;
Console.WriteLine($"a = {a}, b = {b}, с = {c}");*/
/*12. Известно значение температуры по шкале Цельсия. Найти 
соответствующее значение температуры по шкале Кельвина 
(Для пересчета по шкале Кельвина: абсолютное значение нуля 
соответствует 273,15 градуса по шкале Цельсия).
Console.Write("Введите температуру в градусах цельсия: ");
double t = int.Parse(Console.ReadLine() ?? "");
t = t + 273.15;
Console.Write($"Температура = {t} K");*/
/*13. Найти произведение цифр заданного четырехзначного числа.
Console.Write("Введите четырехзначное число:");
int num = int.Parse(Console.ReadLine() ?? "");
int a = num / 1000;
int b = num / 100;
b = b % 10;
int c = num / 10;
c = c % 10;
int d = num % 10;
int ProductOfNumbers = a * b * c * d;
Console.Write($"Произведение цифр числа {num} равно {ProductOfNumbers}");*/
/*14. Даны два целых числа. Найти: а) их среднее арифметическое; 
б) их среднее геометрическое.
Console.Write("Введите первое целое число:");
double a = double.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе целое число:");
double b = double.Parse(Console.ReadLine() ?? "");
double arithmeticMean = (a + b) / 2;
double geometricMean = Math.Sqrt(a * b);
Console.WriteLine($"Среднее арифметическое: {arithmeticMean}");
Console.Write($"Среднее геометрическое:{geometricMean}");*/
/*15. Вычислить периметр и площадь прямоугольного треугольника по 
заданным длинам двух катетов а и b.
Console.Write("Введите катет AB:");
double ab = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите катет AC:");
double ac = int.Parse(Console.ReadLine() ?? "");
double bc = Math.Sqrt((Math.Pow(ab, 2) + (Math.Pow(ac, 2))));
double S = (ab + ac) / 2;
double P = ab + ac + bc;
Console.WriteLine($"Площадь треугольника: {S}");
Console.WriteLine($"Периметр треугольника: {P}");*/
/*16. Вычислить расстояние между двумя точками с данными 
координатами (х1, у1) и (х2, у2).
Console.Write("Введите первую координату точки A:");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вторую координату точки A:");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите первую координату точки B:");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вторую координату точки B:");
int y2 = int.Parse(Console.ReadLine() ?? "");
double AB = Math.Sqrt(Math.Pow((x1 - y1), 2) + Math.Pow((x2 - y2), 2));
Console.Write($"Расстояние мужду точками равняется: {AB} ");*/
/*17. Дан радиус окружности. Найти длину окружности и площадь круга
Console.Write("Введите радиус: ");
int R = int.Parse(Console.ReadLine() ?? "");
double P = 2 * Math.PI * R;
double S = Math.PI * Math.Pow(R, 2);
Console.WriteLine($"Периметр окружнсти: {P} ");
Console.Write($"Площадь окружности: {S} ");*/
/*18. Заданы координаты трех вершин треугольника 
(х1, y1), (х2, у2), (х3, у3). Найти его периметр и площадь.
Console.Write("Введите первую координату точки A:");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вторую координату точки A:");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите первую координату точки B:");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вторую координату точки B:");
int y2 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите первую координату точки C:");
int x3 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите вторую координату точки C:");
int y3 = int.Parse(Console.ReadLine() ?? "");
double AB = Math.Sqrt(Math.Pow((x1 - y1), 2) + Math.Pow((x2 - y2), 2));
double AC = Math.Sqrt(Math.Pow((x1 - y1), 2) + Math.Pow((x3 - y3), 2));
double BC = Math.Sqrt(Math.Pow((x2 - y2), 2) + Math.Pow((x3 - y3), 2));
double P = AB + AC + BC;
double PP = P / 2;
double S = Math.Sqrt(PP * (PP - AB) * (PP - AC) * (PP - BC));
Console.WriteLine($"Периметр треугольника равен: {P} ");
Console.Write($"Площадь треугольника равна: {S}");*/
/*19. Дана сторона равностороннего треугольника. Найти площадь 
этого треугольника, его высоты, радиусы вписанной и описанной 
окружностей.
Console.Write("Введите длинну стороны равнобедренного треугольника:");
int AB = int.Parse(Console.ReadLine() ?? "");
double S = (Math.Sqrt(3) / 4) * Math.Pow(AB, 2);
double h = (Math.Sqrt(3) / 2) * AB;
double RO = AB / Math.Sqrt(3);
double RV = AB / (2 * Math.Sqrt(3));
Console.Write($" Площадь = {S}\n Высота = {h}\n Радиус описаной окружности = {RO}\n Радиус впсаной окружности = {RV}");*/
/*20. Найти площадь треугольника, две стороны которого 
равны а и b, а угол между этими сторонами равен g.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите сторону b: ");
int b = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите угол: ");
int g = int.Parse(Console.ReadLine() ?? "");
double S = 0.5 * a * b * Math.Sin(g * Math.PI / 180);
Console.Write($"Площадь треугольника = {S}");*/
/*21. Вычислить периметр и площадь прямоугольника по 
заданным пользователем длинам сторон.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите сторону b: ");
int b = int.Parse(Console.ReadLine() ?? "");
double P = (a + b) * 2;
double S = a * b;
Console.WriteLine($"Периметр = {P} \nПлощадь = {S}");*/
/*22. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^15 за пять операций.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
double a1 = a * a;
double a2 = a1 * a1;
double a3 = a2 * a;
double a4 = a3 * a3;
double a5 = a4 * a3;
Console.Write($"{a1} {a2} {a3} {a4} {a5}");*/
/*23. Дано а. Не используя никаких функций и никаких операций, 
кроме умножения, получить а^8 за три операции; а^10 и а^16 за четыре операции.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
double a1 = a * a;
double a2 = a1 * a1;
double a3 = a2 * a2;
double a4 = a3 * a1;
double a32 = a3 * a3;
Console.Write($"{a1} {a2} {a3} {a4} {a32}");*/
/*24. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^4 и а^20 за пять операций.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
int a2 = a * a;
int a4 = a2 * a2;
int a8 = a4 * a4;
int a16 = a8 * a8;
int a20 = a16 * a4;
Console.Write(a20);*/
/*26. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^3 и а^10 за четыре операции.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
int a2 = a * a;
int a3 = a2 * a;
int a5 = a3 * a2;
int a10 = a5 * a5;
Console.Write($"{a3} {a10}");*/
/*27. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^4, а^12 и а^28 за шесть операций.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
int a2 = a * a;
int a4 = a2 * a2;
int a8 = a4 * a4;
int a12 = a8 * a4;
int a24 = a12 * a12;
int a28 = a24 * a4;
Console.Write($"{a4} {a12} {a28}");*/
/*28. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^2, а^5 и а^17 за шесть операций.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
int a2 = a * a;
int a4 = a2 * a2;
int a5 = a4 * a;
int a10 = a5 * a5;
int a15 = a10 * a5;
int a17 = a15 * a2;
Console.Write($"{a2} {a5} {a17}");*/
/*29. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^5 и а^13 за пять операций.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
int a2 = a * a;
int a3 = a2 * a;
int a5 = a3 * a2;
int a10 = a5 * a5;
int a13 = a10 * a3;
Console.Write($"{a5} {a13}");*/
/*30. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^64 за шесть операций.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
int a2 = a * a;
int a4 = a2 * a2;
int a8 = a4 * a4;
int a16 = a8 * a8;
int a32 = a16 * a16;
int a64 = a32 * a32;
Console.Write($"{a64}");*/
/*31. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^21 за шесть операций.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
int a2 = a * a;
int a3 = a2 * a;
int a5 = a3 * a2;
int a10 = a5 * a5;
int a20 = a10 * a10;
int a21 = a20 * a;
Console.Write($"{a21}");*/
/*32. Дано вещественное число а. Пользуясь только операцией умножения, 
получить: а^28 за шесть операций.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
int a2 = a * a;
int a4 = a2 * a2;
int a8 = a4 * a4;
int a10 = a8 * a2;
int a20 = a10 * a10;
int a28 = a20 * a8;
Console.Write($"{a28}");*/
/*33. Составить программу вычисления значения функции 
x=12a^2+7a-16 при любом значении а.
Console.Write("Введите сторону a: ");
int a = int.Parse(Console.ReadLine() ?? "");
double x = 12 * Math.Pow(a, 2) + 7 * a - 16;
Console.Write($"{x}");*/
/*34. Составить программу вычисления значения функции 
y=7x^2+3x-6 при любом значении x.
Console.Write("Введите сторону a: ");
int x = int.Parse(Console.ReadLine() ?? "");
double y = 7 * Math.Pow(x, 2) + 3 * x - 6;
Console.Write($"{y}");*/
/*35. Найти сумму членов арифметической прогрессии, 
если известны ее первый член, знаменатель и число членов прогрессии.
Console.Write("Введите первый член: ");
int n1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите знаменатель: ");
int z = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число членов прогрессии: ");
int nn = int.Parse(Console.ReadLine() ?? "");
double sum = ((2 * n1 + z * (nn - 1)) / 2) * nn;
Console.Write($"{sum}"); */
/*36. Возраст Тани – X лет, а возраст Мити – Y лет. Найти их средний 
возраст, а также определить, на сколько лет отличается возраст 
каждого ребенка от среднего значения.
Console.Write("Введите возраст Тании: ");
int X = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите возраст Миши: ");
int Y = int.Parse(Console.ReadLine() ?? "");
float XY = (X + Y) / 2;
float X1 = Math.Abs((X - XY) * 1);
float Y1 = Math.Abs((Y - XY) * 1);
Console.Write($"Возраст Тании отличается на:{X1}\nВозраст Миши отличается на:{Y1} ");*/
/*37. Известны количество жителей в государстве и площадь его территории. 
Определить плотность населения в этом государстве.
Console.Write("Введите количество жителей: ");
int X = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите площадь государства: ");
int S = int.Parse(Console.ReadLine() ?? "");
int P = X / S;
Console.Write($"Плотность населения равна:{P} чел./км^2");*/