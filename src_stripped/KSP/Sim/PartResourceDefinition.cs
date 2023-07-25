// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PartResourceDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  [Serializable]
  public class PartResourceDefinition
  {
    [SerializeField]
    public string _name;
    [SerializeField]
    public string _displayName;
    [SerializeField]
    public float _density;
    [SerializeField]
    public float _volume;
    [SerializeField]
    public string _abbreviation;
    [SerializeField]
    public float _unitCost;
    [SerializeField]
    public float _specificHeatCapacity;
    [SerializeField]
    public Color _color;
    [SerializeField]
    public ResourceType _type;
    [SerializeField]
    public ResourceFlowMode _resourceFlowMode;
    [SerializeField]
    public ResourceTransferMode _resourceTransferMode;
    [SerializeField]
    public bool _isTweakable;
    public bool _isVisible;

    public string name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string displayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float density
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float volume
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string abbreviation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float unitCost
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float specificHeatCapacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceType type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceFlowMode resourceFlowMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ResourceTransferMode resourceTransferMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool isTweakable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool isVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartResourceDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartResourceDefinition(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartResourceDefinition(string name, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetShortName(int length = 2) => throw null;
  }
}
