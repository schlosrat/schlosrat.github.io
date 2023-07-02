// Decompiled with JetBrains decompiler
// Type: KSP.Modding.KSP2LuaModCore
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Modding
{
  public class KSP2LuaModCore : IKSP2ModCore
  {
    private KSP2ModCoreState modCoreState;
    private IScriptEnvironment ScriptEnvironment;
    private IScriptInterop scriptInterop;
    private string scriptPayload;

    private KSP2ModManager modManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KSP2ModCoreState ModCoreState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2LuaModCore(
      Version APIVersion,
      string ModName,
      string EntryPoint,
      string ModRootPath)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteScript(string script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ModShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExecuteEvent(string eventName) => throw null;
  }
}
