﻿using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Rendering;

namespace Waf.DotNetPad.Presentation.Controls;

internal sealed class CodeHighlightingColorizer : HighlightingColorizer
{
    private readonly Func<Microsoft.CodeAnalysis.Document> getDocument;

    public CodeHighlightingColorizer(Func<Microsoft.CodeAnalysis.Document> getDocument)
    {
        this.getDocument = getDocument;
    }

    protected override IHighlighter CreateHighlighter(TextView textView, TextDocument document) => new CodeHighlighter(document, getDocument);
}
