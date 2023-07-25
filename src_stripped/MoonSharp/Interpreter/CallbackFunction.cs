// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CallbackFunction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public sealed class CallbackFunction : RefIdObject
  {
    private static InteropAccessMode m_DefaultAccessMode;

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Func<ScriptExecutionContext, CallbackArguments, DynValue> ClrCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CallbackFunction(
      Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack,
      string name = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Invoke(
      ScriptExecutionContext executionContext,
      IList<DynValue> args,
      bool isMethodCall = false)
    {
      throw null;
    }

    public static InteropAccessMode DefaultAccessMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CallbackFunction FromDelegate(
      Script script,
      Delegate del,
      InteropAccessMode accessMode = InteropAccessMode.Default)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CallbackFunction FromMethodInfo(
      Script script,
      MethodInfo mi,
      object obj = null,
      InteropAccessMode accessMode = InteropAccessMode.Default)
    {
      throw null;
    }

    public object AdditionalData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CheckCallbackSignature(MethodInfo mi, bool requirePublicVisibility) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CallbackFunction() => throw null;
  }
}
