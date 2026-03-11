# Tic Tac Toe Game

## About
Simple 2-player Tic Tac Toe game in C#.

## How to Play
- Player 1 = X, Player 2 = O  
- Enter 1-9 to place mark
- First with 3 in row wins

Board positions:
```
 1 | 2 | 3 
-----------
 4 | 5 | 6 
-----------
 7 | 8 | 9 
```

## Classes
**Class P** (Player)
- n = name
- s = symbol (X/O)
- c = score

**Class B** (Board)
- b[] = 9 cells
- p() = print board
- m(i,s) = make move
- w() = check winner
- f() = check if full
- r() = reset board

**Class G** (Game)
- b = board object
- p[] = players list
- t = current turn
- s() = setup game
- g() = play game
- sc() = show score
- rep() = play again?

## Files
- Program.cs - main code
- README.txt - this file

## How to Run
1. Open in Visual Studio
2. Press F5
3. Enter names
4. Play!

Done!
