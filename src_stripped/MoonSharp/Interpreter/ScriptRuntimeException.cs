// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.ScriptRuntimeException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop;
using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  [Serializable]
  public class ScriptRuntimeException : InterpreterException
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptRuntimeException(Exception ex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptRuntimeException(ScriptRuntimeException ex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptRuntimeException(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptRuntimeException(string format, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException ArithmeticOnNonNumber(DynValue l, DynValue r = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException ConcatOnNonString(DynValue l, DynValue r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException LenOnInvalidType(DynValue r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException CompareInvalidType(DynValue l, DynValue r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException BadArgument(int argNum, string funcName, string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException BadArgumentUserData(
      int argNum,
      string funcName,
      Type expected,
      object got,
      bool allowNil)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException BadArgument(
      int argNum,
      string funcName,
      DataType expected,
      DataType got,
      bool allowNil)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException BadArgument(
      int argNum,
      string funcName,
      string expected,
      string got,
      bool allowNil)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException BadArgumentNoValue(
      int argNum,
      string funcName,
      DataType expected)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException BadArgumentIndexOutOfRange(string funcName, int argNum) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException BadArgumentNoNegativeNumbers(int argNum, string funcName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException BadArgumentValueExpected(int argNum, string funcName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException IndexType(DynValue obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException LoopInIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException LoopInNewIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException LoopInCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException TableIndexIsNil() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException TableIndexIsNaN() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException ConvertToNumberFailed(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException ConvertObjectFailed(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException ConvertObjectFailed(DataType t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException ConvertObjectFailed(DataType t, Type t2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException UserDataArgumentTypeMismatch(DataType t, Type clrType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException UserDataMissingField(string typename, string fieldname) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException CannotResumeNotSuspended(CoroutineState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException CannotYield() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException CannotYieldMain() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException AttemptToCallNonFunc(DataType type, string debugText = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException AccessInstanceMemberOnStatics(IMemberDescriptor desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ScriptRuntimeException AccessInstanceMemberOnStatics(
      IUserDataDescriptor typeDescr,
      IMemberDescriptor desc)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Rethrow() => throw null;
  }
}
