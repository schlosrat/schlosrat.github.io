// Decompiled with JetBrains decompiler
// Type: DebugBiomeUIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
