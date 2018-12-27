﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using Hurricane.Designer.Data;
using Hurricane.Settings.Themes.AudioVisualisation;
using Hurricane.Settings.Themes.AudioVisualisation.BarAudioVisualisation;
using Hurricane.Settings.Themes.AudioVisualisation.RectangleVisualisation;
using Hurricane.Settings.Themes.AudioVisualisation.SquareAudioVisualisation;
using Hurricane.Settings.Themes.Background;
using Hurricane.Settings.Themes.Visual;
using Hurricane.Settings.Themes.Visual.AccentColors;
using Hurricane.Settings.Themes.Visual.AppThemes;
using Hurricane.ViewModelBase;

namespace Hurricane.Settings.Themes
{
    [Serializable]
    public class ApplicationDesign : PropertyChangedBase
    {
        [XmlIgnore]
        public IAccentColor AccentColor { get; set; }

        [XmlIgnore]
        public IAppTheme AppTheme { get; set; }

        private IApplicationBackground _applicationBackground;
        [XmlIgnore]
        public IApplicationBackground ApplicationBackground
        {
            get { return _applicationBackground; }
            set
            {
                SetProperty(value, ref _applicationBackground);
            }
        }
        
        private IAudioVisualisationContainer _audioVisualisation;
        [XmlIgnore]
        public IAudioVisualisationContainer AudioVisualisation
        {
            get { return _audioVisualisation; }
            set
            {
                var oldValue = _audioVisualisation;
                if (SetProperty(value, ref _audioVisualisation) && oldValue != null)
                {
                    oldValue.Visualisation.AdvancedWindowVisualisation.Dispose();
                    oldValue.Visualisation.SmartWindowVisualisation.Dispose();
                }
            }
        }

        public void SetStandard()
        {
            var themeManager = ApplicationThemeManager.Instance;
            AccentColor = themeManager.AccentColors.First(x => x.Name == "Blue");
            AppTheme = themeManager.AppThemes.First(x => x.Name == "BaseLight");
            ApplicationBackground = null;
            AudioVisualisation = DefaultAudioVisualisations[0];
        }

        public static readonly List<AudioVisualisationBase> DefaultAudioVisualisations = new List
            <AudioVisualisationBase>
        {
            new SquareAudioVisualisation(),
            new BarAudioVisualisation(),
            new RectangleAudioVisualisation()
        };

        #region Workaround for serializing interfaces

        [XmlElement("AccentColor", Type = typeof(AccentColorBase))]
        [XmlElement("AccentColorThemePack", Type = typeof(ThemePack))]
        public object SerializableAccentColor
        {
            get
            {
                return AccentColor; 
            }
            set
            {
                var accentColor = (IAccentColor) value;
                if (accentColor is AccentColorBase)
                {
                    AccentColor = ApplicationThemeManager.Instance.AccentColors.FirstOrDefault(x => x.Equals(accentColor));
                }
                else if(accentColor is ThemePack)
                {
                    AccentColor = ApplicationThemeManager.Instance.GetThemePack(((ThemePack)value).FileName);
                }
            }
        }

        [XmlElement("AppTheme", Type = typeof(AppThemeBase))]
        [XmlElement("AppThemePack", Type = typeof(ThemePack))]
        public object SerializableAppTheme
        {
            get { return AppTheme; }
            set
            {
                var appTheme = (IAppTheme)value;
                if (appTheme is AppThemeBase)
                {
                    AppTheme = ApplicationThemeManager.Instance.AppThemes.FirstOrDefault(x => x.Equals(appTheme));
                }
                else if (appTheme is ThemePack)
                {
                    AccentColor = ApplicationThemeManager.Instance.GetThemePack(((ThemePack)value).FileName);
                }
            }
        }

        [XmlElement("ApplicationBackground", Type = typeof(CustomApplicationBackground))]
        [XmlElement("ApplicationBackgroundPack", Type = typeof(ThemePack))]
        public object SerializableBackgroundImage
        {
            get { return ApplicationBackground; }
            set
            {
                if (value is ThemePack)
                {
                    ApplicationBackground = ApplicationThemeManager.Instance.GetThemePack(((ThemePack) value).FileName);
                }
                else
                {
                    ApplicationBackground = (IApplicationBackground)value;
                }
            }
        }

        [XmlElement("AudioVisualisation", Type = typeof(AudioVisualisationBase))]
        [XmlElement("AudioVisualisationPack", Type = typeof(ThemePack))]
        [XmlElement("CustomAudioVisualisation", Type = typeof(CustomAudioVisualisation))]
        public object SerializableAudioVisualisation
        {
            get { return AudioVisualisation; }
            set
            {
                if (value is AudioVisualisationBase)
                {
                    AudioVisualisation =
                        DefaultAudioVisualisations.First(x => x.Name == ((AudioVisualisationBase) value).Name);
                }
                else if (value is CustomAudioVisualisation)
                {
                    var visualisation = (CustomAudioVisualisation) value;

                    AudioVisualisation =
                        ApplicationThemeManager.Instance.AudioVisualisations.OfType<CustomAudioVisualisation>()
                            .FirstOrDefault(
                                x => x.FileName == visualisation.FileName);
                    if (AudioVisualisation == null) AudioVisualisation = DefaultAudioVisualisations[0];
                }
                else if (value is ThemePack)
                {
                    AudioVisualisation = ApplicationThemeManager.Instance.GetThemePack(((ThemePack) value).FileName);
                }
            }
        }

        #endregion

        public bool Equals(ApplicationDesign obj)
        {
            return AccentColor.Equals(obj.AccentColor) && AppTheme.Equals(obj.AppTheme) &&
                ApplicationBackground != null && ApplicationBackground.Equals(obj.ApplicationBackground);
        }
    }
}