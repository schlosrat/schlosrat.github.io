// Decompiled with JetBrains decompiler
// Type: ShowRandomMesh
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
