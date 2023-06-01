// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
