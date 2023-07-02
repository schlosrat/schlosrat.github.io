// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.DeadThread
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class DeadThread : IScriptThread
  {
    public bool IsReady
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsErrored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IScriptValue ReturnValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public event Action<IScriptValue> onFinished
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeadThread(string returnValue, ScriptEnvironment interop, ITypeWriter typeWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCoroutine(IScriptValue script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResumeCoroutine() => throw null;
  }
}
