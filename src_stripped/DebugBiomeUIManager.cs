// Decompiled with JetBrains decompiler
// Type: DebugBiomeUIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugBiomeUIManager : MonoBehaviour
{
  public GameObject goUIRoot;
  public GameObject listElementPrefab;
  public Transform listRoot;
  private List<DebugBiomeUIElement> elements;
  public List<DebugBiomeMapping> mappingElements;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetData(PQSData data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Color GetColor(PQSData.KSP2BiomeType type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Activate(PQSData data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DeActivate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugBiomeUIManager() => throw null;
}
