﻿// Decompiled with JetBrains decompiler
// Type: CameraKeyFrameEvents.CameraKeyFrameEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraKeyFrameEvents
{
  public class CameraKeyFrameEvent : MonoBehaviour
  {
    public float timeIntoFrame;
    public bool done;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RunEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraKeyFrameEvent() => throw null;
  }
}
