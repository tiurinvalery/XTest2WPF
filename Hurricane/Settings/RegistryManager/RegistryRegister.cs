﻿using System;
using System.Security.AccessControl;
using Microsoft.Win32;

namespace Hurricane.Settings.RegistryManager
{
    class RegistryRegister
    {
        /// <summary>
        /// Creates a new item in the windows explorer context menu
        /// </summary>
        /// <param name="extension">The file extension (like .mp3)</param>
        /// <param name="header">The text shown in the context menu</param>
        /// <param name="name">The name of the subkey</param>
        /// <param name="applicationpath">The path with paramters</param>
        /// <param name="iconpath">The path of the icon</param>
        /// <returns>False if the user doesn't have access</returns>
        public static void RegisterExtension(string extension, string header, string name, string applicationpath, string iconpath)
        {
            using (RegistryKey extensionkey = GetClassesRoot().OpenSubKey(extension))
            {
                string keytoadd = extensionkey.GetValue("", string.Empty).ToString();

                using (RegistryKey rootkey = Registry.ClassesRoot.OpenSubKey(keytoadd))
                {
                    using (RegistryKey shellkey = rootkey.OpenSubKey("shell", true))
                    {
                        using (RegistryKey subkey = shellkey.CreateSubKey(name))
                        {
                            subkey.SetValue("", header);
                            subkey.SetValue("Icon", iconpath);
                            var commandkey = subkey.CreateSubKey("command");
                            commandkey.SetValue("", applicationpath);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Removes an item from the windows explorer context menu
        /// </summary>
        /// <param name="extension">The file extension (like .mp3)</param>
        /// <param name="name">The name of the subkey</param>
        /// <returns>False if the user doesn't have access</returns>
        public static void UnregisterExtension(string extension, string name)
        {
            using (RegistryKey extensionkey = GetClassesRoot().OpenSubKey(extension))
            {
                string keytoadd = extensionkey.GetValue("", string.Empty).ToString();

                using (RegistryKey rootkey = Registry.ClassesRoot.OpenSubKey(keytoadd))
                {
                    using (RegistryKey shellkey = rootkey.OpenSubKey("shell", true))
                    {
                        shellkey.DeleteSubKeyTree(name, false);
                    }
                }
            }
        }

        protected static RegistryKey GetClassesRoot()
        {
            if (Environment.Is64BitOperatingSystem)
            {
               return RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
            }
            else
            {
                return RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry32);
            }
        }


        public static bool CheckIfExtensionExists(string extension, string name)
        {
            using (RegistryKey extensionkey = GetClassesRoot().OpenSubKey(extension, RegistryKeyPermissionCheck.Default, RegistryRights.ReadKey))
            {
                if (extensionkey == null) return false;
                string keytoadd = extensionkey.GetValue("", string.Empty).ToString();

                using (RegistryKey rootkey = Registry.ClassesRoot.OpenSubKey(keytoadd, RegistryKeyPermissionCheck.Default, RegistryRights.ReadKey))
                {
                    using (RegistryKey shellkey = rootkey.OpenSubKey("shell", RegistryKeyPermissionCheck.Default, RegistryRights.ReadKey))
                    {
                        var key = shellkey.OpenSubKey(name, RegistryKeyPermissionCheck.Default, RegistryRights.ReadKey);
                        return key != null;
                    }
                }
            }
        }
    }
}
