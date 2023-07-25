// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ProceduralPartDefinitionID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  [DebuggerDisplay("{ToString()}")]
  [Serializable]
  public readonly struct ProceduralPartDefinitionID : 
    IEquatable<ProceduralPartDefinitionID>,
    IComparable<ProceduralPartDefinitionID>
  {
    public const ushort INVALID_ID_VALUE = 0;
    public static readonly ProceduralPartDefinitionID InvalidID;
    public readonly ushort Value;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralPartDefinitionID(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(ProceduralPartDefinitionID other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(ProceduralPartDefinitionID other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(ProceduralPartDefinitionID lhs, ProceduralPartDefinitionID rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(ProceduralPartDefinitionID lhs, ProceduralPartDefinitionID rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ProceduralPartDefinitionID() => throw null;
  }
}
