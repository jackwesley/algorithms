using Algorithms.ArraysStudy;
using System;
using System.Collections.Generic;


namespace Algorithms
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Arrays.MaxSubArray();

            string[,] array2D = new string[,] {
                                    { "A", "B", "C", "E"},
                                    { "S", "F", "C", "S"},
                                    { "A", "D", "E", "E"} };


            //WordSearch.Board = array2D;

            //var response = WordSearch.Search(new string[] { "A", "B", "C", "C", "E", "D" });

            //Console.WriteLine("Response: [ " + string.Join(",", response) + " ]");

        }

        public static class WordSearch
        {
            public static string[,] Board { get; set; }
            public static List<int[]> VisitedPaths { get; set; } = new List<int[]>();

            public static bool Search(string[] wordToFind)
            {

                var xLenght = Board.GetLength(0);//coluna
                var yLenght = Board.GetLength(1);//linha

                for (int x = 0; x < Board.GetLength(0); x++)
                {
                    for (int y = 0; y < Board.GetLength(1); y++)
                    {
                        if (Board[x, y] == wordToFind[0])
                        {
                            int[] currentMove = new int[] { x, y };
                            if (DeetphFirstSearch(currentMove, wordToFind, 0))
                                return true;
                        }
                    }
                }
                return false;
            }

            private static bool DeetphFirstSearch(int[] currentMove, string[] wordToFind, int wordIndex)
            {
                if (wordIndex + 1 >= wordToFind.Length)
                    return true;

                int x = currentMove[0];
                int y = currentMove[1];

                List<int[]> possibleMoves = new List<int[]>() { new int []{x+1, y },
                new int []{x-1, y },
                new int []{x, y +1 },
                new int []{x, y -1 }
                };

                var boardXSize = Board.GetLength(0);//coluna
                var boardYSize = Board.GetLength(1);//linha


                foreach (int[] move in possibleMoves)
                {
                    if (move[0] >= 0 && move[0] < boardXSize
                       && move[1] >= 0 && move[1] < boardYSize)
                    {
                        if (Board[move[0], move[1]] == wordToFind[wordIndex + 1])
                        {
                            if (!VisitedPaths.Contains(new int[] { move[0], move[1] }))
                            {
                                int[] nextMove = new int[] { move[0], move[1] };
                                VisitedPaths.Add(nextMove);
                                if(DeetphFirstSearch(nextMove, wordToFind, wordIndex + 1))
                                {
                                    return true;
                                }

                            }
                        }
                    }
                }

                return false;
            }



            public static void AddPath(List<int> visitedPaths, int pathVisited)
            {
                visitedPaths.Add(pathVisited);
            }
        }

    }


}
