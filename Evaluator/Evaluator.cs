namespace Evaluator
{
    using System;
    using System.Collections.Generic;

    internal class Evaluator<T> where T : new()
    {
        private readonly Dictionary<Func<T, T[], T>, T[]> _funcs = new();

        public void Add(Func<T, T[], T> func, params T[] additionalArgs)
        {
            if (func != null)
            {
                _funcs.Add(func, additionalArgs);
            }
        }

        public T Evaluate(T seed)
        {
            try
            {
                if (seed != null)
                {
                    var _value = seed;
                    foreach (var func in _funcs)
                    {
                        _value = func.Key(_value, func.Value);
                    }
                    return _value;
                }

                return seed;
            }
            catch (Exception ex)
            {
                Exception exception = ex;
                throw exception;
            }
        }

        public string? HasValue(T response)
        {
            if (response != null)
            {
                return response.ToString();
            }
            else
            {
                return "Input value is null!";
            }
        }
    }
}
