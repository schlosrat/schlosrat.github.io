// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Node
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies
{
  [Serializable]
  public class Node
  {
    public bool Selected;
    public Vector3 Position;
    public bool OverrideWidth;
    public float CustomWidth;
    public bool Active;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Node() => throw null;
  }
}
