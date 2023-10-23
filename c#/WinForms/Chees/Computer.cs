using System;
using System.Linq;
using System.Collections.Generic;

namespace Chess
{
    class Computer
    {
        public Computer()
        {
        }
        public static int Depth = 3;  // сложность бота
                                    
        public static bool MovePutKingInCheck = false;

        // Вычисляет заданную позицию на доске и возвращает оценку в виде целого числа
        // Учитывает оставшиеся фрагменты и их значения
        // Расстояние между королями - зависит от веса эндшпиля
        // Расстояние, на котором король находится от края доски - снова зависит от веса эндшпиля

        public static int EvaluatePos()
        {
            int Evaluation = 0; // Отслеживает текущую оценку
            int EndGameWeight = GameControl.GetEndGameWeight();

           // Ходы, при которых король поставлен под шах, часто хороши
            if (MovePutKingInCheck == true)
            {
                Evaluation += 150 * GameControl.GetEndGameWeight() > 4 ? 3 : 1; 
                // Если вес эндшпиля больше 4, удваивайте, в противном случае оставьте как есть
            }

            // Получите локации, которые можно использовать для королей
            int OpposingKingSquare = PieceLocator.GetLocationsOf(GameControl.OpposingSide() | Piece.King)[0];
            int FriendlyKingSquare = PieceLocator.GetLocationsOf(GameControl.computerSide | Piece.King)[0];

            int OpposingKingRow = OpposingKingSquare % 8;
            int OpposingKingCol = OpposingKingSquare / 8;

            int FriendlyKingRow = FriendlyKingSquare % 8;
            int FriendlyKingCol = FriendlyKingSquare / 8;

            // Переместите короля к королю противника в эндшпилях
            int DistanceBetweenKingsCols = Math.Abs(FriendlyKingCol - OpposingKingCol);
            int DistanceBetweenKingsRows = Math.Abs(FriendlyKingRow - OpposingKingRow);
            int DistanceBetweenKings = DistanceBetweenKingsCols + DistanceBetweenKingsRows;

            Evaluation += 14 - (DistanceBetweenKings * EndGameWeight);

            // Держите короля соперника вне центра, и своего  короля - в центре
            int OpposingKingsDistanceFromCentreRow = Math.Max(3 - OpposingKingRow, OpposingKingRow - 4);
            int OpposingKingsDistanceFromCentreCol = Math.Max(3 - OpposingKingCol, OpposingKingCol - 4);
            int OpponsingKingsDistanceFromCentre = OpposingKingsDistanceFromCentreRow + OpposingKingsDistanceFromCentreCol;

            Evaluation += (OpponsingKingsDistanceFromCentre * EndGameWeight);

            // Получите значение каждой фигуры на доске и добавьте для оценки
            Evaluation += PieceLocator.GetPosEval();

            return Evaluation;
        }
        // Генерирует все ходы, доступные в позиции
        // Выполняет цикл и возвращает значение на определенную глубину каждого хода
        // Сравнивает ход с лучшим ходом и обновляет, если он лучше
        // Отслеживает, насколько быстро был сгенерирован ход
        public static Move GenerateMove()
        {
            // Запуск таймера для проверки того, сколько времени требуется для генерации хода

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Generating Computer Move");

            // Установите переход от и к отрицательным значениям для проверки позже
            Move moveToPlay = new Move { Piece = 0, MoveFrom = -1, MoveTo = -1 };
            List<Move> AvailableMoves = RuleBook.GenerateLegalMoves();

            // // Если у компьютера нет ходов, верните отрицательные значения, это будет означать, мат
            if (AvailableMoves.Count == 0) 
            {
                return moveToPlay;
            }

            // Открывающий книжный раздел
            // // 4 хода в сторону (Управление игрой.Ходы < 8)
            // Если ход найден, верните ход, если нет, верните ход для воспроизведения с отрицательными значениями
            // Таким образом, компьютер знает, как сгенерировать свой собственный
            if (GameControl.Moves < 8)
            {
                Console.WriteLine("Move within first four, getting opening move");
                moveToPlay = OpeningBook.GetMove(AvailableMoves);

                if (moveToPlay.MoveFrom != -1)
                {
                    Console.WriteLine("Move found, not calculating own move\n");
                    return moveToPlay;
                }
            }

            // Все будет лучше, чем начинать с наилучшего значения оценки, даже если будет поставлен мат - это означает, что компьютер всегда вернет ход
            int BestEval = -999999999;

            // Сортировка перемещается от лучшего к худшему, чтобы помочь с альфа-бета-обрезкой
            AvailableMoves = sortMoves(AvailableMoves);

            // Для каждого перемещения в отсортированном списке
            // Выполните тестовый ход
            // Умножьте на минус единицу, так как ход, который хорош для противника, плох для компьютера
            // Если текущая оценка лучше, чем лучшая оценка, сделайте ход, чтобы разыграть текущий ход
            // Отменить тестовый переход для оценки следующего
            foreach (Move move in AvailableMoves.ToArray())
            {
                GameControl.makeTestMove(move);
                int moveEval = (GetMoveEvaluationToDepthOf(Depth, -100000000, 100000000)*-1) + LocationInscentives.GetLocationInscentiveFor(move.Piece, move.MoveTo)*-1;

                Console.WriteLine($"Best eval for move {Piece.PieceToFullName(move.Piece)} moves from {move.MoveFrom} to {move.MoveTo}: {moveEval} "); 
                if (moveEval > BestEval)
                {
                    BestEval = moveEval;
                    moveToPlay = move;
                }

                GameControl.unmakeTestMove(move);
            }

            // Timer stuff
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            GameWindow.BlackTimeLeft -= Convert.ToInt32(elapsedMs) / 1000;

            Console.WriteLine($"\nTime For Computer to generate move: {elapsedMs}ms");
            Console.WriteLine($"Minusing {Convert.ToInt32(elapsedMs) / 1000} seconds from computer clock. New time: {GameWindow.BlackTimeLeft}");
            Console.WriteLine($"Returning move {Piece.PieceToFullName(moveToPlay.Piece)} moves from {moveToPlay.MoveFrom} to {moveToPlay.MoveTo}, eval: {BestEval}");

            return moveToPlay;
        }
        // Генерирует ответы оппонентов в заданной позиции
        // Делает этот ход
        // Получает наилучший отклик для компьютера, это повторяется до тех пор, пока не будет достигнута минимальная глубина
        // Сортировка перемещается от худшего к лучшему, чтобы помочь избежать обрезки
        // Возвращает оценку позиции в конце поиска
        public static int GetMoveEvaluationToDepthOf(int depth, int alpha, int beta)
        {
            if(depth == 0) // Если достигнут конец дерева перемещений, верните текущую оценку                         
            {
                return EvaluatePos();
            }

            List<Move> responses = RuleBook.GenerateLegalMoves();


            // Это сохраняется, когда программа проверяет, удачен ли ход,
            // ей нужно будет проверить, находится ли король под контролем, и средство проверки книги правил может быть изменено во время генерации хода
            MovePutKingInCheck = false;
            if(RuleBook.KingInCheck == true)
            {
                MovePutKingInCheck = true;
            }

            if(responses.Count == 0)
            {
                if(MovePutKingInCheck == true)
                {
                    return -10000 * depth; // умножение на глубину означает, что предпочтение отдается более быстрым матам
                }
                return 0;
            }

            responses = sortMoves(responses);// Подбирайте ходы от лучших к худшим

            foreach (Move response in responses.ToArray()) 
            {
                GameControl.makeTestMove(response);// Сделать тестовый ответ
                int MoveEval = (GetMoveEvaluationToDepthOf(depth - 1, -beta, -alpha) * -1);  // Рекурсивный вызов функции
                GameControl.unmakeTestMove(response);  // Отменить создание ответа в конце рекурсии
                if (MoveEval >= beta) // Если оценка хода лучше, чем последний лучший ход
                {
                    return beta;
                }
                alpha = Math.Max(alpha, MoveEval); // Если нет, извлеките максимум пользы из предыдущей худшей и текущей оценок
            }

            return alpha;
        }

