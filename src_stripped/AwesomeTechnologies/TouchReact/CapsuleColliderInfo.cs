// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.TouchReact.CapsuleColliderInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
