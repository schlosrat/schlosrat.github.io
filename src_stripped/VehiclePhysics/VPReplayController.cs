// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPReplayController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [RequireComponent(typeof (VPReplay))]
  [AddComponentMenu("Vehicle Physics/Replay/Replay Controller")]
  public class VPReplayController : MonoBehaviour
  {
    public bool enableShortcuts;
    public KeyCode recordKey;
    public KeyCode playPauseKey;
    public KeyCode forwardKey;
    public KeyCode rewindKey;
    public KeyCode quitKey;
    public KeyCode saveReplayKey;
    public KeyCode togglePanelKey;
    [Space(5f)]
    public bool showPanel;
    public bool autoShowHide;
    [FormerlySerializedAs("faskPlaybackFrames")]
    public int fastPlaybackFrames;
    public float fastSkipTime;
    [Space(5f)]
    public VPReplayAsset predefinedReplay;
    public string saveReplayFileName;
    [Space(5f)]
    public Vector2 screenPosition;
    public Font font;
    private VPReplay m_replay;
    private VPReplay.State m_prevState;
    private string m_lastSavedReplayFile;
    private GUIStyle m_timeStyle;
    private GUIStyle m_bigStyle;

    public VPReplay replay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetStateStr() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CenteredLabel(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReplayKey() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecordKey(VPReplay.RecordMode recordModeAtReplay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayPauseKey() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForwardKey() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RewindKey() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void QuitKey() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPReplayController() => throw null;
  }
}
