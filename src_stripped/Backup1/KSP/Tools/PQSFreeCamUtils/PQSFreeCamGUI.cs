// Decompiled with JetBrains decompiler
// Type: KSP.Tools.PQSFreeCamUtils.PQSFreeCamGUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Tools.PQSFreeCamUtils
{
  [RequireComponent(typeof (PQSFreeCam))]
  public class PQSFreeCamGUI : MonoBehaviour
  {
    private const float GUI_FLOAT_COMPARISON_TOLERANCE = 0.0001f;
    private const string BENCHMARK_CONFIG_FOLDER = "data";
    private const string BENCHMARK_CONFIG_SUFFIX = "_benchmark_config.asset";
    public bool showGUI;
    public bool showStats;
    public bool showControls;
    public bool showWarp;
    public bool showBookmarks;
    public bool showBenchmarkNodes;
    public bool drawWireframe;
    public bool showContextualVFXTesting;
    private Vector2 scrollPos;
    private const string PREFS_PATH = "AnyScene.PQSTestScene.FreeCamGUI";
    private const string PREFS_SHOW_STATS = "AnyScene.PQSTestScene.FreeCamGUI.showStats";
    private const string PREFS_SHOW_CONTROLS = "AnyScene.PQSTestScene.FreeCamGUI.showControls";
    private const string PREFS_SHOW_WARP = "AnyScene.PQSTestScene.FreeCamGUI.showWarp";
    private const string PREFS_SHOW_BOOKMARKS = "AnyScene.PQSTestScene.FreeCamGUI.showBookmarks";
    private const string PREFS_SHOW_BENCHMARK_NODES = "AnyScene.PQSTestScene.FreeCamGUI.showBenchmarkNodes";
    private const string PREFS_SCROLLPOS = "AnyScene.PQSTestScene.FreeCamGUI.scrollPos";
    private const string PREFS_LIVEMODE = "AnyScene.PQSTestScene.FreeCamGUI.liveMode";
    private const string PREFS_CONTEXTUAL_TESTING = "AnyScene.PQSTestScene.FreeCamGUI.contextualTesting";
    private PQSFreeCam freeCam;
    private RenderWireframe wireframeRenderer;
    private PQSFreeCamState queuedState;
    private bool liveMode;
    private float liveModeUpdateCooldown;
    private const float liveModeUpdateDelay = 0.1f;

    public bool IsMouseOverGUI
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateInputGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DrawGUILine(string label, string data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUIDrawStats() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUIDrawControls() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGuiDrawWarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUIDrawBookmarks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUIDrawWireframeToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShootTerrainColliderRay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool FloatSliderField(
      ref float value,
      float min,
      float max,
      int sigFigs,
      float reset = 0.0f,
      float exponent = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float ValueToLog01(float val, float exp, float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float Log01ToValue(float log01, float exp, float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSFreeCamGUI() => throw null;

    private class GUIColorScope : GUI.Scope
    {
      private Color guiColor;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GUIColorScope(Color color) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      protected override void CloseScope() => throw null;
    }
  }
}
