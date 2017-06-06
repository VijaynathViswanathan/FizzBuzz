﻿using FizzBuzz.Interface;
using System;

namespace FizzBuzz.Classes
{
    public class FizzBuzz : IFizzBuzzHandler
    {
        private readonly IFizzBuzzHandler _fizzBuzzHandler;
        public FizzBuzz(IFizzBuzzHandler fizzBuzzHandler)
        {
            _fizzBuzzHandler = fizzBuzzHandler;
        }
        public string Handle(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            return _fizzBuzzHandler.Handle(number);
        }
    }
}
