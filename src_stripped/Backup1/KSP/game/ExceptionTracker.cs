// Decompiled with JetBrains decompiler
// Type: KSP.Game.ExceptionTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  internal class ExceptionTracker : KerbalMonoBehaviour
  {
    private static bool _muteExceptionReporting;
    private static bool _flightHUDHidden;
    private static int _numExceptionsTracked;
    private GUIStyle _reportStyle;

    public static int NumExceptionsTracked
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ToggleErrorsAndExceptionsDisplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnFlightHUDToggled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExceptionTracker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ExceptionTracker() => throw null;
  }
}
