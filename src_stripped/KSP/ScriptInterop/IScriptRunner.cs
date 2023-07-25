// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
