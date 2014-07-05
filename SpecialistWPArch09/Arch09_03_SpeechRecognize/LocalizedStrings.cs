using Arch09_03_SpeechRecognize.Resources;

namespace Arch09_03_SpeechRecognize
{
    /// <summary>
    /// 文字列リソースにアクセスできるようにします。
    /// </summary>
    public class LocalizedStrings
    {
        private static AppResources _localizedResources = new AppResources();

        public AppResources LocalizedResources { get { return _localizedResources; } }
    }
}