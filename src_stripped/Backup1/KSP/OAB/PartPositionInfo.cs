// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PartPositionInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
