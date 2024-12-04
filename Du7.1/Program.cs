using System.Text;
Console.OutputEncoding = Encoding.UTF8;

{
    char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    char player = 'X';

    {

        bool gamerun = true;
        while (gamerun)
        {
            Console.Clear();


            drawboard();
            void drawboard()
            {
                Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
                Console.WriteLine("---|---|---");
                Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
                Console.WriteLine("---|---|---");
                Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
            }



            int move;
            Console.WriteLine($"Гравець {player}, введіть номер клітинки (1-9): ");
            while (!int.TryParse(Console.ReadLine(), out move) || !validmove(move))
            {
                Console.WriteLine("Некоректний хід. Спробуйте ще раз:");
            }

            bool validmove(int move)
            {
                return move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O';
            }



            makemove(move);
            void makemove(int move)
            {
                board[move - 1] = player;
            }


            if (checkwin())
            {
                Console.Clear();
                drawboard();
                Console.WriteLine($"Гравець {player} виграв!");
                gamerun = false;
            }
            else if (checkdraw())
            {
                Console.Clear();
                drawboard();
                Console.WriteLine("Нічия!");
                gamerun = false;
            }
            else
            {
                SwitchPlayer();
                void SwitchPlayer()
                {
                    player = (player == 'X') ? 'O' : 'X';
                }
            }
        }
    }

    bool checkwin()
    {
        int[,] winif = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
            { 0, 4, 8 }, { 2, 4, 6 }
        };

        for (int i = 0; i < winif.GetLength(0); i++)
        {
            if (board[winif[i, 0]] == player &&
                board[winif[i, 1]] == player &&
                board[winif[i, 2]] == player)
            {
                return true;
            }
        }
        return false;
    }

    bool checkdraw()
    {
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O')
            {
                return false;
            }
        }
        return true;
    }
}
