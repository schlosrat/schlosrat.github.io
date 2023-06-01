// Decompiled with JetBrains decompiler
// Type: KSPPartAudioManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Rendering.Planets;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPPartAudioManager
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPPartAudioManager(GameObject gameObject) => throw null;

  public KSPPartAudio PartAudio
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public KSPPartEngineAudio PartEngineAudio
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public KSPPartGeneratorAudio PartGeneratorAudio
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public KSPPartWheelAudio PartWheelAudio
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public KSPPartParachuteAudio PartParachuteAudio
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  public KSPPartCoolingAudio PartCoolingAudio
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PostEvent(KSPPartAudioBase.PartAudioEvent audioEvent) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PostActivationEvent(System.Type type, bool active) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SwitchBiomeAudio(bool isTerrainCollision, PQSData.KSP2BiomeType Biome) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitEngineModuleAudio() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void InitDecoupleModuleAudio() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void DestroyPart() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HandleCollisionAudio(bool isTerrainCollision, Vector3 relativeVelocity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HandleCollisionStay(bool isTerrainCollision, Vector3 relativeVelocity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void HandleCollisionExit(bool isTerrainCollision) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnJointBreak() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetWheelOnGround(bool isOnGround) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetWheelBrakeValue(float breakValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetWheelDisplacementValue(float displacementValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnParachuteDeploymentStateChanged(Data_Parachute.DeploymentStates newState) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnFairingDeploy(int numberOfPanels) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPartDocked() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnPartUndocked() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnShowHeatIndicator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnHideHeatIndicator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnLightTurnedOn() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnLightTurnedOff() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnTransfertStart(bool isInbound) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnTransfertStop(bool isInbound) => throw null;
}
