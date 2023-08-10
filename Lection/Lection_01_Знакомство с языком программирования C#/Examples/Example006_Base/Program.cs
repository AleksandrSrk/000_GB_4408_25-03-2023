int a = 1111;
int b = 2;
int c = 16;
int d = 8;
int e = 4;

int max = a;

if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;
System.Console.WriteLine(max);
