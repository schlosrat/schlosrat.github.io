// Decompiled with JetBrains decompiler
// Type: KSP.Game.Load.CollectFlightDataFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Load
{
  public class CollectFlightDataFlowAction : SaveLoadGameFlowActionBase
  {
    public List<SerializedAssembly> SerializableVessels;
    private LoadGameData _gameData;
    private byte _playerID;
    private readonly FlightDataFlags _flags;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CollectFlightDataFlowAction(FlightDataFlags flags, LoadGameData data, byte playerID = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoAction(Action resolve, Action<string> reject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectVesselComponents(byte playerID) => throw null;
  }
}
