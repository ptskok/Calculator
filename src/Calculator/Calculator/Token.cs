namespace Calculator
{
    public class Token
    {
        public TokenType Type { get; }
        public string Attribute { get; }

        public Token(TokenType type, string attribute)
        {
            Type = type;
            Attribute = attribute;
        }
        public Token(TokenType type)
        {
            Type = type;
            Attribute = string.Empty;
        }
    }
}
