// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Tree.Expressions.BinaryOperatorExpression
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Execution;
using MoonSharp.Interpreter.Execution.VM;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Tree.Expressions
{
  internal class BinaryOperatorExpression : Expression
  {
    private const BinaryOperatorExpression.Operator POWER = BinaryOperatorExpression.Operator.Power;
    private const BinaryOperatorExpression.Operator MUL_DIV_MOD = BinaryOperatorExpression.Operator.Mul | BinaryOperatorExpression.Operator.Div | BinaryOperatorExpression.Operator.Mod;
    private const BinaryOperatorExpression.Operator ADD_SUB = BinaryOperatorExpression.Operator.Add | BinaryOperatorExpression.Operator.Sub;
    private const BinaryOperatorExpression.Operator STRCAT = BinaryOperatorExpression.Operator.StrConcat;
    private const BinaryOperatorExpression.Operator COMPARES = BinaryOperatorExpression.Operator.Less | BinaryOperatorExpression.Operator.Greater | BinaryOperatorExpression.Operator.LessOrEqual | BinaryOperatorExpression.Operator.GreaterOrEqual | BinaryOperatorExpression.Operator.NotEqual | BinaryOperatorExpression.Operator.Equal;
    private const BinaryOperatorExpression.Operator LOGIC_AND = BinaryOperatorExpression.Operator.And;
    private const BinaryOperatorExpression.Operator LOGIC_OR = BinaryOperatorExpression.Operator.Or;
    private Expression m_Exp1;
    private Expression m_Exp2;
    private BinaryOperatorExpression.Operator m_Operator;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object BeginOperatorChain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddExpressionToChain(object chain, Expression exp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddOperatorToChain(object chain, Token op) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Expression CommitOperatorChain(object chain, ScriptLoadingContext lcontext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Expression CreatePowerExpression(
      Expression op1,
      Expression op2,
      ScriptLoadingContext lcontext)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AddNode(
      BinaryOperatorExpression.LinkedList list,
      BinaryOperatorExpression.Node node)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Expression CreateSubTree(
      BinaryOperatorExpression.LinkedList list,
      ScriptLoadingContext lcontext)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static BinaryOperatorExpression.Node PrioritizeLeftAssociative(
      BinaryOperatorExpression.Node nodes,
      ScriptLoadingContext lcontext,
      BinaryOperatorExpression.Operator operatorsToFind)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static BinaryOperatorExpression.Node PrioritizeRightAssociative(
      BinaryOperatorExpression.Node nodes,
      ScriptLoadingContext lcontext,
      BinaryOperatorExpression.Operator operatorsToFind)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static BinaryOperatorExpression.Operator ParseBinaryOperator(Token token) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private BinaryOperatorExpression(
      Expression exp1,
      Expression exp2,
      BinaryOperatorExpression.Operator op,
      ScriptLoadingContext lcontext)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool ShouldInvertBoolean(BinaryOperatorExpression.Operator op) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static OpCode OperatorToOpCode(BinaryOperatorExpression.Operator op) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Compile(ByteCode bc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Eval(ScriptExecutionContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double EvalArithmetic(DynValue v1, DynValue v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool EvalComparison(DynValue l, DynValue r, BinaryOperatorExpression.Operator op) => throw null;

    [Flags]
    private enum Operator
    {
      NotAnOperator = 0,
      Or = 1,
      And = 2,
      Less = 4,
      Greater = 8,
      LessOrEqual = 16, // 0x00000010
      GreaterOrEqual = 32, // 0x00000020
      NotEqual = 64, // 0x00000040
      Equal = 128, // 0x00000080
      StrConcat = 256, // 0x00000100
      Add = 512, // 0x00000200
      Sub = 1024, // 0x00000400
      Mul = 4096, // 0x00001000
      Div = 8192, // 0x00002000
      Mod = 16384, // 0x00004000
      Power = 32768, // 0x00008000
    }

    private class Node
    {
      public Expression Expr;
      public BinaryOperatorExpression.Operator Op;
      public BinaryOperatorExpression.Node Prev;
      public BinaryOperatorExpression.Node Next;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Node() => throw null;
    }

    private class LinkedList
    {
      public BinaryOperatorExpression.Node Nodes;
      public BinaryOperatorExpression.Node Last;
      public BinaryOperatorExpression.Operator OperatorMask;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LinkedList() => throw null;
    }
  }
}
