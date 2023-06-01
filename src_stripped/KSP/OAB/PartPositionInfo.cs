// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PartPositionInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [Serializable]
  public class PartPositionInfo
  {
    public Vector3 partPositionWhenGrabbed;
    public Vector3 partPlanePositionWhenGrabbed;
    public Vector3 partPositionOffsetFromMouse;
    public Quaternion partRotationWhenGrabbed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartPositionInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;
  }
}
