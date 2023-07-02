// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.DeserializeAddressableFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class DeserializeAddressableFlowAction : SaveLoadGameFlowActionBase
  {
    private string _assetKey;
    private static JsonSerializerSettings _ignoreNullValueSerialzationSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeserializeAddressableFlowAction(string assetKey, LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DeserializeAddressableFlowAction() => throw null;
  }
}
