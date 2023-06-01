// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ICameraShot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Sim
{
  public interface ICameraShot
  {
    Position CameraPosition { get; }

    Rotation CameraRotation { get; }

    Vector CameraForward { get; }

    Vector CameraUp { get; }

    bool IsOrthographic { get; }

    double FieldOfView { get; }

    double OrthographicSize { get; }
  }
}
