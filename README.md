# shaper
Shaper, is a game, which is created "X0".So we can say that "0X Game"
Project:  Shaper

The aim of the project is to develop a one-player shape forming game. 

Game Playing Rules

1. The game is played on two 3*3 boards: Computer's board and player's board.

2. At the beginning, computer shapes its board placing random X marks. Each square is filled by X or left 

empty.

3. The objective of the game is to create the same board with the computer in minimum number of rounds.

4. In each round, a 1*2 small random piece is generated in order to be placed by the player on the player's 

board.

Generated piece Possibility 

90 % 

5 %

5 % 

Generated piece can be horizontal or vertical.    

5. Player can rotate this piece as many times as he likes, then place it wherever he wants. The piece should 

not be placed out of the board. Otherwise, an error occurs. Each error, rotation and placement takes one 

round. After the placement, a new round starts.

    

    Game playing commands are as follows:

    Placement commands:

          YX: Place the small piece starting from row Y and column X. 

                (Y and X values can be 1, 2 or 3) 

    Rotation commands:

          41: Rotate the small piece 90 degrees clockwise. 

          42: Rotate the small piece 90 degrees anticlockwise. 

6. When the small piece is being placed, XOR operation is applied with the existing player's board. 

           (X:1,  Empty:0)

A B A  XOR  B 

0 0 0 

0 1 1 

1 0 1 

1 1 0 

7. When the same board is formed by the player the game is over. The score is calculated as follows:

          Score = 200 - 10 * (the number of rounds)

8. Otherwise, the next round begins and the game continues.
