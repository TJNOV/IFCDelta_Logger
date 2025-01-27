﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from E:\Work\Companies\Fiverr\Revit Logger V5.1\Exporter\Revit.IFC.Export\Utility\ParamExprGrammar.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Revit.IFC.Export.Utility {

   #pragma warning disable 3021


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IParamExprGrammarListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class ParamExprGrammarBaseListener : IParamExprGrammarListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.param_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParam_expr([NotNull] ParamExprGrammarParser.Param_exprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.param_expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParam_expr([NotNull] ParamExprGrammarParser.Param_exprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpr([NotNull] ParamExprGrammarParser.ExprContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.expr"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpr([NotNull] ParamExprGrammarParser.ExprContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.atomic_param"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtomic_param([NotNull] ParamExprGrammarParser.Atomic_paramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.atomic_param"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtomic_param([NotNull] ParamExprGrammarParser.Atomic_paramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.objref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterObjref([NotNull] ParamExprGrammarParser.ObjrefContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.objref"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitObjref([NotNull] ParamExprGrammarParser.ObjrefContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterType([NotNull] ParamExprGrammarParser.TypeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.type"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitType([NotNull] ParamExprGrammarParser.TypeContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.special_param"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSpecial_param([NotNull] ParamExprGrammarParser.Special_paramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.special_param"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSpecial_param([NotNull] ParamExprGrammarParser.Special_paramContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.param_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParam_name([NotNull] ParamExprGrammarParser.Param_nameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.param_name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParam_name([NotNull] ParamExprGrammarParser.Param_nameContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterName([NotNull] ParamExprGrammarParser.NameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.name"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitName([NotNull] ParamExprGrammarParser.NameContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.unary_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUnary_operator([NotNull] ParamExprGrammarParser.Unary_operatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.unary_operator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUnary_operator([NotNull] ParamExprGrammarParser.Unary_operatorContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.ops"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOps([NotNull] ParamExprGrammarParser.OpsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.ops"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOps([NotNull] ParamExprGrammarParser.OpsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.power_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPower_op([NotNull] ParamExprGrammarParser.Power_opContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.power_op"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPower_op([NotNull] ParamExprGrammarParser.Power_opContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue([NotNull] ParamExprGrammarParser.ValueContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.value"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue([NotNull] ParamExprGrammarParser.ValueContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.value_with_unit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterValue_with_unit([NotNull] ParamExprGrammarParser.Value_with_unitContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.value_with_unit"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitValue_with_unit([NotNull] ParamExprGrammarParser.Value_with_unitContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.stringliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringliteral([NotNull] ParamExprGrammarParser.StringliteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.stringliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringliteral([NotNull] ParamExprGrammarParser.StringliteralContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.realliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterRealliteral([NotNull] ParamExprGrammarParser.RealliteralContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.realliteral"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitRealliteral([NotNull] ParamExprGrammarParser.RealliteralContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="ParamExprGrammarParser.signed_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSigned_number([NotNull] ParamExprGrammarParser.Signed_numberContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="ParamExprGrammarParser.signed_number"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSigned_number([NotNull] ParamExprGrammarParser.Signed_numberContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Revit.IFC.Export.Utility
