// Decompiled with JetBrains decompiler
// Type: KSP.UI.TutorialsAndLessonsContextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game.Missions.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace KSP.UI
{
  public class TutorialsAndLessonsContextData : ApiDataContext
  {
    private const string LessonsTitleTranslationKeyPath = "Tutorials/Lessons/Titles/";
    private const string LessonsDescriptionTranslationKeyPath = "Tutorials/Lessons/Descriptions/";
    private const string TRAINING_CENTER_PREFIX = "Menu/TrainingCenter/";
    private const string PAUSE_WHILE_TUTORIAL_KEY = "Game pause info";
    private const string OK_BUTTON_KEY = "OK";
    private const string CANCEL_BUTTON_KEY = "Cancel";
    private const string CONFIRM_TUTORIAL_SELECTION_KEY = "ConfirmTutorialSelection";
    private SubTutorialsItem[] AllLessons;
    private List<MissionData> _completedLessons;
    [DataList("tutorials")]
    public ContextListProperty<TutorialContextElement> TutorialsList;
    [DataList("lessons")]
    public ContextListProperty<TutorialContextElement> LessonsList;
    [DataProperty("tutorialTitle")]
    public PropertyReadonly<string> TutorialTitle;
    [DataProperty("featureImage")]
    public PropertyReadonly<Sprite> FeatureImage;
    [DataProperty("groupDescription")]
    public PropertyReadonly<string> GroupDescription;
    private int _currentTutorialIndex;
    private int _currentLessonIndex;
    private LessonIcon[] _lessonsIcons;
    private ProgressLessonIcon[] _progressLessonsIcons;
    public UnityEvent UpdateContent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TutorialsAndLessonsContextData(
      SubTutorialsItem[] lessons,
      List<MissionData> completedlessons,
      LessonIcon[] lessonsIcons,
      ProgressLessonIcon[] progressLessonsIcons)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopupNotification() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissPopupNotification() => throw null;

    [DataAction("closeLessonsMenu")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CloseSubMenu() => throw null;

    [DataAction("openLessonsMenu")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OpenSubMenu(int index, bool isForced = false) => throw null;

    [DataAction("lessonSelected")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LessonSelected(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartLesson() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshSubMenu() => throw null;
  }
}
