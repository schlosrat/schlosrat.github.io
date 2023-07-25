// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptCallback`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class ScriptCallback<T>
  {
    public CallbackFunction callbackFunction;
    private T callback;
    private Delegate callbackDelegate;
    private ScriptEnvironmentInterop typeInteropAssistant;
    private ITypeInterop typeInterop;
    private ITypeWriter typeWriter;
    private Type[] parameterTypes;
    private object[] parameterBuffer;
    private IScriptValue nil;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptCallback(
      string name,
      T callback,
      IScriptValue nil,
      ScriptEnvironmentInterop typeInteropAssistant,
      ITypeInterop typeInterop,
      ITypeWriter typeWriter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue moonsharpCallback(ScriptExecutionContext context, CallbackArguments args) => throw null;
  }
}
