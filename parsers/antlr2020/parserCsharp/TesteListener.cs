//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Teste.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="TesteParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public interface ITesteListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="TesteParser.lang"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLang([NotNull] TesteParser.LangContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TesteParser.lang"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLang([NotNull] TesteParser.LangContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TesteParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] TesteParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TesteParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] TesteParser.ExprContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TesteParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] TesteParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TesteParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] TesteParser.TermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="TesteParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactor([NotNull] TesteParser.FactorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="TesteParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactor([NotNull] TesteParser.FactorContext context);
}
