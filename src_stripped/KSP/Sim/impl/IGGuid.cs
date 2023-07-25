// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.IGGuid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Networking.MP.Utils;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public struct IGGuid : IComparable<IGGuid>, IEquatable<IGGuid>, IEquatable<Guid>
  {
    private static GuidGenerationMode gGuidGenerationMode;
    private static MPGUIDGenerator gMPGUIDGenerator;
    public static readonly IGGuid Empty;
    private Guid _guid;

    public static GuidGenerationMode GuidGenerationMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static MPGUIDGenerator MPGUIDGenerator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IGGuid(Guid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryParse(string guidStringPlusDebugName, out IGGuid globalIdOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IGGuid CreateIGGuidByName(string fixedName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IGGuid CreateIGGuid(string guidStringPlusDebugName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGuid(Guid guid) => throw null;

    public Guid Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string DebugName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [Conditional("DEBUG")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDebugName(string debugName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public bool IsDefault() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GotoGuidGenerationMode(GuidGenerationMode guidGenerationMode, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IGGuid NewGuid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static implicit operator Guid(IGGuid g) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static explicit operator IGGuid(Guid g) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(IGGuid a, IGGuid b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(IGGuid a, IGGuid b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(IGGuid otherGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(IGGuid other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(Guid other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool FromLegacyGuid(string legacyGuid, out IGGuid newGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static IGGuid() => throw null;
  }
}
