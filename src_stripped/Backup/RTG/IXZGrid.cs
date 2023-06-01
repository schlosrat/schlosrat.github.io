// Decompiled with JetBrains decompiler
// Type: RTG.IXZGrid
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IXZGrid
  {
    Plane WorldPlane { get; }

    Matrix4x4 WorldMatrix { get; }

    XZGridCell CellFromWorldPoint(Vector3 worldPoint);

    bool Raycast(Ray ray, out float t);
  }
}
