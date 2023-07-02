// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.MeshExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility
{
  public static class MeshExtension
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Mesh GetSubmesh(this Mesh aMesh, int aSubMeshIndex) => throw null;

    private class Vertices
    {
      private List<Vector3> verts;
      private List<Vector2> uv1;
      private List<Vector2> uv2;
      private List<Vector2> uv3;
      private List<Vector2> uv4;
      private List<Vector3> normals;
      private List<Vector4> tangents;
      private List<Color32> colors;
      private List<BoneWeight> boneWeights;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vertices() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vertices(Mesh aMesh) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private List<T> CreateList<T>(T[] aSource) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void Copy<T>(ref List<T> aDest, List<T> aSource, int aIndex) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Add(MeshExtension.Vertices aOther, int aIndex) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AssignTo(Mesh aTarget) => throw null;
    }
  }
}
