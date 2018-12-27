﻿using System.Windows;
using System.Windows.Media;

namespace Hurricane.Utilities
{
    // ReSharper disable once InconsistentNaming
    public static class UIHelper
    {
        // walk up the visual tree to find object of type T, starting from initial object
        public static T FindUpVisualTree<T>(DependencyObject initial) where T : DependencyObject
        {
            DependencyObject current = initial;

            while (current != null && current.GetType() != typeof(T))
            {
                current = VisualTreeHelper.GetParent(current);
            }
            return current as T;
        }
    }
}