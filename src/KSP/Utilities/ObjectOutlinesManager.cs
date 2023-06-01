// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.ObjectOutlinesManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.OAB;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Utilities
{
  public class ObjectOutlinesManager : KerbalMonoBehaviour
  {
    public bool OutlineDisabledRenderers;
    public bool FilterGameObjectsByName;
    public List<string> GameObjectNameFilterWords;
    public int LayerId;
    public Color[] lineColors;
    protected readonly HashSet<Outline> _outlined;
    protected readonly HashSet<GameObject> _outlinedObjects;
    private readonly List<Renderer> _rendererSearchStorage;

    public string LayerName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLayer(string layerName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool DoesNameContain(GameObject gameObject, IEnumerable<string> patternsToCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOutlineToPart(PartBehavior part, int colorIndex = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOutlineToOABPart(
      IObjectAssemblyPart part,
      bool includeChildParts,
      int colorIndex = 0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddOutlineToObject(GameObject objectToOutline, int colorIndex = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearOutlines() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectOutlinesManager() => throw null;
  }
}
