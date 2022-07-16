using System;
using System.Collections.Generic;

namespace ChoreManagement.core.lib.Services
{
    public class RandomNumbersGenerator<T>:List<T>{

        public  readonly List<T> listReceived;
        public RandomNumbersGenerator(List<T> list)
        {
            this.listReceived = list;
        }
        public IDictionary<int, T> GetRandomNumberForEachObject()
        {
            var usedRandomNumbers = new List<int>();
            var objectList = new Dictionary<int, T>();

            foreach (var type in listReceived)
            {
            startLable:
                var randomNumber = getRandomNumber(0, listReceived.Count + 1);

                if (objectList.TryGetValue(randomNumber, out T _list))
                {
                    goto startLable;
                }
                else
                {
                    objectList.Add(randomNumber, type);
                    usedRandomNumbers.Add(randomNumber);
                };

            }
            return objectList;
        }
        private static int getRandomNumber(int min, int max)
        {
            Random random = new Random();
            int number = random.Next(min, max);

            return number;
        }
    }

}