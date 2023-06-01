// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.ScriptRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Assets;
using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop
{
  public class ScriptRunner : IScriptRunner
  {
    private IScriptEnvironment scriptEnvironment;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptRunner(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunScriptAssetAsync<T>(
      string key,
      AssetProvider assetProvider,
      Action<T> resultCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunScriptAssetAsync(
      string key,
      AssetProvider assetProvider,
      Action<IScriptValue> resultCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunScriptString(string luaString, Action<IScriptValue> resultCallback = null) => throw null;
  }
}
