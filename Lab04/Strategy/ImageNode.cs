using System;

namespace Observer
{
    public class ImageNode : LightNode
    {
        public string Href { get; }
        private IImageLoadingStrategy loadingStrategy;

        public ImageNode(string href, IImageLoadingStrategy loadingStrategy)
        {
            Href = href;
            this.loadingStrategy = loadingStrategy;
        }

        public override string OuterHtml => $"<img src=\"{Href}\">";
        public override string InnerHtml => "";

        public void LoadImage()
        {
            loadingStrategy.UploadImage(Href);
        }
    }
}