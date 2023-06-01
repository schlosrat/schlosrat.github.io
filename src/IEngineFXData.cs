// Decompiled with JetBrains decompiler
// Type: IEngineFXData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using UnityEngine;

public interface IEngineFXData
{
  Action<float, float, float, Vector3> TriggerUpdateVisuals { get; set; }

  void ToggleVisibility(bool doTurnOn, ParticleSystemStopBehavior stopBehaviour = ParticleSystemStopBehavior.StopEmitting);

  bool IsVisible();
}
