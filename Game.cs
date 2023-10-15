using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiuiu.iipb_22_2.MilyayevVD.Bowling
{
    public class Game
    {
        private List<Throw> throws = new List<Throw>(); // лист бросков

        public void RecordThrow(Throw throwObj)  //записывается новый бросок
        {
            throws.Add(throwObj);
        }

        private bool IsStrike(int throwIndex) // проверка броска на страйк
        {
            return throws[throwIndex].PinsKnockedDown == 10;
        }
        private bool IsSpare(int throwIndex) // проверка броска на спэр
        {
            return throws[throwIndex].PinsKnockedDown + throws[throwIndex + 1].PinsKnockedDown == 10;
        }
        private int StrikeBonus(int throwIndex) // бонус за страйк
        {
            if (throwIndex + 2 < throws.Count)
            {
                return throws[throwIndex + 1].PinsKnockedDown + throws[throwIndex + 2].PinsKnockedDown;
            }
            else
            {
                return 0; // возвращаем 0, если бросков недостаточно для вычисления бонуса
            }
        }
        private int SpareBonus(int throwIndex) // бонус за спэр
        {
            if (throwIndex + 2 < throws.Count)
            {
                return throws[throwIndex + 2].PinsKnockedDown;
            }
            else
            {
                return 0; // возвращаем 0, если бросков недостаточно для вычисления бонуса
            }
        }
        public int CalculateScore() // подсчет количества очков (правильный)
        {
            int totalScore = 0; // общий счет
            int throwIndex = 0; // индекс текущего броска 

            for (int frame = 0; frame < 10; frame++)
            {
                if (throwIndex < throws.Count) // проверка есть ли еще броски
                {
                    if (IsStrike(throwIndex)) // проверка на страйк 
                    {
                        totalScore += 10 + StrikeBonus(throwIndex);
                        throwIndex++;
                    }
                    else if (IsSpare(throwIndex)) // проверка на спэр
                    {
                        totalScore += 10 + SpareBonus(throwIndex);
                        throwIndex += 2;
                    }
                    else
                    {
                        if (throwIndex + 1 < throws.Count)  // проверка есть ли еще броски для обработки
                        {
                            int totalPins = throws[throwIndex].PinsKnockedDown + throws[throwIndex + 1].PinsKnockedDown; // сумма кегель в бросках
                            if (totalPins > 10) // обработка ошибки 
                            {
                                throw new InvalidOperationException("Сумма сбитых кеглей в двух бросках не может превышать 10.");
                            }
                            totalScore += totalPins;
                            throwIndex += 2;
                        }
                        else // если недостаточно бросков для окончания фрейма 
                        {
                            break;
                        }
                    }
                }
                else // бросков больше нет
                {
                    break;
                }
            }
            return totalScore;
        }
    }
}
