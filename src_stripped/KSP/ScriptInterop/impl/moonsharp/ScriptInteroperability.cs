// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptInteroperability
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class ScriptInteroperability : IScriptInterop, IScriptEnvironmentOwner, IFixedUpdate
  {
    public const string clrkey = "_t";
    private List<IScriptEnvironment> environments;

    [DllImport("LuaPipePlugin64", CharSet = CharSet.Ansi)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetPipeName(string pipeName) => throw null;

    [DllImport("LuaPipePlugin64", CharSet = CharSet.Ansi)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void QueryRemoteScripts(
      ScriptInteroperability.ProcessRemoteScript callback)
    {
      throw null;
    }

    public IScriptEnvironment RootEnvironment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IScriptEnvironment AssetCompilerEnvironment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ReadOnlyCollection<IScriptEnvironment> Environments
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptInteroperability(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string processRemoteScripts(string context, string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddEnvironment(IScriptEnvironment environment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void onUpdate(long deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    public delegate string ProcessRemoteScript(string context, string script);
  }
}
