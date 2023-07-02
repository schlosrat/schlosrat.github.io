// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.MeshRendererRaycastInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
