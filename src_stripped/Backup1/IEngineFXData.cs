// Decompiled with JetBrains decompiler
// Type: IEngineFXData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using UnityEngine;

public interface IEngineFXData
{
  Action<float, float, float, Vector3> TriggerUpdateVisuals { get; set; }

  void ToggleVisibility(bool doTurnOn, ParticleSystemStopBehavior stopBehaviour = ParticleSystemStopBehavior.StopEmitting);

  bool IsVisible();
}
