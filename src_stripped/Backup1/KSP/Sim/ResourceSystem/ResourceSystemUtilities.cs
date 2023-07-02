// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceSystemUtilities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Logging;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public static class ResourceSystemUtilities
  {
    public const double RUNTIME_TOLERANCE = 1E-08;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ReportOrThrow(
      ResourceSystemUtilities.ErrorReportMode nonSilentErrorReportMode,
      string msg)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ReportOrThrow(
      ResourceSystemUtilities.ErrorReportMode nonSilentErrorReportMode,
      LogFilter logFilter,
      string msg)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static string SanitizeNameString(string resourceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Clamp(double value, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int NextPowerOf2(int number) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EnsureListIsLargeEnough<T>(List<T> list, int requestedIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EnsureArrayIsLargeEnough<T>(ref T[] array, int requestedIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SetWithDirty<T>(ref T field, T value, ref bool dirtyField) => throw null;

    public enum ErrorReportMode
    {
      Silent,
      Log,
      LogWarning,
      LogError,
      ThrowException,
    }

    public sealed class RefComparer<T> : IEqualityComparer<T>
    {
      public static ResourceSystemUtilities.RefComparer<T> Instance
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool Equals(T lhs, T rhs) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int GetHashCode(T value) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public RefComparer() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static RefComparer() => throw null;
    }

    public class ResourceSystemException : Exception
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ResourceSystemException(string msg) => throw null;
    }
  }
}
