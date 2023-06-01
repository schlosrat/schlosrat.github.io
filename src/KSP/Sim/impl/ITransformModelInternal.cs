// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ITransformModelInternal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
