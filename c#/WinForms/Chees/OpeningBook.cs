﻿using System;
using System.Collections.Generic;

namespace Chess
{//первые 4 хода
    class OpeningBook
    {
        public static string[] MoveList = System.IO.File.ReadAllLines("Openings.txt");
        public static List<string> LinesAvailable = new List<string>();
        public static string MovesPlayed = "";

        public static List<Move> AvailableMoves = new List<Move>();

        public static Move GetMove(List<Move> availableMoves)
        {
            AvailableMoves = availableMoves;

            Move moveToPlay = new Move { Piece = 0, MoveFrom = -1, MoveTo = -1 };

            foreach(string line in MoveList)
            {
              
                if (line.StartsWith(MovesPlayed))
                {
                    LinesAvailable.Add(line);
                }
            }

            Random rand = new Random();
            try
            {
               
                int randomLineNumber = rand.Next(0, LinesAvailable.Count - 1);
                string lineToPlay = LinesAvailable[randomLineNumber];

                Console.WriteLine($"Line found to play {lineToPlay}");

             
                string moveAsDescNote = lineToPlay.Replace(MovesPlayed, "").Split(' ')[0];
                moveToPlay = ChangeDesriptiveNotationToMove(moveAsDescNote);
            }
            catch
            {
                return moveToPlay;
            }

            return moveToPlay;
        }

        public static Move ChangeDesriptiveNotationToMove(string descNote)
        {
            Move move = new Move { Piece = 0, MoveFrom = -1, MoveTo = -1 };

            char[] descNoteAsCharArray = descNote.ToCharArray(); 
            int piece = 0;

            // Если фигура не указана, например, "e4", фигура является пешкой
            if (descNoteAsCharArray[0] == Convert.ToInt32(descNoteAsCharArray[descNoteAsCharArray.Length - 2]))
            {
                piece = GameControl.computerSide | Piece.Pawn;
            }
            else
            {
                char pieceChar = Char.ToLower(descNoteAsCharArray[0]);

                switch (pieceChar) // return piece depending on letter
                {
                    case 'n':
                        piece = GameControl.computerSide | Piece.Knight;
                        break;
                    case 'b':
                        piece = GameControl.computerSide | Piece.Bishop;
                        break;
                    case 'r':
                        piece = GameControl.computerSide | Piece.Rook;
                        break;
                    case 'q':
                        piece = GameControl.computerSide | Piece.Queen;
                        break;
                    case 'k':
                        piece = GameControl.computerSide | Piece.King;
                        break;
                }
            }

            int row = int.Parse(descNoteAsCharArray[descNoteAsCharArray.Length - 1].ToString()) - 1;
      
            int col = Convert.ToInt32(descNoteAsCharArray[descNoteAsCharArray.Length - 2]) - 97;

            int location = (56 - (8 * row)) + col;
            // Установить ход
            // // Проверьте, есть ли move в списке доступных ходов
            foreach (Move testMove in AvailableMoves)
            {
                if (testMove.Piece == piece && testMove.MoveTo == location)
                {
                    move = testMove;
                }
            }

            Console.WriteLine($"piece {Piece.PieceToFullName(move.Piece)} moves from {move.MoveFrom} to {move.MoveTo}");

            return move;
        }
    }
}
