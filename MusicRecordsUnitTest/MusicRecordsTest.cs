using MusicRecordsRepository.Models;

namespace MusicRecordsUnitTest
{
    [TestClass]
    public class MusicRecordsTest
    {

        private MusicRecord validMusicRecord = new MusicRecord { Id = 1, Title = "Ops I did it again", Artist = "Britney Spears", Duration = 2670, PublicationYear = 2000, Genre = "Pop"};
        private MusicRecord titleNull = new MusicRecord { Id = 2, Title = null, Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord titleShort = new MusicRecord { Id = 3, Title = "", Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord artistNull = new MusicRecord { Id = 4, Title = "Ops, I did it again", Artist = null, PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord artistShort = new MusicRecord { Id = 5, Title = "Ops, I did it again", Artist = "", PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord durationShort = new MusicRecord { Id = 6, Title = "Ops, I did it again", Artist = "Britney Spears", PublicationYear = 2000, Duration = 29, Genre = "Pop" };
        private MusicRecord durationLong= new MusicRecord { Id = 7, Title = "Ops, I did it again", Artist = "Britney Spears", PublicationYear = 2000, Duration = 4801, Genre = "Pop" };
        private MusicRecord publicationYearBefore = new MusicRecord { Id = 8, Title = "Ops, I did it again", Artist = "Britney Spears", PublicationYear = 1981, Duration = 2670, Genre = "Pop" };
        private MusicRecord publicationYearAfter = new MusicRecord { Id = 9, Title = "Ops, I did it again", Artist = "Britney Spears", PublicationYear = 2025, Duration = 2670, Genre = "Pop" };
        private MusicRecord genreNull = new MusicRecord { Id = 10, Title = "Ops, I did it again", Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = null }; private MusicRecord validMusicRecord = new MusicRecord { Id = 1, Title = "Ops, I did it again", Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord genreShort = new MusicRecord { Id = 11, Title = "Ops, I did it again", Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = "Po" };


        //[TestMethod]
        //public void ToStringTest()
        //{
        //    string str = validMusicRecord.ToString();
        //    Assert.AreEqual(str, "1, Ops I did it again, Britney Spears, 2670, 2000, Pop");
        //}
    }
}