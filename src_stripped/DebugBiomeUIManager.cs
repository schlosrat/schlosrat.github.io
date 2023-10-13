// Decompiled with JetBrains decompiler
// Type: DebugBiomeUIManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
