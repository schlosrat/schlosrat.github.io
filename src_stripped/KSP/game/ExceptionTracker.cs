// Decompiled with JetBrains decompiler
// Type: KSP.Game.ExceptionTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
