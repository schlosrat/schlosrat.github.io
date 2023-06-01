// Decompiled with JetBrains decompiler
// Type: PqsObjectState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PqsObjectState
{
  public Vector2 LatLong;
  public Vector3 RotationEuler;
  public float Rotation;
  public float VerticalOffset;
  public Vector3 LocalScale;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PqsObjectState() => throw null;
}
