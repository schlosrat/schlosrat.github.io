// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AttachNodeRing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class AttachNodeRing
  {
    public string RingName;
    public int RingNodeCountMin;
    public int RingNodeCountDefault;
    public int RingNodeCountMax;
    public float RingNodeDistanceMin;
    public float RingNodeDistanceMax;
    public float RingNodeDistanceDefault;
    public int RingNodeSizeMin;
    public int RingNodeSizeMax;
    public int RingNodeSizeDefault;
    private int _ringNodeCountCurrent;
    private float _ringNodeDistanceCurrent;
    private int _ringNodeSizeCurrent;
    public List<AttachNodeDefinition> GeneratedAttachNodes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentNodeCount(int currentCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentNodeDistance(float currentDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCurrentNodeSize(int currentSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateAttachNodes(Quaternion orientation, Vector3 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeRing() => throw null;
  }
}
