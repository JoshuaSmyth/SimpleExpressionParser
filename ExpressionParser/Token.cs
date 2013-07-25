﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ExpressionParser
{
    public class Token
    {
        private readonly Regex m_Regex;
        private TokenType m_TokenType;
        private readonly TokenDiscardPolicy m_DiscardPolicy;
        private readonly OperationType m_OperationType;

        public TokenType TokenType
        {
            get { return m_TokenType; }
            set { m_TokenType = value; }
        }

        public Regex Regex { get { return m_Regex; } }

        public String TokenValue { get; set; }

        public OperationType OperationType
        {
            get { return m_OperationType; }
        }

        public TokenDiscardPolicy DiscardPolicy
        {
            get { return m_DiscardPolicy; }
        }

        public Token(Regex match, TokenType tokenType, OperationType operationType = OperationType.Operator, TokenDiscardPolicy discardPolicy = TokenDiscardPolicy.Keep)
        {
            m_TokenType = tokenType;
            m_DiscardPolicy = discardPolicy;
            m_OperationType = operationType;
            m_Regex = match;
         
        }

    }
}
