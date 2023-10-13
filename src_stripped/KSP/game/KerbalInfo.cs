// Decompiled with JetBrains decompiler
// Type: KSP.Game.KerbalInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.impl;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class KerbalInfo
  {
    private string _nameKey;
    private string _playerGuidString;
    private KerbalAttributes _kerbalAttributes;
    private KerbalLocationInfo _location;
    public double EnrollmentUT;
    [JsonIgnore]
    public const KerbalInfo.KerbalMPFlag DEFAULT_KERBAL_MP_FLAGS = KerbalInfo.KerbalMPFlag.None;
    [JsonIgnore]
    private KerbalInfo.KerbalMPFlag _kerbalMPFlags;

    public string NameKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public IGGuid Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string PlayerGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetPlayerGuidString(string playerGuidString) => throw null;

    [JsonIgnore]
    public KerbalAttributes Attributes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Sprite Portrait
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public KerbalLocationInfo Location
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SetLocation(IGGuid simObjectId, IGGuid secondaryId, int positionIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetKerbalMPFlagsString(KerbalInfo.KerbalMPFlag kerbalMPFlag) => throw null;

    [JsonIgnore]
    public KerbalInfo.KerbalMPFlag KerbalMPFlags
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetKerbalMPFlagsString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetKerbalMPFlags(KerbalInfo.KerbalMPFlag kerbalMPFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableKerbalMPFlags(KerbalInfo.KerbalMPFlag kerbalMPFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableKerbalMPFlags(KerbalInfo.KerbalMPFlag kerbalMPFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreAllKerbalMPFlagsEnabled(KerbalInfo.KerbalMPFlag kerbalMPFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreAllKerbalMPFlagDisabled(KerbalInfo.KerbalMPFlag kerbalMPFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreSomeKerbalMPFlagsEnabled(KerbalInfo.KerbalMPFlag kerbalMPFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreSomeKerbalMPFlagsDisabled(KerbalInfo.KerbalMPFlag kerbalMPFlags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreSomeKerbalMPFlagsDisabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreAllKerbalMPFlagsDisabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableKerbalMPFlags(KerbalInfo.KerbalMPFlag kerbalMPFlags, bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo(SerializedKerbalInfo serializedKerbal, string kerbalGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private KerbalInfo(double enrollmentUT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo(double enrollmentUT, KerbalAttributes attributes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalInfo(double enrollmentUT, string predefinedJSONData = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetCareerLength(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string Serialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KerbalInfo Deserialize(string inputJson) => throw null;

    [Flags]
    public enum KerbalMPFlag : byte
    {
      None = 0,
      IgnoreAddKerbalEvent = 1,
      IgnoreRemoveKerbalEvent = 2,
      IgnoreLocationChangedEvent = 4,
    }
  }
}
