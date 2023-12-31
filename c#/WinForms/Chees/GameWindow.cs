﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Chess
{
    public partial class GameWindow : Form
    {
        public static string Player1Name = "Player 1";
        public static string Player2Name = "Player 2";
        public static int TimeControl = -1;

        public static bool ShowBoardSquareNumbers = false;

        public static int WhiteTimeLeft;
        public static int BlackTimeLeft;

        public static EventHandler WhiteEv = new EventHandler(WhiteTimerTick);
        public static EventHandler BlackEv = new EventHandler(BlackTimerTick);

        public static ListView MoveStack;
        public static string lastMove;
        public static List<Move> currentLegalMoves = new List<Move>();

        public GameWindow(bool singlePlayer)
        {
            InitializeComponent();

            // Сбрасывает все переменные к значениям по умолчанию для сброса игры
            GameControl.SetOriginalVariables(singlePlayer);

           
            if (TimeControl > 0)
            {
                WhiteTimeLeft = TimeControl;
                BlackTimeLeft = TimeControl;

                if (GameControl.NoGames == 1)
                {

                    GameControl.WhiteTimer.Tick += WhiteEv;
                    GameControl.BlackTimer.Tick += BlackEv;
                }


                BlackTimeDisplay.Text = TimeSpan.FromSeconds(BlackTimeLeft).ToString(@"mm\:ss");
                WhiteTimeDisplay.Text = TimeSpan.FromSeconds(WhiteTimeLeft).ToString(@"mm\:ss");
            }

            else
            {
                GameControl.WhiteTimer.Tick -= WhiteEv;
                GameControl.BlackTimer.Tick -= BlackEv;

                BlackTimeDisplay.Text = "";
                WhiteTimeDisplay.Text = "";
            }
        }

        public void GameWindow_Load(object sender, EventArgs e)
        {
            Size = new Size(1000, 1000);
            BackColor = Color.LightGray; 

            DrawBoard();

            // Найдите расстояние от краев до начала игры, чтобы рассчитать допустимые ходы
            RuleBook.FindDistanceFromEdges();
        }
        public static void SetLegalMoves()
        {
            currentLegalMoves = RuleBook.GenerateLegalMoves(); // Get friendly moves
            // Backup check for mate as a fall through if it isnt detected in game control
            if (currentLegalMoves.Count == 0 && RuleBook.KingInCheck == true) // No legal moves and king is in check, checkmate
            {
                GameControl.EndGame(GameControl.OpposingSide()); // End game for opposite side it is to move
            }
            if (currentLegalMoves.Count == 0 && RuleBook.KingInCheck == false) // No legal moves and king isnt in check, stalemate
            {
                GameControl.EndGame(-1);
            }
        }
        public static void WhiteTimerTick(object sender, EventArgs e)
        {
            if (WhiteTimeLeft > 0) // If white time has not run out
            {
                WhiteTimeLeft -= 1; // Decrease time left (as it is called every sec this varibale will decrease by one every second meaning the millisecond the timer is on doesnt need to be used and converted)
      //          WhiteTimeDisplay.Text = TimeSpan.FromSeconds(WhiteTimeLeft).ToString(@"mm\:ss"); // update time display
            }
            // If no time left, end game and pass black as the winner
            else
            {
                GameControl.EndGame(8);
            }
        }
        public static void BlackTimerTick(object sender, EventArgs e)
        {
            if (BlackTimeLeft > 0) // If black time has not run out
            {
                BlackTimeLeft -= 1;  // Decrease time left (as it is called every sec this varibale will decrease by one every second meaning the millisecond the timer is on doesnt need to be used and converted)
        //        BlackTimeDisplay.Text = TimeSpan.FromSeconds(BlackTimeLeft).ToString(@"mm\:ss"); // update time display
            }
            // If no time left, end game and pass white as the winner
            else
            {
                GameControl.EndGame(16);
            }
        }

        // 1----
        // Создать массив сетки и размеры плиток
        readonly GameControl GameControl = new GameControl(); 
        const int tileSize = 80;
        int TileNo = 0;

        public static Label WinnerDisplay = new Label();

        // Colours for board squares
        public static Color Brown = ColorTranslator.FromHtml("#b0722c");
        public static Color White = ColorTranslator.FromHtml("#ede4d8");
        // Old colour variable for hovering over squares
        Color oldColor;

        public void DrawBoard()
        {
            WinnerDisplay = new Label();
            WinnerDisplay.Location = new Point(250, 400);
            WinnerDisplay.AutoSize = true;
            WinnerDisplay.ForeColor = Color.Red;
            WinnerDisplay.Font = new Font("Arial", 24);
            WinnerDisplay.Text = "Winner: ";

            Controls.Add(WinnerDisplay);

            WinnerDisplay.Hide();

            P1Name.Text = Player1Name;
            P2Name.Text = Player2Name;

            for (var row = 0; row < 8; row++)
            {
                for (var col = 0; col < 8; col++)
                {

                    var newSquare = new BoardSquare
                    {
                        Size = new Size(tileSize, tileSize),
                        Location = new Point((tileSize * col) + 20, (tileSize * row) + 100),
                        AllowDrop = true,
                        SizeMode = PictureBoxSizeMode.CenterImage,

                        SquareNumber = TileNo,
                    };


                    if (row % 8 == 7)
                    {
                        var boardNotationLabel = new Label {
                            Text = Convert.ToChar(col + 97).ToString(), 
                            AutoSize = true, 
                            Location = new Point((tileSize * col) + 21, (tileSize * row) + 180)
                        };
                        Controls.Add(boardNotationLabel);
                    }


                    if (col % 8 == 0)
                    {
                        var boardNotationLabel = new Label
                        {
                            Text = (8-row).ToString(), 
                            AutoSize = true,
                            Location = new Point((tileSize * col)+5, (tileSize * row)+100)
                        };
                        Controls.Add(boardNotationLabel);
                    }

                    if(ShowBoardSquareNumbers == true)
                    {
                        Label lbl = new Label();
                        lbl.Parent = newSquare;
                        lbl.BackColor = Color.Transparent;
                        lbl.Text = newSquare.SquareNumber.ToString();
                    }


                    Controls.Add(newSquare);
                    GameControl.Board[TileNo] = newSquare;


                    if (col % 2 == 0)
                    {
                        newSquare.BackColor = row % 2 != 0 ? Brown : White;
                    }
                    else
                    {
                        newSquare.BackColor = row % 2 != 0 ? White : Brown;
                    }


                    newSquare.MouseEnter += new EventHandler(MouseEnter);
                    newSquare.MouseLeave += new EventHandler(MouseLeave);
                    newSquare.MouseDown += new MouseEventHandler(MouseDown);
                    newSquare.MouseUp += new MouseEventHandler(MouseUp);

                    TileNo += 1;
                }
            }

            try
            {
                FenStringUtility.LoadBoardFromFenString(FenStringUtility.InputedPostion);
            }
            catch
            {
                FenStringUtility.LoadBoardFromFenString(FenStringUtility.StartingPosition);
            }


            Console.WriteLine("Finished initialising board");

            RuleBook.FindDistanceFromEdges(); 
            currentLegalMoves = RuleBook.GenerateLegalMoves(); 
        }

        public static void resetColours()
        {
            for (int i = 0; i < 64; i++) 
            {
                if ((i / 8) % 2 == 0){GameControl.Board[i].BackColor = i % 2 == 0 ? White : Brown;}
                if ((i / 8) % 2 != 0){GameControl.Board[i].BackColor = i % 2 == 0 ? Brown : White;}
            }
            if(RuleBook.KingInCheck == true)
            {
                GameControl.Board[RuleBook.FriendlyKingSquare].BackColor = Color.Red; 
            }
        }


        Cursor Pointer = Cursor.Current;

        public int copiedPiece = 0;
        public int oldLocation = 0;

        new void MouseEnter(object sender, EventArgs e) 
        {
            BoardSquare currentPictureBox = (BoardSquare)sender; 
            int location = currentPictureBox.SquareNumber; // Получить местоположение

            if (copiedPiece != 0) // Если есть фрагмент, который был захвачен
            {
                Move[] moves = currentLegalMoves.ToArray();//Добавляем в масив

                bool moveMade = false;
                Move AttemptingMove = new Move { Piece = copiedPiece, MoveFrom = oldLocation, MoveTo = location }; //Сохраняем ход

                foreach (Move move in moves) 
                {
                    if (move.MoveFrom == AttemptingMove.MoveFrom && move.MoveTo == AttemptingMove.MoveTo) // Проверка хода
                    {
                        GameControl.Move(move); 
                        moveMade = true;
                    }
                }
                if (moveMade == false)
                {
                    System.IO.Stream stream = Properties.Resources.IllegalMove;
                    // Возвращаем старое местоположение
                    GameControl.AddPiece(copiedPiece, oldLocation);
                }

                // Сбросить скопированную фигуру
                copiedPiece = 0;
            }

            // // Сохраните старый цвет для выделения квадратов
            oldColor = currentPictureBox.BackColor;
            currentPictureBox.BackColor = Color.LightYellow;
        }
        new void MouseLeave(object sender, EventArgs e)
        {
            BoardSquare currentPictureBox = (BoardSquare)sender; 

            currentPictureBox.BackColor = oldColor;
        }
        new void MouseDown(object sender, EventArgs e)
        {
            BoardSquare currentPictureBox = (BoardSquare)sender; 

            int location = currentPictureBox.SquareNumber; 
            oldLocation = location;
            resetColours(); 

            currentPictureBox.BackColor = oldColor;


            if (currentPictureBox.Image != null)
            { 
          
                Bitmap bmp = (Bitmap)currentPictureBox.Image;
                this.Cursor = new Cursor(bmp.GetHicon());

                copiedPiece = GameControl.Board[location].PieceOnSquare; 

                GameControl.RemovePiece(copiedPiece, location);
                PieceLocator.RemoveFromList(location, copiedPiece); 
            }


            foreach(Move move in currentLegalMoves)
            {
                if(move.MoveFrom == location)
                {
                    GameControl.Board[move.MoveTo].BackColor = Color.Crimson;
                }
            }
        }
        new void MouseUp(object sender, EventArgs e) 
        {
            BoardSquare currentPictureBox = (BoardSquare)sender; 

            int location = currentPictureBox.SquareNumber;

        
            if (currentPictureBox.ClientRectangle.Contains(currentPictureBox.PointToClient(Control.MousePosition)) & copiedPiece != 0) 
            {

                GameControl.AddPiece(copiedPiece, location);
                copiedPiece = 0; 

            }


            this.Cursor = Pointer;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            GameControl.EndGame(GameControl.OpposingSide());
        }
    }
}
