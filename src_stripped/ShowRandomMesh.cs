// Decompiled with JetBrains decompiler
// Type: ShowRandomMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
