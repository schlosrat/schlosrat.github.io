// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.SerializeGameToMemoryFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class SerializeGameToMemoryFlowAction : SaveLoadGameFlowActionBase
  {
    public LoadOrSaveCampaignTicket _loadOrSaveCampaignTicket;
    private static JsonSerializerSettings _packedSerializerSettings;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializeGameToMemoryFlowAction(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SerializeGameToMemoryFlowAction() => throw null;
  }
}
