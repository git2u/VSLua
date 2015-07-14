﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageService.Formatting.Ruling
{
    internal class Rules
    {

        private static readonly List<ContextFilter> defaultFilters = new List<ContextFilter>
        {
            TokensAreOnSameLine,
            NoCommentBetweenTokens
        };

        internal static IRule SpaceAfterComma =
            new Rule(
                new RuleDescriptor(TokenType.Comma, TokenRange.Any),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceAfterAssignmentOperator =
            new Rule(
                new RuleDescriptor(TokenType.AssignmentOperator, TokenRange.Any),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceBeforeAssignmentOperator =
            new Rule(
                new RuleDescriptor(TokenRange.Any, TokenType.AssignmentOperator),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceAfterBinaryOperator =
            new Rule(
                new RuleDescriptor(TokenRange.BinaryOperators, TokenRange.Any),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceBeforeBinaryOperator =
            new Rule(
                new RuleDescriptor(TokenRange.Any, TokenRange.BinaryOperators),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceAfterValueBeforeOpenParenthesis =
            new Rule(
                new RuleDescriptor(TokenRange.Value, TokenType.OpenParen),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceBeforeValueAfterOpenParenthesis =
            new Rule(
                new RuleDescriptor(TokenType.OpenParen, TokenRange.Value),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceBeforeValueAfterOpenSquareBracket =
            new Rule(
                new RuleDescriptor(TokenType.OpenBracket, TokenRange.Value),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceBeforeValueAfterOpenCurlyBrace =
            new Rule(new RuleDescriptor(TokenType.OpenCurlyBrace, TokenRange.Value),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceAfterValueBeforeCloseParenthesis =
            new Rule(new RuleDescriptor(TokenRange.Value, TokenType.CloseParen),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceAfterValueBeforeCloseSquareBracket =
            new Rule(new RuleDescriptor(TokenRange.Value, TokenType.CloseBracket),
                defaultFilters, RuleAction.Space);

        internal static IRule SpaceAfterValueBeforeCloseCurlyBrace =
            new Rule(new RuleDescriptor(TokenRange.Value, TokenType.CloseCurlyBrace),
                defaultFilters, RuleAction.Space);



        internal static bool TokensAreOnSameLine(FormattingContext formattingContext)
        {
            return formattingContext.TokensOnSameLine();
        }

        internal static bool NoCommentBetweenTokens(FormattingContext formattingContext)
        {
            return !formattingContext.CommentsInBetween();
        }

    }
}
