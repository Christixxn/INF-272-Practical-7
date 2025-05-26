using System;

namespace Practical_7.Models
{
    public class Article : Publication // Inherits from Publication
    {
        public Article(string title, Author author, string summary, DateTime publicationDate, string leadingImage, string mainStoryURL)
            : base(title, author, summary, publicationDate, leadingImage, mainStoryURL) { }
    }
}
