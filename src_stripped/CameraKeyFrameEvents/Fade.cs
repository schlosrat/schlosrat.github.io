// Decompiled with JetBrains decompiler
// Type: CameraKeyFrameEvents.Fade
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraKeyFrameEvents
{
  public class Fade : CameraKeyFrameEvent
  {
    public float fadeDuration;
    public Color T0;
    public Color T1;
    public CameraFade fadeController;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RunEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Fade() => throw null;
  }
}
