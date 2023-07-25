// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceFlowRequestHandle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  [DebuggerDisplay("{ToString()}")]
  [Serializable]
  public readonly struct ResourceFlowRequestHandle : 
    IEquatable<ResourceFlowRequestHandle>,
    IComparable<ResourceFlowRequestHandle>
  {
    public const uint INVALID_ID_VALUE = 0;
    public static readonly ResourceFlowRequestHandle InvalidID;
    public readonly uint ID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestHandle(uint id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestHandle(ResourceFlowRequestHandle other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(ResourceFlowRequestHandle other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CompareTo(ResourceFlowRequestHandle other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator ==(ResourceFlowRequestHandle lhs, ResourceFlowRequestHandle rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool operator !=(ResourceFlowRequestHandle lhs, ResourceFlowRequestHandle rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ResourceFlowRequestHandle() => throw null;
  }
}
