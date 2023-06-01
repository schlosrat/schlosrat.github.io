// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Driveline
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class Driveline
  {
    public Driveline.Settings settings;
    public Differential.Settings axleDifferential;
    public Differential.Settings centerDifferential;
    public Differential.Settings interAxleDifferential;
    public TorqueSplitter.Settings torqueSplitter;
    private Driveline.Override m_differentialOverride;
    private Differential.Type m_differentialType;
    private Driveline.Override m_drivelineOverride;
    private Differential.Type m_drivelineDifferentialType;
    private float m_torqueSplitterStiffness;
    private Differential[] m_detachableAxleDifferentials;
    private Differential.Settings m_openDifferential;

    public Driveline.Override differentialOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Driveline.Override drivelineOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDetachableDifferentials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAxleFinalRatio(int axle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetSingleAxleFinalRatio(int axle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetTwoAxlesFinalRatio(int axle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetThreeAxlesFinalRatio(int axle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetFourAxlesFinalRatio(int axle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupDriveline(Wheel[] wheels, Block powerTrainOutput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSingleAxleDriveline(Wheel[] wheels, Block powerTrainOutput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupTwoAxlesDriveline(Wheel[] wheels, Block powerTrainOutput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupThreeAxlesDriveline(Wheel[] wheels, Block powerTrainOutput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupFourAxlesDriveline(Wheel[] wheels, Block powerTrainOutput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Driveline() => throw null;

    public enum DrivenAxles
    {
      None,
      SingleAxle,
      TwoAxles,
      ThreeAxles,
      FourAxles,
    }

    public enum TwoAxlesConfig
    {
      CenterDifferential,
      TorqueSplitter,
      HDrive,
    }

    public enum ThreeAxlesConfig
    {
      HDriveAndCenterDifferential,
      HDriveAndTorqueSplitterAtLinkedAxles,
      HDriveAndTorqueSplitterAtIndependentAxle,
    }

    public enum FourAxlesConfig
    {
      DualInterAxleAndCenterDifferential,
      DualInterAxleDifferentialAndTorqueSplitter,
      DualHDriveAndCenterDifferential,
      DualHDriveAndTorqueSplitter,
      FullHDrive,
    }

    public enum Override
    {
      None,
      ForceLocked,
      ForceUnlocked,
    }

    [Serializable]
    public class Settings
    {
      public Driveline.DrivenAxles drivenAxles;
      public int firstDrivenAxle;
      public int secondDrivenAxle;
      public int thirdDrivenAxle;
      public int fourthDrivenAxle;
      public Driveline.TwoAxlesConfig twoDrivenAxlesConfig;
      public Driveline.ThreeAxlesConfig threeDrivenAxlesConfig;
      public Driveline.FourAxlesConfig fourDrivenAxlesConfig;
      [Range(0.0f, 1f)]
      public float efficiency;

      public bool hasInterAxleDifferential
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public bool hasCenterDifferential
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public bool hasTorqueSplitter
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
