﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DrivelineHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class DrivelineHelper
  {
    public DrivelineHelper.Settings settings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Driveline.Settings GetDrivelineSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Differential.Settings GetAxleDifferentialSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Differential.Settings GetCenterDifferentialSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrivelineHelper() => throw null;

    public enum DriveWheels
    {
      Rear,
      Front,
      AllWheel,
    }

    public enum DifferentialType
    {
      Open,
      LimitedSlip,
      Locked,
    }

    public enum TransferCase
    {
      Open,
      Locked,
    }

    [Serializable]
    public class Settings
    {
      public DrivelineHelper.DriveWheels driveWheels;
      public DrivelineHelper.DifferentialType differentialType;
      public float limitedSlipRatio;
      public float finalRatio;
      public DrivelineHelper.TransferCase transferCase;
      public float transferCaseRatio;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
