// Decompiled with JetBrains decompiler
// Type: KSP.Test.ITransformModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Collections.Generic;

namespace KSP.Test
{
  public interface ITransformModel
  {
    SimulationObjectModel objectModel { get; }

    ITransformFrame bodyFrame { get; }

    ITransformFrame celestialFrame { get; }

    ITransformFrame parent { get; }

    IEnumerable<ITransformModel> children { get; }

    void SetParent(ITransformFrame newParent);

    Vector3d localPosition { get; set; }

    QuaternionD localRotation { get; set; }

    Vector3d GetYourPositionInMyParentSpace(ITransformModel you);

    Vector3d up { get; }

    Vector3d down { get; }

    Vector3d forward { get; }

    Vector3d back { get; }

    Vector3d left { get; }

    Vector3d right { get; }

    QuaternionD rotation { get; }
  }
}
