// Decompiled with JetBrains decompiler
// Type: DynamicScriptConfigurationDatabase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Assets;
using KSP.ScriptInterop;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DynamicScriptConfigurationDatabase
{
  private DynamicConfigurationDatabase database;
  private IScriptRunner scriptRunner;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DynamicScriptConfigurationDatabase(
    DynamicConfigurationDatabase database,
    IScriptRunner scriptRunner)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Shutdown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddFromScriptAsync<T>(
    string scriptAssetKey,
    AssetProvider assetProvider,
    Action<T> resultCallback,
    string table = "")
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddFromScriptAsync(
    string scriptAssetKey,
    AssetProvider assetProvider,
    Action<object> resultCallback,
    string table = "")
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddScriptValueResult(object resultObject, string table) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsList(object @object) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsDictionary(object @object) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(object value, string table = "") => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(object value, string table = "") => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerable<System.Type> Types() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerable<string> Tables(System.Type type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerable<object> Values(System.Type type, string table = "") => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DynamicConfigurationDatabase GetDatabase() => throw null;
}
