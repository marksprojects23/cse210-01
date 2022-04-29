//Assignment:   01 Ponder & Prove: Developer
//Student:       Mark Cuizon


// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
//int x;
//x = 5;
//Console.WriteLine(x);
int Player = 0;
int gridAffected;
bool stillPlaying = true;
string[] grid = new string[] {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

static string playerMark(int Player)
{
if (Player % 2 == 0)
{
return "x";
} else
{
    return "o";
}
}
static void drawGrid(string[] grid)
{
Console.WriteLine(grid[0] + " | " + grid[1] +  " | " + grid[2]);
Console.WriteLine("- + - + -");
Console.WriteLine(grid[3] + " | " + grid[4] +  " | " + grid[5]);
Console.WriteLine("- + - + -");
Console.WriteLine(grid[6] + " | " + grid[7] +  " | " + grid[8]);
}

static int chooseSquare(int Player)
{
    int gridValue;
if (Player % 2 == 0)
{
Console.WriteLine("x's turn to choose a square (1-9):");
gridValue = Convert.ToInt32(Console.ReadLine());
} else
{
Console.WriteLine("o's turn to choose a square (1-9):");
gridValue = Convert.ToInt32(Console.ReadLine());
}
return gridValue;
}

static bool checkForWin(string[] grid)
{
    if (grid[0] == "x" && grid[1] == "x" && grid[2] == "x"){return false;}
    else if (grid[3] == "x" && grid[4] == "x" && grid[5] == "x"){return false;}
    else if (grid[6] == "x" && grid[7] == "x" && grid[8] == "x"){return false;}
    else if (grid[0] == "x" && grid[3] == "x" && grid[6] == "x"){return false;}
    else if (grid[1] == "x" && grid[4] == "x" && grid[7] == "x"){return false;}
    else if (grid[2] == "x" && grid[5] == "x" && grid[6] == "x"){return false;}
    else if (grid[0] == "x" && grid[4] == "x" && grid[8] == "x"){return false;}
    else if (grid[2] == "x" && grid[4] == "x" && grid[6] == "x"){return false;}
    else if (grid[0] == "o" && grid[1] == "o" && grid[2] == "o"){return false;}
    else if (grid[3] == "o" && grid[4] == "o" && grid[5] == "o"){return false;}
    else if (grid[6] == "o" && grid[7] == "o" && grid[8] == "o"){return false;}
    else if (grid[0] == "o" && grid[3] == "o" && grid[6] == "o"){return false;}
    else if (grid[1] == "o" && grid[4] == "o" && grid[7] == "o"){return false;}
    else if (grid[2] == "o" && grid[5] == "o" && grid[6] == "o"){return false;}
    else if (grid[0] == "o" && grid[4] == "o" && grid[8] == "o"){return false;}
    else if (grid[2] == "o" && grid[4] == "o" && grid[6] == "o"){return false;}
    else {return true;}
}

while (stillPlaying == true)
{
drawGrid(grid);
gridAffected = chooseSquare(Player);
grid[gridAffected - 1] = playerMark(Player);
stillPlaying = checkForWin(grid);
Player++;
// drawGrid(grid);
// gridAffected = chooseSquare(Player);
// grid[gridAffected - 1] = "o";
// stillPlaying = checkForWin(grid);
// Player--;
// drawGrid(grid);
// gridAffected = chooseSquare(Player);
// grid[gridAffected - 1] = "x";
// stillPlaying = checkForWin(grid);
// Player++;
// drawGrid(grid);
// gridAffected = chooseSquare(Player);
// grid[gridAffected - 1] = "o";
// stillPlaying = checkForWin(grid);
// Player--;
// drawGrid(grid);
// gridAffected = chooseSquare(Player);
// grid[gridAffected - 1] = "x";
// stillPlaying = checkForWin(grid);
// Player++;
// drawGrid(grid);
// gridAffected = chooseSquare(Player);
// grid[gridAffected - 1] = "o";
// stillPlaying = checkForWin(grid);
// Player--;
// drawGrid(grid);
// gridAffected = chooseSquare(Player);
// grid[gridAffected - 1] = "x";
// stillPlaying = checkForWin(grid);
// Player++;
// drawGrid(grid);
// gridAffected = chooseSquare(Player);
// grid[gridAffected - 1] = "o";
// stillPlaying = checkForWin(grid);
// Player--;
}
if (Player % 2 == 0)
{
    drawGrid(grid);
    Console.WriteLine("Congratulations to o!");
}else
{
    drawGrid(grid);
    Console.WriteLine("Congratulations to x!");
}