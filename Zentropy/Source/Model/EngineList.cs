using System;
using System.Collections.Generic;

namespace Zentropy.Model
{
    [Serializable]
    public class EngineList
    {
        public bool SettingAvailable => Settings.Count > 0;
        public int SelectedIndex { get; set; }
        public int SelectedOpponentIndex { get; set; }
        public List<EngineSetting> Settings { get; set; }
        public List<string> LastExePaths { get; set; } = new List<string>();
        public List<string> LastLogoPaths { get; set; } = new List<string>();

        public EngineSetting SelectedSetting
        {
            get
            {
                if (SelectedIndex == -1 || Settings.Count == 0)
                    return null;

                return Settings[SelectedIndex];
            }
        }

        public EngineSetting SelectedOpponentSetting
        {
            get
            {
                if (SelectedOpponentIndex == -1 || Settings.Count == 0)
                    return null;

                return Settings[SelectedOpponentIndex];
            }
        }

        public EngineList()
        {
            Settings = new List<EngineSetting>();
            SelectedIndex = -1;
        }

        public void TryAddExePath(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || LastExePaths.Contains(path))
                return;

            LastExePaths.Add(path);

            if (LastExePaths.Count > 8)
            {
                LastExePaths.RemoveRange(8, LastExePaths.Count - 8);
            }
        }
        public void TryAddLogoPath(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || LastLogoPaths.Contains(path))
                return;

            LastLogoPaths.Add(path);

            if (LastLogoPaths.Count > 8)
            {
                LastLogoPaths.RemoveRange(8, LastLogoPaths.Count - 8);
            }
        }
    }
}
