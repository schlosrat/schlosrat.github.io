// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
