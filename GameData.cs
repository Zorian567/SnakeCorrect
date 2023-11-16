using System;
using System.IO;
using Newtonsoft.Json;

namespace gptSnake {

    class GameData {
        public static string SaveFile = "savefile.txt";

        public static void SerializeGame(Game game) {
           
            string jsonSave = JsonConvert.SerializeObject(game.GameSnake);
            File.WriteAllText(SaveFile, jsonSave);


        }

        public void FileRead() {

            string jsonSave = File.ReadAllText(SaveFile);
            Snake GameSnake = JsonConvert.DeserializeObject<Snake>(jsonSave);

        }
    }


}