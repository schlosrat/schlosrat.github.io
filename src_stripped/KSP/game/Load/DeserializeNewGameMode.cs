// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.DeserializeNewGameMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Contexts.Game;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class DeserializeNewGameMode : SaveLoadGameFlowActionBase
  {
    private GameModeData? _gamemode;
    private static JsonSerializerSettings _ignoreNullValueSerialzationSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeserializeNewGameMode(GameModeData gamemode, LoadGameData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DeserializeNewGameMode() => throw null;
  }
}
