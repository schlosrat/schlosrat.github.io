// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.MeshRendererRaycastInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  public class MeshRendererRaycastInfo
  {
    public MeshRenderer MeshRenderer;
    public Mesh Mesh;
    public Matrix4x4 LocalToWorldMatrix4X4;
    public Bounds Bounds;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshRendererRaycastInfo() => throw null;
  }
}
