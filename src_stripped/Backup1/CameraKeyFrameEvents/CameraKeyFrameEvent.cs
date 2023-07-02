// Decompiled with JetBrains decompiler
// Type: CameraKeyFrameEvents.CameraKeyFrameEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
