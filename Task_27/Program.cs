Console.Write("Enter = ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 10;
int c = 1;
int i = 1;
int sum = 0;
while ((a/b) != 0){
    b = b * 10;
    c++;
}
while (i <= c){
sum = sum + (a % 10);
a = a / 10;
i++;
}
Console.WriteLine("Result = " + sum);