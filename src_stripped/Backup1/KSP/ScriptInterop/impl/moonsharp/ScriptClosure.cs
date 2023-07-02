// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptClosure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class ScriptClosure : ScriptValue, IScriptClosure, IScriptValue
  {
    private MoonSharp.Interpreter.Closure closure;
    private ScriptEnvironmentInterop typeInteropAssistant;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptClosure(
      DynValue closure,
      ScriptEnvironmentInterop typeInteropAssistant,
      ITypeInterop typeInterop,
      ITypeWriter typeWriter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Invoke(params object[] parameters) => throw null;
  }
}
