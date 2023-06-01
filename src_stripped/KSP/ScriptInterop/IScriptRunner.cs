// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Assets;
using System;

namespace KSP.ScriptInterop
{
  public interface IScriptRunner
  {
    void RunScriptAssetAsync<T>(string key, AssetProvider assetProvider, Action<T> resultCallback);

    void RunScriptAssetAsync(
      string key,
      AssetProvider assetProvider,
      Action<IScriptValue> resultCallback);

    void RunScriptString(string luaString, Action<IScriptValue> resultCallback = null);
  }
}
