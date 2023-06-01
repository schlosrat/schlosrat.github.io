// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IPhysicsOwner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Sim
{
  public interface IPhysicsOwner
  {
    PhysicsMode Physics { get; }

    event Action<PhysicsMode> PhysicsChanged;

    void SetModelPhysicsMode(PhysicsMode physics);
  }
}
