﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.AutoModeCameraContextMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/AutoModeCameraContextMessage", false, "The camera context used when being set in auto-mode.", "")]
  public class AutoModeCameraContextMessage : CameraMessageBase
  {
    public string CameraName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AutoModeCameraContextMessage() => throw null;
  }
}