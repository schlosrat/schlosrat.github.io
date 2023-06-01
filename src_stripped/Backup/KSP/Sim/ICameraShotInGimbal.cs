// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ICameraShotInGimbal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Sim
{
  public interface ICameraShotInGimbal : ICameraShot
  {
    GimbalState GimbalState { get; }

    ITransformFrame GimbalFrame { get; }

    Position GimbalPosition { get; }

    Rotation GimbalRotation { get; }

    Vector GimbalAxis { get; }
  }
}
