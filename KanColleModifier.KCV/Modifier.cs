﻿using Grabacr07.KanColleViewer.Composition;
using System.ComponentModel.Composition;

namespace Gizeta.KanColleModifier.KCV
{
    [Export(typeof(IToolPlugin))]
    [ExportMetadata("Title", "KanColleModifier.KCV")]
    [ExportMetadata("Description", "KanColleViewer舰娘魔改插件。")]
    [ExportMetadata("Version", "1.2.0")]
    [ExportMetadata("Author", "@Gizeta")]
    public class Modifier : IToolPlugin
    {
        public Modifier()
        {
            ModifierViewModel.Instance.Initialize();
        }
        
        public string ToolName
        {
            get { return "魔改"; }
        }

        public object GetSettingsView()
        {
            return null;
        }

        public object GetToolView()
        {
            return new ModifierView();
        }
    }
}
