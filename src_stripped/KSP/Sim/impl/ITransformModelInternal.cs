// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ITransformModelInternal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;

namespace KSP.Sim.impl
{
  public interface ITransformModelInternal : 
    ITransformModel,
    IStringIdentity,
    IPositionDriver,
    IRotationDriver
  {
    ITransformFrameInternal _parentInternal { get; }

    List<ITransformFrameInternal> parentageCache { get; }

    bool parentageCacheDirty { get; set; }

    void AddChild(ITransformModel youngChild);

    void RemoveChild(ITransformModel oldChild);
  }
}
