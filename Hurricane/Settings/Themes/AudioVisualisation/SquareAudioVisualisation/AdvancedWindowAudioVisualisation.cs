﻿using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using Hurricane.PluginAPI.AudioVisualisation;
using WPFSoundVisualizationLib;

namespace Hurricane.Settings.Themes.AudioVisualisation.SquareAudioVisualisation
{
    public class AdvancedWindowAudioVisualisation : IAudioVisualisation
    {
        private SpectrumAnalyzer _spectrumAnalyzer;

        public void Enable()
        {
            if (_spectrumAnalyzer != null) _spectrumAnalyzer.RefreshInterval = 20;
        }

        public void Disable()
        {
            if (_spectrumAnalyzer != null) _spectrumAnalyzer.RefreshInterval = int.MaxValue;
        }

        public void Dispose()
        {
            _spectrumAnalyzer = null;
        }

        private ISpectrumProvider _spectrumProvider;
        public ISpectrumProvider SpectrumProvider
        {
            set { _spectrumProvider = value; }
        }

        private ColorInformation _colorInformation;
        public ColorInformation ColorInformation
        {
            set { _colorInformation = value; }
        }

        public UIElement VisualElement
        {
            get
            {
                if (_spectrumAnalyzer == null)
                {
                    var style = new Style(typeof(SpectrumAnalyzer));
                    var barStyle = new Style(typeof(Rectangle));
                    barStyle.Setters.Add(new Setter(UIElement.RenderTransformOriginProperty, new Point(.5, .5)));
                    barStyle.Setters.Add(new Setter(UIElement.RenderTransformProperty, new RotateTransform(-180)));
                    barStyle.Setters.Add(new Setter(Shape.FillProperty,
                        new VisualBrush(new Rectangle { Width = 10, Height = 3, Fill = _colorInformation.GrayBrush })
                        {
                            TileMode = TileMode.Tile,
                            Viewport = new Rect(0, 0, 5, 5),
                            ViewportUnits = BrushMappingMode.Absolute,
                            Viewbox = new Rect(0, 0, 5, 5),
                            ViewboxUnits = BrushMappingMode.Absolute
                        }));
                    barStyle.Setters.Add(new Setter(UIElement.SnapsToDevicePixelsProperty, true));

                    style.Setters.Add(new Setter(SpectrumAnalyzer.BarStyleProperty, barStyle));

                    var peakStyle = new Style(typeof(Rectangle));
                    peakStyle.Setters.Add(new Setter(Shape.FillProperty, _colorInformation.AccentBrush));
                    peakStyle.Setters.Add(new Setter(UIElement.SnapsToDevicePixelsProperty, true));
                    style.Setters.Add(new Setter(SpectrumAnalyzer.PeakStyleProperty, peakStyle));

                    _spectrumAnalyzer = new SpectrumAnalyzer { BarCount = 50, Style = style, RefreshInterval = 20 };
                    _spectrumAnalyzer.RegisterSoundPlayer(new SpectrumPlayerWrapper(_spectrumProvider));
                }
                return _spectrumAnalyzer;
            }
        }
    }
}
