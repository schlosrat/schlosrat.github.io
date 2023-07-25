// Decompiled with JetBrains decompiler
// Type: LayerValidator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Inspector;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LayerValidator : MonoBehaviour
{
  [RequirePrefab]
  [SerializeField]
  private ValidationDisplay displayPrefab;
  private ValidationDisplay displayInstance;
  [Range(1f, 30f)]
  public float fontsize;
  [Range(1f, 12f)]
  public int indentSize;
  private const int layerFlagCount = 32;
  private Dictionary<int, LayerValidator.LayerData> instanceLayerData;
  private int[] objectLayersFound;
  private Dictionary<int, int> cameraLayersFound;
  private Dictionary<int, int> lightLayersFound;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateLayerCountsFromMask(ref int[] layerCounts, int layerMask) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PollLayerData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void FillLayerData(GameObject obj, out LayerValidator.LayerData data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateDisplayCache() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateDisplayText() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string GetIndent(int indent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public LayerValidator() => throw null;

  private struct LayerData
  {
    public int layer;
    public int? camLayerMask;
    public int? lightLayerMask;
    public int changeCount;
  }
}
