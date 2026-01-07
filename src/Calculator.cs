using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project
{
    internal class Calculator
    {
        private float _Result = 0;
        private float _LastNumber = 0;
        private string _FinalOperation = "No Thing";

        private bool _IsZero(float Number)
        {
            return (Number == 0);
        }

        public void Clear()
        {
            _Result = 0;
            _LastNumber = 0;
            _FinalOperation = "Clear";
        }

        public void Add(float Number)
        {
            _Result += Number;
            _LastNumber = Number;
            _FinalOperation = "Adding";
        }

        public void Subtract(float Number)
        {
            _Result -= Number;
            _LastNumber = Number;
            _FinalOperation = "Subtracting";
        }

        public bool Divide(float Number)
        {
            bool Succeeded = true;
            _FinalOperation = "Dividing";
            if (_IsZero(Number))
            {
                _LastNumber = Number;
                _Result /= 1;
                Succeeded = false;
            }
            else
            {
                _LastNumber = Number;
                _Result /= Number;
            }
            return Succeeded;

        }

        public void Multiply(float Number)
        {
            _Result *= Number;
            _LastNumber = Number;
            _FinalOperation = "Multiplying";
        }

        public float GetFinalResult()
        {
            return _Result;
        }

        public void PrintResult()
        {
            Console.WriteLine("Result after {0} {1} is: {2}", _FinalOperation, _LastNumber, _Result);
        }
    }
}
