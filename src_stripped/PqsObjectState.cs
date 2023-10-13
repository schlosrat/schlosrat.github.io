// Decompiled with JetBrains decompiler
// Type: PqsObjectState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
  public string RegionId;
  public Vector3 RegionBoundsOffset;
  public float RegionRadius;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PqsObjectState() => throw null;
}
