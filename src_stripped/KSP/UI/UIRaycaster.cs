// Decompiled with JetBrains decompiler
// Type: KSP.UI.UIRaycaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace KSP.UI
{
  public static class UIRaycaster
  {
    private static List<RaycastResult> _currentRaycastResults;
    private static int _lastFrame;
    private static PointerEventData _pointerData;
    private static List<RaycastResult> _pointerPositionRaycastResults;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<RaycastResult> GetCurrentRaycastResults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<RaycastResult> GetRaycastResultsWithPointerPosition(Vector2 pointerPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UpdateRaycastData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsAnyUIHovered(string tagToCheck = null, bool checkParents = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static UIRaycaster() => throw null;
  }
}
