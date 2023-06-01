// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.SavePlantedFlagsFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class SavePlantedFlagsFlowAction : SaveLoadGameFlowActionBase
  {
    private LoadGameData _gameData;
    private byte _playerID;
    private List<SerializedFlag> _serializedPlantedFlags;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SavePlantedFlagsFlowAction(LoadGameData data, byte playerID = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CollectFlagComponents(byte playerID) => throw null;
  }
}
