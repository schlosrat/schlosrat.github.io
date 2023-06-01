// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraManagerUpdatedUnityTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CameraManagerUpdatedUnityTransform", false, "The Camera Manager has updated in response to a floating origin reset", "")]
  public class CameraManagerUpdatedUnityTransform : CameraMessageBase
  {
    public CameraID UpdatedCameraID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraManagerUpdatedUnityTransform() => throw null;
  }
}
