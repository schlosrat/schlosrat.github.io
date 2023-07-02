// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.State;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedFlag
  {
    public const string DEFAULT_OWNER_PLAYER_GUID_STRING = "";
    public const byte DEFAULT_OWNER_PLAYER_ID = 0;
    public const byte DEFAULT_AUTHORITY_PLAYER_ID = 0;
    public IGGuid Guid;
    public string OwnerPlayerGuidString;
    public byte OwnerPlayerId;
    public byte AuthorityPlayerId;
    public FlagComponentDefinition FlagDefinition;
    public FlagComponentState FlagState;
    public SerializedLocation Location;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedFlag() => throw null;
  }
}
