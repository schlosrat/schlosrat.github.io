// Decompiled with JetBrains decompiler
// Type: ShowRandomMeshByKerbalType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisableCustomEditorBase]
public class ShowRandomMeshByKerbalType : MonoBehaviour
{
  [HideInInspector]
  public KerbalType chosenType;
  [Tooltip("Point this Component to the one that you want to actually choose the type for this Kerbal.")]
  public ShowRandomMeshByKerbalType parentSRMBKT;
  [SerializeField]
  private Renderer[] meshesToChooseFromCircle;
  [SerializeField]
  private Renderer[] meshesToChooseFromSquare;
  [Space(10f)]
  [SerializeField]
  private Renderer overrideMesh;
  private Renderer randomindexMesh;
  private bool hasInit;
  protected static System.Random StaticRandomizer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator MeshPickerCoroutine() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float GetNextRandomFloat() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PickRandomType() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PickMeshByType(KerbalType kerbalType) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void HideAllMeshesExcept(Renderer meshToKeep, Renderer[] listOfMeshes) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ShowRandomMeshByKerbalType() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static ShowRandomMeshByKerbalType() => throw null;
}
