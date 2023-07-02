// Decompiled with JetBrains decompiler
// Type: CelestialHierarchyDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using System.Text;
using TMPro;
using UnityEngine;

public class CelestialHierarchyDisplay : MonoBehaviour
{
  public TMP_Text text;
  [Range(1f, 30f)]
  public float fontsize;
  [Range(1f, 12f)]
  public int indentSize;
  [Header("hide branches that don't contain simobjects")]
  public bool onlyShowSimObjBranches;
  [Space]
  public bool showPhysicsMode;
  private UniverseView universeView;
  private static readonly string simObjPrefix;
  private static readonly string simplePrefix;
  private static readonly string logTag;

  private bool IsConnected
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private IUniverseModel UniverseModel
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private IPhysicsSpaceProvider PhysicsSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private IScaledSpaceProvider ScaledSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private string GetIndent(int indent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool HasSimObjectChildren(ITransformModel transform) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PrintHierarchy(ITransformModel transform, StringBuilder str, string prefix) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CheckUniverseConnection() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public CelestialHierarchyDisplay() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static CelestialHierarchyDisplay() => throw null;
}
