// Decompiled with JetBrains decompiler
// Type: VersionedBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

public abstract class VersionedBase
{
  [JsonProperty("VersionString", Order = -2)]
  private string _versionString;
  [JsonIgnore]
  private Version _version;

  [JsonIgnore]
  protected abstract string CurrentVersionString
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected VersionedBase(string versionString) => throw null;

  [JsonIgnore]
  public string VersionString
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [JsonIgnore]
  public int MajorVersion
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [JsonIgnore]
  public int MinorVersion
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [JsonIgnore]
  public int Revision
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [JsonIgnore]
  public int Build
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [OnDeserialized]
  [MethodImpl(MethodImplOptions.NoInlining)]
  internal void OnDeserializingMethod(StreamingContext context) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Equals(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Equals(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool EqualsMajorVersionOf(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool EqualsMajorVersionOf(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool EqualsMinorVersionOf(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool EqualsMinorVersionOf(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool EqualsRevisionVersionOf(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool EqualsRevisionVersionOf(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool EqualsBuildVersionOf(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool EqualsBuildVersionOf(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareTo(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareTo(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareMajorVersionTo(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareMajorVersionTo(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareMinorVersionTo(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareMinorVersionTo(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareRevisionVersionTo(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareRevisionVersionTo(Version other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareBuildVersionTo(VersionedBase other) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int CompareBuildVersionTo(Version other) => throw null;
}
