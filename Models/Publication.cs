using System;

namespace Practical_7.Models
{
    public abstract class Publication
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Summary { get; set; }
        public DateTime PublicationDate { get; set; }
        public string LeadingImage { get; set; }  
        public string MainStoryURL { get; set; }  

        protected Publication(string title, Author author, string summary, DateTime publicationDate, string leadingImage, string mainStoryURL)
        {
            Title = title;
            Author = author;
            Summary = summary;
            PublicationDate = publicationDate;
            LeadingImage = leadingImage;
            MainStoryURL = mainStoryURL;
        }

        public virtual string DisplayInfo()
        {
            return $"{Title} by {Author.Name}\nPublished on: {PublicationDate:dd/MM/yyyy}";
        }
    }
}