        // Присваиваем каждому ходу значение, зависящее от того, считаем ли мы, что это будет хорошо или нет
        // Быстрая сортировка этих значений сводит к минимуму перемещение данных, тем самым увеличивая скорость генерации перемещений
        // Обратный список, поскольку быстрая сортировка приводит от худшего к лучшему
        public static List<Move> sortMoves(List<Move> moveList)
        {
            // assign move score guesses
            // назначьте количество угадываемых ходов
            foreach (Move move in moveList)
            {
                int moveScore = 0;
                int piece = move.Piece;
                int capturedPiece = GameControl.Board[move.MoveTo].PieceOnSquare;

                if (capturedPiece != 0)
                {
                    moveScore = Piece.Value(capturedPiece) - Piece.Value(piece); // Capturing piece of lower value is good other way is bad
                    // Захват фрагмента меньшего значения - это хорошо, другой способ - плох
                }

                if (MovePutKingInCheck == true)
                {
                    moveScore += 300; // Checks are often good as they can lead to forks
                    // Проверки часто хороши, поскольку они могут привести к развилкам
                }

                if (RuleBook.SquaresToMoveToThatStopCheck.Contains(move.MoveTo))
                {
                    moveScore += 100; // Blocking check is often good (as opposed to moving the king)
                    // Блокирующий чек часто хорош (в отличие от перемещения короля)
                }

                if (RuleBook.EnemyAttacks.Contains(move.MoveTo))
                {
                    moveScore -= 250; // Moving to position where enemy attacks is often bad
                    // Перемещение на позицию, где вражеские атаки часто бывают неудачными
                }

                if (Piece.Type(piece) == Piece.Pawn && Piece.Type(RuleBook.CheckPromotion(move)) == Piece.Queen)
                {
                    moveScore += 500; // Trying to promote is good // Пытаться продвигать - это хорошо
                }

                move.MoveScore = moveScore;
            }

            moveList = QuickSort(moveList.ToArray(), 0, moveList.Count - 1).ToList();
            moveList.Reverse();

            return moveList;
        }
        public static Move[] QuickSort(Move[] unsortedList, int leftStartPointer, int rightStartPointer)
        {
            int leftPointer = leftStartPointer;
            int rightPointer = rightStartPointer; 
            int pivotNumber = unsortedList[leftPointer].MoveScore; 

            while (leftPointer <= rightPointer) 
            {
                while (unsortedList[leftPointer].MoveScore < pivotNumber)
                {
                    leftPointer++; 
                }
                while (unsortedList[rightPointer].MoveScore > pivotNumber) 
                {
                    rightPointer--; 

                }

                if (leftPointer <= rightPointer)
                {
                    Move moveHolder = unsortedList[leftPointer]; 
                    unsortedList[leftPointer] = unsortedList[rightPointer]; 
                    unsortedList[rightPointer] = moveHolder;
                    leftPointer++;
                    rightPointer--; 
                }
            }
            if (leftStartPointer < rightPointer)
            {
                QuickSort(unsortedList, leftStartPointer, rightPointer); 
            }
            if (leftPointer < rightStartPointer) 
            {
                QuickSort(unsortedList, leftPointer, rightStartPointer); 
            }
            Move[] sortedList = unsortedList; 

            return sortedList;

        }
    }
}