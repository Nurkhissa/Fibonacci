int n = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
for (int i = 0; i < n; i++)
 {
    
    int temp = a;
    a = b;
    b = temp + b;
    if(a<n)
        System.Console.WriteLine(a);
    else break;
    
}

