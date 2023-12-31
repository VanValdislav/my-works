﻿using System.Collections.Generic;


namespace Chess
{
    public class FenStringUtility
    {
        // Словарь, облегчающий последующую идентификацию фрагментов
        public static Dictionary<char, int> pieceTypeFromSymbol = new Dictionary<char, int>()
        {
            ['k'] = Piece.King,
            ['p'] = Piece.Pawn,
            ['n'] = Piece.Knight,
            ['b'] = Piece.Bishop,
            ['r'] = Piece.Rook,
            ['q'] = Piece.Queen
        };
        // w - белый для перемещения (активный цвет)
        // KQkq - доступность рокировки
        // Проходящий мимо
        // Halfmove clock - количество полуходов с момента последнего захвата пешечного хода
        // Номер полного хода - количество полных ходов в игре (черно-белый фильм), начинающейся после хода черных

        public static string InputedPostion = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        public const string StartingPosition = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1"; 

        public static int GetSideToMoveFirst()
        {
            int colour = StartingPosition.Split(' ')[1] == "b" ? 16 : 8;

            return colour;
        }

       // Загружает доску из заданной строки fen
        public static void LoadBoardFromFenString(string fen)
        {
            string fenSplit = fen.Split(' ')[0];
            int row = 0;
            int col = 0;

            foreach (char chara in fenSplit)
            {
                if (chara == '/')
                {
                    col = 0; 
                    row+=1;
                }
                else
                {
                    if (char.IsDigit(chara) == true) 
                    {
                        col += (int)char.GetNumericValue(chara); 
                    }
                    else
                    {
                        int pieceColour = (char.IsUpper(chara)) ? Piece.White : Piece.Black; // Проверьте, является ли символ верхним или нижним для черного или белого
                        int pieceType = pieceTypeFromSymbol[char.ToLower(chara)]; // // Получить тип фрагмента из символа и словаря
                        int location = (row * 8) + col; // Местоположение
                        GameControl.AddPiece(pieceColour | pieceType, location); // Добавить фрагмент в местоположение
                        col +=1;
                    }
                }
            }
        }

        //Возвращает текущую позицию для устранения неполадок
        public static string GetFenStringFromCurrentBoard(BoardSquare[] Board)
        {
            string fen = "";
            for (int row = 7; row >= 0; row--) 
            {
                int numEmptycols = 0; 
                for (int col = 0; col < 8; col++) 
                {
                    int i = row * 8 + col; 
                    int piece = Board[i].PieceOnSquare; 
                    if (piece != 0) 
                    {
                        if (numEmptycols != 0)
                        {
                            fen += numEmptycols; // Добавляет пустой номер col
                            numEmptycols = 0; 
                        }
                        // Проверьте, какой фрагмент является
                        bool isBlack = Piece.IsColour(piece, Piece.Black);
                        int pieceType = Piece.Type(piece);
                        char pieceChar = ' ';

                        switch (pieceType) 
                        {
                            case Piece.Rook:
                                pieceChar = 'R';
                                break;
                            case Piece.Knight:
                                pieceChar = 'N';
                                break;
                            case Piece.Bishop:
                                pieceChar = 'B';
                                break;
                            case Piece.Queen:
                                pieceChar = 'Q';
                                break;
                            case Piece.King:
                                pieceChar = 'K';
                                break;
                            case Piece.Pawn:
                                pieceChar = 'P';
                                break;
                        }

                        fen += (isBlack) ? pieceChar.ToString().ToLower() : pieceChar.ToString(); 
                    }
                    else
                    {
                        numEmptycols+=1;
                    }

                }
                if (numEmptycols != 0)
                {
                    fen += numEmptycols;
                }
                if (row != 0)
                {
                    fen += '/';
                }
            }
            return fen;
        }
        
    }
}



