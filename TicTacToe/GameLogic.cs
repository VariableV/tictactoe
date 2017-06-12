/*
 * Author: VariableV
 * Date: 06/11/2017
 */

using System;
using System.Windows.Forms;

namespace TicTacToe
{
    class GameLogic
    {
        private int cpuMode;
        private Form1 form;
        private int[,] gameArray;
        private char piece;
        
        public GameLogic(Form1 form)
        {
            this.form = form;
            gameArray = new int[3,3];
            cpuMode = 0;
            piece = 'X';
        }
        
        public void SetCpuMode(int newMode)
        {
            cpuMode = newMode;
            Array.Clear(gameArray, 0, 9);
            form.ClearBoard();
        }

        public void SetPiece(char newPiece)
        {
            piece = newPiece;
            Array.Clear(gameArray, 0, 9);
            form.ClearBoard();
        }

        public int[,] GetGameArray()
        {
            return gameArray;
        }

        private bool IsFull()
        {
            foreach (int i in gameArray)
                if (i == 0) // open spot
                    return false;
            return true;
        }

        private bool CheckWinner() // return if there is a winner or not, needed for tie system
        {
            if (CheckArray(1))
            {
                Array.Clear(gameArray, 0, 9);
                MessageBox.Show("You win!");
                form.ClearBoard();
                return true;
            }
            else if (CheckArray(2))
            {
                Array.Clear(gameArray, 0, 9);
                MessageBox.Show("CPU wins.");
                form.ClearBoard();
                return true;
            }
            return false;

        }

        public void PlayerInput(String pos)
        {
            int x = Convert.ToInt32(pos.Substring(3, 1));
            int y = Convert.ToInt32(pos.Substring(4, 1));

            gameArray[x, y] = 1;

            form.UpdateButton("pos" + x + "" + y, "" + piece);

            if (!IsFull())
            {
                switch(cpuMode)
                {
                    case 0:
                        CpuTurnEasy();
                        break;
                    case 1:
                        CpuTurnHard(1);
                        break;
                }
                CheckWinner();
            }
            else
            {
                if (!CheckWinner())
                {
                    Array.Clear(gameArray, 0, 9);
                    MessageBox.Show("Draw.");
                    form.ClearBoard();
                }
            }
        }

        /* CPU logic begins here */
        public void CpuTurnEasy()
        {
            Random rand = new Random();
            int x=0,y=0;

            while (gameArray[x,y] != 0)
            {
                x = rand.Next(0, 3);
                y = rand.Next(0, 3);
            }

            gameArray[x, y] = 2;

            form.UpdateButton("pos" +x +"" +y, (piece == 'X') ? "O" : "X");
        }

        private String TwoInARow(int player) // checks if the user has 2 spots in a row filled in at any given time
        {
            for (int r = 0; r < 3; r++)
            {
                if (gameArray[r, 0] == player && gameArray[r, 1] == player && gameArray[r, 2] == 0)
                    return r + " " + 2;
                if (gameArray[r, 1] == player && gameArray[r, 2] == player && gameArray[r, 0] == 0)
                    return r + " " + 0;
                if (gameArray[r, 0] == player && gameArray[r, 2] == player && gameArray[r, 1] == 0)
                    return r + " " + 1;
            }

            for (int c = 0; c < 3; c++)
            {
                if (gameArray[0, c] == player && gameArray[1, c] == player && gameArray[2,c] == 0)
                    return 2 + " " + c;
                if (gameArray[1, c] == player && gameArray[2, c] == player && gameArray[0,c] == 0)
                    return 0 + " " + c;
                if (gameArray[0, c] == player && gameArray[2, c] == player && gameArray[1,c] == 0)
                    return 1 + " " + c;
            }

            // lol disgusting checks
            if (gameArray[0,0] == player && gameArray[1, 1] == player && gameArray[2, 2] == 0)
                return 2 + " " + 2;
            if (gameArray[1, 1] == player && gameArray[2,2] == player && gameArray[0, 0] == 0)
                return 0 + " " + 0;
            if (gameArray[0, 0] == player && gameArray[2, 2] == player && gameArray[1, 1] == 0)
                return 1 + " " + 1;

            if (gameArray[0, 2] == player && gameArray[1, 1] == player && gameArray[2, 0] == 0)
                return 2 + " " + 0;
            if (gameArray[1, 1] == player && gameArray[2, 0] == player && gameArray[0, 2] == 0)
                return 0 + " " + 2;
            if (gameArray[0, 2] == player && gameArray[2, 0] == player && gameArray[1, 1] == 0)
                return 1 + " " + 1;

            return String.Empty;
        }

        public void CpuTurnHard(int player)
        {
            String res = TwoInARow(player);
            if (!res.Equals(String.Empty))
            {
                int x = Convert.ToInt32(res.Substring(0, 1));
                int y = Convert.ToInt32(res.Substring(2, 1));
                gameArray[x, y] = 2;
                form.UpdateButton("pos" + x + "" + y, (piece == 'X') ? "O" : "X");
            }
            else
                CpuTurnEasy(); // place the x/o at a random available place
        }

        /* Checks all possible paths for 3 in a row */
        private bool CheckArray(int player)
        {
            for (int r = 0; r < 3; r++) // can set the max to 3 because the grid size is already known
                if (gameArray[r, 0] == player && gameArray[r, 1] == player && gameArray[r, 2] == player)
                {
                    form.ColorWinner("pos" + r + "" + 0);
                    form.ColorWinner("pos" + r + "" + 1);
                    form.ColorWinner("pos" + r + "" + 2);
                    return true;
                }


            for (int c = 0; c < 3; c++) // can set the max to 3 because the grid size is already known
                if (gameArray[0, c] == player && gameArray[1, c] == player && gameArray[2, c] == player)
                {
                    form.ColorWinner("pos" + 0 + "" + c);
                    form.ColorWinner("pos" + 1 + "" + c);
                    form.ColorWinner("pos" + 2 + "" + c);
                    return true;
                }

            if (gameArray[1, 1] == player)
            {
                if (gameArray[0, 0] == player && gameArray[2, 2] == player)
                {
                    form.ColorWinner("pos" + 0 + "" + 0);
                    form.ColorWinner("pos" + 1 + "" + 1);
                    form.ColorWinner("pos" + 2 + "" + 2);
                    return true;
                }
                if (gameArray[0, 2] == player && gameArray[2, 0] == player)
                {
                    form.ColorWinner("pos" + 0 + "" + 2);
                    form.ColorWinner("pos" + 1 + "" + 1);
                    form.ColorWinner("pos" + 2 + "" + 0);
                    return true;
                }
                    
            }

            return false;
        }
    }
}
