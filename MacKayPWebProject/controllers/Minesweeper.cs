using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MacKayPWebProject.Models;

namespace MacKayPWebProject.controllers
{
    public class Minesweeper : ApiController
    {
        
        public IEnumerable<IEnumerable<Cell>> GenerateBoard(int width, int height, int numBombs)
        {
            Random rand = new Random();
            int rand1 = 0;
            int rand2 = 0;
            int numSurroundingBombs = 0;

            var board = new Cell[width, height];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    board[i, j] = new Cell();
                    board[i, j].Hidden = true;
                }
            }
            //places the bombs, selects a random position then puts on there, if there is alredy one it rerolls for another space until a spot is selected without a bomb
            for (int i = 0; i < numBombs; i++)
            {
                rand1 = rand.Next(width);
                rand2 = rand.Next(height);
                while (board[rand1, rand2].Value == "*")
                {
                    rand1 = rand.Next(width);
                    rand2 = rand.Next(height);
                }
                board[rand1, rand2].Value = "*";
            }


            //logic for checking what each different slot should equal (num bombs around any given blank slot)
            for (int i = 0; i < height; i++)
            {
                for (int h = 0; h < width; h++)
                {
                    if (board[h, i].Value != "*")
                    {
                        try
                        {
                            if (board[h + 1, i].Value == "*")
                            {
                                numSurroundingBombs++;
                            }
                        }
                        catch { }

                        try
                        {
                            if (board[h + 1, i + 1].Value == "*")
                            {
                                numSurroundingBombs++;
                            }
                        }
                        catch { }

                        try
                        {
                            if (board[h, i + 1].Value == "*")
                            {
                                numSurroundingBombs++;
                            }
                        }
                        catch { }

                        try
                        {
                            if (board[h - 1, i + 1].Value == "*")
                            {
                                numSurroundingBombs++;
                            }
                        }
                        catch { }

                        try
                        {
                            if (board[h - 1, i].Value == "*")
                            {
                                numSurroundingBombs++;
                            }
                        }
                        catch { }

                        try
                        {
                            if (board[h - 1, i - 1].Value == "*")
                            {
                                numSurroundingBombs++;
                            }
                        }
                        catch { }

                        try
                        {
                            if (board[h, i - 1].Value == "*")
                            {
                                numSurroundingBombs++;
                            }
                        }
                        catch { }

                        try
                        {
                            if (board[h + 1, i - 1].Value == "*")
                            {
                                numSurroundingBombs++;
                            }
                        }
                        catch { }

                        board[h, i].Value = Convert.ToString(numSurroundingBombs);
                        numSurroundingBombs = 0;
                    }
                }
            }
            //var lboard = board.Cast<Cell>().ToList();
            var dboard = new List<List<Cell>>();
            for (int i = 0; i < height; i++)
            {
                dboard.Add(new List<Cell>());
                for (int j = 0; j < width; j++)
                {
                    dboard[i].Add(board[i, j]);
                }
            }
            return dboard;
        }
        [HttpGet]
        [Route ("api/test")]
        public string test()
        {
            return "works?";
        }
    }
}
