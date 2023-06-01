// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.TouchReact.CapsuleColliderInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
