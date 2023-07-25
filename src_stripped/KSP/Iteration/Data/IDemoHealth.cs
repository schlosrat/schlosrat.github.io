// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.Data.IDemoHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.Generic;
using System;

namespace KSP.Iteration.Data
{
  public interface IDemoHealth
  {
    event Action LifeLost;

    event Action LifeGained;

    IProperty<int> MaxLives { get; }

    IProperty<int> CurLives { get; }

    IProperty<bool> IsDead { get; }

    void Revive();

    void Kill();

    void Hurt();

    void Heal();
  }
}
