int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
int num5 = 0;
// ... etc.

// declare array (is arrays sth like lists in python? Nope, sth like tuples)
int[] myIntArray = new int[5]; // it can now hold 5 ints

//asign values
myIntArray[0] = 5;
myIntArray[1] = 7;
myIntArray[2] = 11;
myIntArray[3] = 13;
myIntArray[4] = 17;

//myIntArray[5] = 16; - this will not work, outside of the array range

// indexes: [0][1][2][3][4]
// content: [5][12][0][0][0]

Console.WriteLine(myIntArray[3]);

// how to do it in one line:
//declaring array and setting the array element values

int[] myIntArray2 = [1,2,3,4,5];

string[] weekdays = ["monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"];

// 2D arrays
int[,] Array2DDeclaration = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

//3D array - it is a cube
int[,,] Array3DDeclaration = new int[3, 3, 3];

int[,] array2DInitialized = { { 1, 2 }, { 3, 4 }, };
// [1] [2]
// [3] [4]

Console.WriteLine(array2DInitialized[0,0]);
