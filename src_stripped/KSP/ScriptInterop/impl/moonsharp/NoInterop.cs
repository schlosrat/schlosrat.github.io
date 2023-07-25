// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.NoInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class NoInterop : IRunScriptInterop
  {
    private IScriptThread deadThread;
    private IScriptValue deadValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NoInterop(string reason, ScriptEnvironment typeInterop, ITypeWriter typeWriter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue RunScript(string injectedScript, string codeFriendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue RunScript(ICompiledScript compiledScript) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptValue RunScript(byte[] script, string codeFriendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptThread RunScriptAsync(string injectedScript) => throw null;
  }
}
