using System;

namespace Practical_7.Models
{
    public class Book : Publication // Inherits from Publication
    {
        public double EditionCount { get; set; }

        public Book(string title, Author author, string summary, DateTime publicationDate, double editionCount, string leadingImage, string mainStoryURL)
            : base(title, author, summary, publicationDate, leadingImage, mainStoryURL)
        {
            EditionCount = editionCount;
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $"\nEdition Number: {EditionCount}";
        }
    }
}
