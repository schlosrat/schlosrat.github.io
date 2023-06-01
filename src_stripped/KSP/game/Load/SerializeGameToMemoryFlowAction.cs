// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.SerializeGameToMemoryFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
