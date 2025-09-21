
using System;
using System.Text.RegularExpressions;

namespace Chess
{
    internal static class Regexes
    {
        internal const string SanOneMovePattern = @"(^([PNBRQK])?([a-h])?([1-8])?(x|X|-)?([a-h][1-8])(=[NBRQ]| ?e\.p\.)?|^O-O(-O)?)(\+|\#|\$)?$";

        internal const string SanMovesPattern = @"(?:[PNBRQK]?[a-h]?[1-8]?[xX-]?[a-h][1-8](?:=[NBRQ]| ?e\.p\.)?|O-O(?:-O)?)[+#$]?";

        internal const string HeadersPattern = @"\[([^ ]+) ""([^""]*)""\]";

        internal const string AlternativesPattern = @"\([^)]*\)";

        internal const string CommentsPattern = @"\{[^}]*\}";

        internal const string FenPattern = @"^(((?:[rnbqkpRNBQKP1-8]+\/){7})[rnbqkpRNBQKP1-8]+) ([bw]) (-|[KQkq]{1,4}) (-|[a-h][36]) (\d+ \d+)$";

        internal const string FenContainsOneWhiteKingPattern = "^[^ K]*K[^ K]* ";

        internal const string FenContainsOneBlackKingPattern = "^[^ k]*k[^ k]* ";

        internal const string PiecePattern = "^[wb][bknpqr]$";

        internal const string FenPiecePattern = "^[bknpqrBKNPQR]$";

        internal const string PositionPattern = "^[a-h][1-8]$";

        internal const string MovePattern = @"^{(([wb][bknpqr]) - )?([a-h][1-8]) - ([a-h][1-8])( - ([wb][bknpqr]))?( - (o-o|o-o-o|e\.p\.|=|=q|=r|=b|=n))?( - ([+#$]))?}$";

        internal static readonly Regex RegexSanOneMove = new Regex(SanOneMovePattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexSanMoves = new Regex(SanMovesPattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexHeaders = new Regex(HeadersPattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexAlternatives = new Regex(AlternativesPattern, RegexOptions.Compiled | RegexOptions.Singleline, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexComments = new Regex(CommentsPattern, RegexOptions.Compiled | RegexOptions.Singleline, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexFen = new Regex(FenPattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexFenContainsOneWhiteKing = new Regex(FenContainsOneWhiteKingPattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexFenContainsOneBlackKing = new Regex(FenContainsOneBlackKingPattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexPiece = new Regex(PiecePattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexFenPiece = new Regex(FenPiecePattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexPosition = new Regex(PositionPattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));

        internal static readonly Regex RegexMove = new Regex(MovePattern, RegexOptions.Compiled, TimeSpan.FromMilliseconds(250));
    }
}
