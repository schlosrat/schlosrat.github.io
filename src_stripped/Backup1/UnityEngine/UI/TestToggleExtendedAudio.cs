// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.TestToggleExtendedAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [RequireComponent(typeof (ToggleExtended))]
  public class TestToggleExtendedAudio : MonoBehaviour
  {
    [Header("If preset is set, will use its identifier value")]
    public TestUIAudioIdentifierPreset identifierPreset;
    [Header("If no preset is set, will use this identifier:")]
    public string identifier;
    private ToggleExtended toggle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleStateTransitionWithOverrides(SelectionState state, bool instant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void HandleUITransitionForAudio(
      string identifier,
      SelectionState state,
      bool isOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestToggleExtendedAudio() => throw null;
  }
}
