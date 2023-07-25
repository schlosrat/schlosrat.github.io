// Decompiled with JetBrains decompiler
// Type: CameraKeyFrameEvents.SceneTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace CameraKeyFrameEvents
{
  public class SceneTransition : CameraKeyFrameEvent
  {
    public GameScenes destination;
    public bool Test;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RunEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneTransition() => throw null;
  }
}
