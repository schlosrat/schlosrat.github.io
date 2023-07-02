// Decompiled with JetBrains decompiler
// Type: KSP.UI.ContextPanelDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class ContextPanelDataContext : DataContext
  {
    private const string ACTION_NAME_ONE_KEY = "ActionNameOne";
    private const string ACTION_ONE_VISIBLE_KEY = "ActionOneVisible";
    private const string ACTION_ONE_KEY = "ActionOne";
    private const string ACTION_NAME_TWO_KEY = "ActionNameTwo";
    private const string ACTION_TWO_VISIBLE_KEY = "ActionTwoVisible";
    private const string ACTION_TWO_KEY = "ActionTwo";
    private const string ACTION_NAME_THREE_KEY = "ActionNameThree";
    private const string ACTION_THREE_VISIBLE_KEY = "ActionThreeVisible";
    private const string ACTION_THREE_KEY = "ActionThree";
    private const string ACTION_NAME_FOUR_KEY = "ActionNameFour";
    private const string ACTION_FOUR_VISIBLE_KEY = "ActionFourVisible";
    private const string ACTION_FOUR_KEY = "ActionFour";
    private const string ACTION_NAME_FIVE_KEY = "ActionNameFive";
    private const string ACTION_FIVE_VISIBLE_KEY = "ActionFiveVisible";
    private const string ACTION_FIVE_KEY = "ActionFive";
    private const string OBJECT_NAME_KEY = "ObjectName";
    private const string OBJECT_TYPE_KEY = "ObjectType";
    private const string OBJECT_ICON_KEY = "ObjectIcon";
    private Property<string> ActionNameOne;
    private Property<string> ActionNameTwo;
    private Property<string> ActionNameThree;
    private Property<string> ActionNameFour;
    private Property<string> ActionNameFive;
    private Property<bool> ActionOneVisible;
    private Property<bool> ActionTwoVisible;
    private Property<bool> ActionThreeVisible;
    private Property<bool> ActionFourVisible;
    private Property<bool> ActionFiveVisible;
    private Property<string> ObjectName;
    private Property<string> ObjectType;
    private Property<Sprite> ObjectIcon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMetadata(string objectName, string objectType, Sprite objectIcon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionOne(string actionName, Action action, bool visible = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionTwo(string actionName, Action action, bool visible = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionThree(string actionName, Action action, bool visible = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionFour(string actionName, Action action, bool visible = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionFive(string actionName, Action action, bool visible = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextPanelDataContext() => throw null;
  }
}
