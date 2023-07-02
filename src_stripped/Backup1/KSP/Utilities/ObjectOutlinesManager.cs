// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.ObjectOutlinesManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
