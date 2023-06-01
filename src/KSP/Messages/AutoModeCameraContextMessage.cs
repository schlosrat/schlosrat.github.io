// Decompiled with JetBrains decompiler
// Type: KSP.Messages.AutoModeCameraContextMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/AutoModeCameraContextMessage", false, "The camera context used when being set in auto-mode.", "")]
  public class AutoModeCameraContextMessage : CameraMessageBase
  {
    public FlightCameraContext FlightCameraContext;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AutoModeCameraContextMessage() => throw null;
  }
}
