// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraModeKeyMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CameraModeKeyMessage", false, "The basic camera rig updates the camera mode.", "")]
  public class CameraModeKeyMessage : CameraMessageBase
  {
    public string CameraMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraModeKeyMessage() => throw null;
  }
}
