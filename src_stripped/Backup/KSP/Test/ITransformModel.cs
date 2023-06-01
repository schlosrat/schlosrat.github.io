// Decompiled with JetBrains decompiler
// Type: KSP.Test.ITransformModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
