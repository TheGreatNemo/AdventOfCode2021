using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    public class DayFour
    {
        public int GetWinningBoardValue(List<string> input)
        {
            (int[][], int) board = GetWinningBoard(input);
            int boardSum = GetBoardSum(board);
            return boardSum * board.Item2;
        }

        public int GetLoosingBardValue(List<string> input)
        {
            (int[][], int) board = GetLoosingBoard(input);
            int boardSum = GetBoardSum(board);
            return boardSum * board.Item2;
        }

        private int GetBoardSum((int[][], int) board)
        {
            int[][] b = board.Item1;
            int sum = 0;
            foreach (int[] row in b)
            {
                foreach (int value in row)
                {
                    if (value != -1)
                    {
                        sum += value;
                    }
                }
            }
            return sum;
        }

        private (int[][], int) GetWinningBoard(List<string> input)
        {
            int[] numbers = ConvertToIntArray(input[0].Split(","));
            List<int[][]> boards = GetBoards(input);

            foreach (int n in numbers)
            {
                List<int[][]> newBoards = new List<int[][]>();
                foreach (int[][] board in boards)
                {
                    int[][] newBoard = CheckNumber(n, board);

                    if (GotBingo(newBoard))
                    {
                        return (newBoard, n);
                    }
                    newBoards.Add(newBoard);
                }
                boards = newBoards;
            }
            return (new int[5][], -1);
        }

        private (int[][], int) GetLoosingBoard(List<string> input)
        {
            int[] numbers = ConvertToIntArray(input[0].Split(","));
            List<int[][]> boards = GetBoards(input);

            foreach (int n in numbers)
            {
                List<int[][]> newBoards = new List<int[][]>();
                foreach (int[][] board in boards)
                {
                    int[][] newBoard = CheckNumber(n, board);

                    if (GotBingo(newBoard))
                    {
                        if (boards.Count <= 1)
                        {
                            return (newBoard, n);
                        }
                        continue;
                    }
                    newBoards.Add(newBoard);
                }
                boards = newBoards;
            }
            return (new int[5][], -1);
        }

        private bool GotBingo(int[][] board)
        {
            for (int x = 0; x < board.Length; x++)
            {
                if (CheckRow(board[x]) || CheckColumn(board, x))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckColumn(int[][] board, int x)
        {
            foreach (int[] column in board)
            {
                if (column[x] != -1)
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckRow(int[] row)
        {
            foreach (int i in row)
            {
                if (i != -1)
                {
                    return false;
                }
            }
            return true;
        }

        private int[][] CheckNumber(int n, int[][] board)
        {
            for (int x = 0; x < board.Length; x++)
            {
                for (int y = 0; y < board[x].Length; y++)
                {
                    if (board[x][y] == n)
                    {
                        board[x][y] = -1;
                    }
                }
            }
            return board;
        }

        private List<int[][]> GetBoards(List<string> input)
        {
            List<int[][]> boards = new List<int[][]>();
            for (int i = 2; i < input.Count;)
            {
                int[][] board = new int[5][];
                for (int x = 0; x < 5; x++)
                {
                    if (input[i + x].Split(" ", StringSplitOptions.RemoveEmptyEntries).Length == 5)
                    {
                        board[x] = ConvertToIntArray(input[i + x].Split(" ", StringSplitOptions.RemoveEmptyEntries));
                    }
                }
                boards.Add(board);
                i += 6;
            }
            return boards;
        }

        private int[] ConvertToIntArray(string[] strings)
        {
            int[] numbers = new int[strings.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(strings[i]);
            }
            return numbers;
        }
    }
}