// Decompiled with JetBrains decompiler
// Type: KSP.game.PartsManagerFakePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Modules;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.game
{
  public class PartsManagerFakePart : KerbalMonoBehaviour
  {
    [Header("Parts Manager Config")]
    [SerializeField]
    private PartsManagerCore _partsManager;
    [SerializeField]
    [Header("Debug Buttons")]
    private Button _doAdd;
    [SerializeField]
    private Button _doScramble;
    [SerializeField]
    private Button _doScrambleMetadata;
    [SerializeField]
    private Button _doEnableToggle;
    [SerializeField]
    [Header("Debug Modules")]
    private Module_Drag _moduleDrag;
    [SerializeField]
    private Module_Parachute _moduleParachute;
    [SerializeField]
    private Module_Engine _moduleEngines;
    private PartsManagerFakePart.TestPart _part;
    private bool _entriesEnabled;
    private readonly string[] randStringOptions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddTestPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScrambleData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableOrDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScrambleMetadata() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string RandString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartsManagerFakePart() => throw null;

    public class TestPart : IInteractivePart
    {
      public DictionaryValueList<System.Type, IPartModule> PartModulesUnderlying;

      public AssemblyPartStageType PartStageType
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string Name
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public IGGuid Guid
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public DictionaryValueList<System.Type, IPartModule> Modules
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public PartCategories Category
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void DestroyInteractivePart() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetCategoryName() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string GetDisplayName() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TestPart() => throw null;
    }
  }
}
