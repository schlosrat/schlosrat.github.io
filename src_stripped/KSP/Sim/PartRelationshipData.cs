// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PartRelationshipData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public struct PartRelationshipData : IEquatable<PartRelationshipData>
  {
    [Obsolete("Use HostPartGuid instead")]
    public string hostPartGuid;
    [Obsolete("Use TargetPartGuid instead")]
    public string targetPartGuid;
    public IGGuid HostPartGuid;
    public IGGuid TargetPartGuid;
    public PartRelationshipType relationshipType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartRelationshipData(
      IGGuid hostPartGuid,
      IGGuid targetPartGuid,
      PartRelationshipType relationshipType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(PartRelationshipData other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartRelationshipData ConvertLegacyGuids() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartRelationshipData UpdateGuids(IGGuid oldGuid, IGGuid newGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(PartRelationshipData lhs, PartRelationshipData rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(PartRelationshipData lhs, PartRelationshipData rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PartRelationshipData Defaults() => throw null;
  }
}
