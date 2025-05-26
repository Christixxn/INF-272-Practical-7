using System;
using System.Collections.Generic;
using Practical_7.Models;

namespace Practical_7.Data
{
    public static class FakeDataRepository // All the excel data stored in a seperate class for easy access and management
    {
        public static List<Publication> GetPublications()
        {
            return new List<Publication>
            {
                new Article(
                    "Improving the foundation of our falling sand simulator",
                    new Author(1, "Koffi Umukoro"),
                    "Addison is a detective from Sale who falls in love with his best friend. The two are separated when the best friend falls for somebody else. However, Addison manages to rescue the situation by buying a magnificent t-shirt.",
                    new DateTime(2018, 7, 24),
                    "https://cdn.pixabay.com/photo/2018/03/02/20/22/sktop-3194194__340.jpg",
                    "https://bait.example.net/bag.aspx"
                ),
                new Book(
                    "NASA fed some Apollo 11 lunar samples to cockroaches and mice",
                    new Author(2, "Octavia Barret"),
                    "A farmer from Markham is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered when her son goes missing. Unexpectedly, the farmer is bitten by a zombie and therefore is disqualified from competing.",
                    new DateTime(2006, 5, 15),
                    2.0,
                    "https://cdn.pixabay.com/photo/2016/08/18/08/31/lemur-1602313__340.jpg",
                    "https://www.example.com/bite.aspx"
                ),
                new Article(
                    "When Your Smart ID Card Reader Comes with Malware",
                    new Author(3, "Gunnhild Aric"),
                    "A caretaker from Lehi is delighted when she gets the chance to take part in the final of X-Factor. However, her chances are scuppered by an angry camel. After the drama, the caretaker realizes there is more to life than winning X-Factor and goes on a picnic with her great aunt instead.",
                    new DateTime(2023, 3, 21),
                    "https://cdn.pixabay.com/photo/2017/06/14/11/34/meadow-2401931__340.jpg",
                    "https://example.com/bone/basin.php?bed=bedroom&boat=amusement#boundary"
                ),
                new Book(
                    "Jailer: A truly relational database tool",
                    new Author(4, "Jakob Ayanda"),
                    "In a world where robots are wealthy, one golfer has no choice but to assassinate an honorable man by killing his own ex-wife. Eventually, the golfer forms an army and teaches the robots a little respect.",
                    new DateTime(1989, 6, 6),
                    3.0,
                    "https://cdn.pixabay.com/photo/2016/08/20/05/44/clock-1606919__340.jpg",
                    "https://www.example.com/baseball/basin.php?attraction=anger&bead=amusement"
                ),
                new Article(
                    "Everything you ever wanted to know about terminals",
                    new Author(5, "Shyam Benson"),
                    "In a world where robots are miraculously transformed into angels, one pop star has no choice but to bring down the government by killing her own step-sister. It turns out all the robots were manifestations of the pop star's multiple personality disorder and her real fight is one to regain sanity.",
                    new DateTime(2020, 1, 23),
                    "https://cdn.pixabay.com/photo/2016/09/01/10/33/witchs-house-1635770_960_720.jpg",
                    "https://www.example.com/bait/bath.php"
                ),
                new Article(
                    "NaturalSpeech: End-to-end text to speech synthesis with human-level quality",
                    new Author(6, "Lucas Asim"),
                    "When a movie star from West Des Moines learns to sing, not everybody is supportive. However, her fortunes improve when her step-sister buys a derelict castle. Eventually, the movie star realizes that she has always been a worthwhile person and does not need to change.",
                    new DateTime(2022, 10, 28),
                    "https://cdn.pixabay.com/photo/2016/04/25/07/15/man-1351317__340.png",
                    "http://www.example.com/bear"
                ),
                new Article(
                    "Husky, Datadog's Third-Generation Event Store",
                    new Author(7, "Harmon Deeann"),
                    "A WW2 veteran in Brisbane receives an invitation to a modern battle. It turns out the invitation is spam and is from a scammer who is famous for making up stories.",
                    new DateTime(2022, 3, 4),
                    "https://cdn.pixabay.com/photo/2020/03/13/08/19/ornaments-4927258__340.jpg",
                    "https://www.example.com/bells"
                ),
                new Book(
                    "Singers and Vampires",
                    new Author(8, "Gargi Sudheer"),
                    "In a world where vampires run large corporations, one singer has no choice but to protect mankind using a magic ring. It turns out the vampires are all sheep.",
                    new DateTime(1972, 4, 24),
                    2.0,
                    "https://cdn.pixabay.com/photo/2016/08/07/18/22/back-to-school-1576791__340.jpg",
                    "https://example.com/baseball/adjustment.aspx?airplane=border&advertisement=argument"
                )
            };
        }
    }
}
