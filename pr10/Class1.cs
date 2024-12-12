

namespace WpfLibrary1
{
    
        public static class NumberCounter
        {
            public static CountResult Count(this IEnumerable<int> numbers)
            {
                var result = new CountResult();

                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        result.Positive++;
                    }
                    else if (number < 0)
                    {
                        result.Negative++;
                    }
                }

                return result;
            }

            public class CountResult
            {
                public int Positive { get; set; } = 0; // Инициализация
                public int Negative { get; set; } = 0; // Инициализация
            }
        }
    }
