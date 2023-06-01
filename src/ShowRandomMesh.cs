// Decompiled with JetBrains decompiler
// Type: ShowRandomMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[DisableCustomEditorBase]
public class ShowRandomMesh : MonoBehaviour
{
  [SerializeField]
  private Renderer[] meshesToChooseFrom;
  [SerializeField]
  private Renderer overrideMesh;
  private Renderer randomindexMesh;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DeleteAllMeshesExcept(Renderer meshToKeep, Renderer[] listOfMeshes) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ShowRandomMesh() => throw null;
}
