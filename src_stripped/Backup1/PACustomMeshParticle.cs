// Decompiled with JetBrains decompiler
// Type: PACustomMeshParticle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PACustomMeshParticle : PACustomParticle
{
  public Vector3 spinAxis;
  public Mesh mesh;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PACustomMeshParticle() => throw null;
}
