﻿using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Waf.DotNetPad.Presentation.Controls;

public class CodeCompletionDescription : Model
{
    private ImmutableArray<TaggedText> summary;

    public CodeCompletionDescription(Task<ImmutableArray<TaggedText>> lazySummary)
    {
        UpdateSummary(lazySummary);
    }

    public ImmutableArray<TaggedText> Summary
    {
        get => summary;
        private set => SetProperty(ref summary, value);
    }

    private async void UpdateSummary(Task<ImmutableArray<TaggedText>> lazySummary)
    {
        Summary = await lazySummary;
    }
}
