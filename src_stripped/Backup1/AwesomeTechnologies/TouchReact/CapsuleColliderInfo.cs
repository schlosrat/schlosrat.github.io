// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.TouchReact.CapsuleColliderInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.TouchReact
{
  [Serializable]
  public class CapsuleColliderInfo
  {
    public float Radius;
    public float Height;
    public Mesh CapsuleColliderMesh;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CapsuleColliderInfo() => throw null;
  }
}
