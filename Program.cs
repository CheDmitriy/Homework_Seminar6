/*Console.Write($"Input М(count numbers): ");          // Задача №41
int m = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[m];

void EnterNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Input {i+1} a number: ");
    ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Calculation(int[] ArrayNumbers)
{
  int count = 0;
  for (int i = 0; i < ArrayNumbers.Length; i++)
  {
    if(ArrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

EnterNumbers(m);

Console.WriteLine($"Entered numbers > 0 times: {Calculation(ArrayNumbers)} ");*/


double[,] rate = new double[2, 2];             // Задача №43
double[] point = new double[2];

void InputRate()
{
  for (int i = 0; i < rate.GetLength(0); i++)
  {
    Console.Write($"Enter the data of {i+1}-st equation (y = k * x + b):\n");
    for (int j = 0; j < rate.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Enter the data k: ");
      else Console.Write($"Enter the data b: ");
      rate[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Search(double[,] rate)
{
  point[0] = (rate[1,1] - rate[0,1]) / (rate[0,0] - rate[1,0]);
  point[1] = point[0] * rate[0,0] + rate[0,1];
  return point;
}

void Result(double[,] rate)
{
  if (rate[0,0] == rate[1,0] && rate[0,1] == rate[1,1]) 
  {
    Console.Write($"\nStraight lines match");
  }
  else if (rate[0,0] == rate[1,0] && rate[0,1] != rate[1,1]) 
  {
    Console.Write($"\nStraight lines are parallel");
  }
  else 
  {
    Search(rate);
    Console.Write($"\nPoint of intersection of straight lines: ({point[0]}, {point[1]})");
  }
}

InputRate();
Result(rate);