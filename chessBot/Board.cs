using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace chessBot
{
    public class Board
    {
        public static string[][] currentBoard { get; set; }

        public static bool WriteToFile(string filePath)
        {
            try
            {
                //TODO: Check the file path is valid
                StreamWriter sw = new StreamWriter(filePath);
                JsonSerializer js = new JsonSerializer();

                // Chess boards have 64 tiles

                /*
                 * Map out the board in JSON, have each tile with it's own key - DONE
                 * 
                 * Parse the board into a 3d dict | board["h"]["2"] = "Q"
                 * 
                 * 
                 */


                return true;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
