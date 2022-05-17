using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum TokenType
    {
        Number,
        Plus,
        Minus,
        Multiplication,
        Division,
        LeftBracket,
        RightBracket,
        EOF
    }
}
