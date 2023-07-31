// See https://aka.ms/new-console-template for more information


// SINGLE DIMENSIONAL ARRAY.

using csharp_concept;

int[] number = new int[] { 1, 2, 3, 4, 5 };

int[] numberB = new int[4];


// MULTIPLE DIMENSIONAL ARRAY.
int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
// Accessing an element of arrays
Console.WriteLine(number[2]);
Console.WriteLine(matrix[1,2]);

//THREE DIMENSIONAL ARRAY.

int[,,] array3d = new int[2,2,4] { { { 1, 2, 4, 4 }, { 4, 32, 1, 5 } }, { { 3, 4, 5, 7}, { 34, 4, 5, 7 } } };

// A rank indicate how deep nested an array was.
Console.WriteLine(array3d.Rank);
Console.WriteLine(matrix.Rank);
Console.WriteLine(numberB.Rank);

// accessing 3d array element :)

Console.WriteLine($" element is: {array3d[1, 1, 1]};");

// MULTIPLE DIMENSIONAL ARRAY :)

int[,,,] array4d = new int[2,2,3,3] { { { { 1, 2,5 }, { 4, 5, 7 }, { 4, 5, 7 } }, { { 11, 2, 12 }, { 44, 5, 11 }, { 4, 500, 7 } } },
{ { { 1, 2,5 }, { 4, 5, 7 }, { 4, 5, 7 } }, { { 11, 2, 12 }, { 44, 5, 11 }, { 4, 501, 7 } } }};
array4d[1, 1, 2, 1] = 45;
Console.WriteLine($"4d element {array4d[1,1,2,1]}");
Console.WriteLine($"4d rank is: {array4d.Rank}");

var total = 1;
for (int i = 0; i < array4d.Rank; i++)
{
    total *= array4d.GetLength(i);
}

// Console.WriteLine(array4d.GetLength(3));

// A jagged array are array whose element are arrays

int[][] jagged = new int[3][]
{
    new int[4]{21, 48, 6, 8},
    new int[4]{3, 43, 6, 8},
    new int[4]{42, 4, 6, 8},
};

Console.WriteLine(jagged[1][1]);

foreach(int x in matrix)
{
    Console.WriteLine("Item {0}:", x);
}

// An implicit array

var numberc = new[] { 1, 2, 3, 4, 5 };
foreach(var i in numberc)
{
    Console.WriteLine(i);
}
var cv = new CustomGraphics();
cv.DrawSquare();

Graphics vcdc = new CustomGraphics();

vcdc.Write();

// Every instance in inherited from object which have a to string method
Console.WriteLine(number.ToString());

