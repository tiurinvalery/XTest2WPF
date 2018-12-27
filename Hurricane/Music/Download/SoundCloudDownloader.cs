﻿using System;
using System.Net;
using System.Threading.Tasks;
using Hurricane.Settings;

namespace Hurricane.Music.Download
{
    class SoundCloudDownloader
    {
        public static async Task DownloadSoundCloudTrack(string soundCloudId, string fileName, Action<double> progressChangedAction)
        {
            using (var client = new WebClient { Proxy = null })
            {
                client.DownloadProgressChanged += (s, e) => progressChangedAction.Invoke(e.ProgressPercentage);
                await
                    client.DownloadFileTaskAsync(
                        string.Format("https://api.soundcloud.com/tracks/{0}/download?client_id={1}", soundCloudId,
                            SensitiveInformation.SoundCloudKey), fileName);
            }
        }
    }
}