// Decompiled with JetBrains decompiler
// Type: RTG.Hotkeys
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class Hotkeys
  {
    private static List<KeyCode> _availableKeys;
    private static List<string> _availableKeyNames;
    private const int _maxNumberOfKeys = 2;
    [SerializeField]
    private bool _isEnabled;
    [SerializeField]
    private KeyCode _key;
    [SerializeField]
    private bool _lCtrl;
    [SerializeField]
    private bool _lCmd;
    [SerializeField]
    private bool _lAlt;
    [SerializeField]
    private bool _lShift;
    [SerializeField]
    private bool _useStrictModifierCheck;
    [SerializeField]
    private bool _lMouseBtn;
    [SerializeField]
    private bool _rMouseBtn;
    [SerializeField]
    private bool _mMouseBtn;
    [SerializeField]
    private bool _useStrictMouseCheck;
    [SerializeField]
    private string _name;
    [NonSerialized]
    private List<Hotkeys> _potentialOverlaps;
    [SerializeField]
    private HotkeysStaticData _staticData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Hotkeys() => throw null;

    public static List<KeyCode> AvailableKeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static List<string> AvailableKeyNames
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KeyCode Key
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool LCtrl
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool LCmd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool LAlt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool LShift
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool LMouseButton
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool RMouseButton
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool MMouseButton
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseStrictMouseCheck
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseStrictModifierCheck
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Hotkeys(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Hotkeys(string name, HotkeysStaticData staticData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EstablishPotentialOverlaps(List<Hotkeys> hotkeysCollection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNumModifiers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNumMouseButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<MouseButton> GetAllUsedMouseButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UsesMouseButtons(List<MouseButton> buttons) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<KeyCode> GetAllUsedModifiers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UsesModifiers(List<KeyCode> modifiers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPotentialOverlap(Hotkeys hotkeys) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsPotentialOverlap(Hotkeys hotkeys) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsOverlappedBy(Hotkeys hotkeys) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsActive(bool checkForOverlaps = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsActiveInFrame(bool checkForOverlaps = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasNoKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasNoModifiers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasNoMouseButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEmpty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsAnyModifierKeyPressed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsAnyMouseButtonPressed() => throw null;
  }
}
