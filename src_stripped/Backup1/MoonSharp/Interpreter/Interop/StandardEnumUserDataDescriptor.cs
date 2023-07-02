// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.StandardEnumUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class StandardEnumUserDataDescriptor : DispatchingUserDataDescriptor
  {
    private Func<object, ulong> m_EnumToULong;
    private Func<ulong, object> m_ULongToEnum;
    private Func<object, long> m_EnumToLong;
    private Func<long, object> m_LongToEnum;

    public Type UnderlyingType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsUnsigned
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsFlags
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardEnumUserDataDescriptor(
      Type enumType,
      string friendlyName = null,
      string[] names = null,
      object[] values = null,
      Type underlyingType = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillMemberList(string[] names, object[] values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddEnumMethod(string name, DynValue dynValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private long GetValueSigned(DynValue dv) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ulong GetValueUnsigned(DynValue dv) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue CreateValueSigned(long value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue CreateValueUnsigned(ulong value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateSignedConversionFunctions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateUnsignedConversionFunctions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue PerformBinaryOperationS(
      string funcName,
      ScriptExecutionContext ctx,
      CallbackArguments args,
      Func<long, long, DynValue> operation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue PerformBinaryOperationU(
      string funcName,
      ScriptExecutionContext ctx,
      CallbackArguments args,
      Func<ulong, ulong, DynValue> operation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue PerformBinaryOperationS(
      string funcName,
      ScriptExecutionContext ctx,
      CallbackArguments args,
      Func<long, long, long> operation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue PerformBinaryOperationU(
      string funcName,
      ScriptExecutionContext ctx,
      CallbackArguments args,
      Func<ulong, ulong, ulong> operation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue PerformUnaryOperationS(
      string funcName,
      ScriptExecutionContext ctx,
      CallbackArguments args,
      Func<long, long> operation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue PerformUnaryOperationU(
      string funcName,
      ScriptExecutionContext ctx,
      CallbackArguments args,
      Func<ulong, ulong> operation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue Callback_Or(ScriptExecutionContext ctx, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue Callback_And(ScriptExecutionContext ctx, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue Callback_Xor(ScriptExecutionContext ctx, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue Callback_BwNot(ScriptExecutionContext ctx, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue Callback_HasAll(ScriptExecutionContext ctx, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DynValue Callback_HasAny(ScriptExecutionContext ctx, CallbackArguments args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool IsTypeCompatible(Type type, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue MetaIndex(Script script, object obj, string metaname) => throw null;
  }
}
