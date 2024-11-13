using MusicRecordsRepository.Models;

namespace MusicRecordUnitTest
{
    [TestClass]
    public class MusicRecordTest
    {

        private MusicRecord validMusicRecord = new MusicRecord { Id = 1, Title = "'Ops, I did it again'", Artist = "Britney Spears", Duration = 2670, PublicationYear = 2000, Genre = "Pop"};
        private MusicRecord titleNull = new MusicRecord { Id = 2, Title = null, Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord titleShort = new MusicRecord { Id = 3, Title = "", Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord artistNull = new MusicRecord { Id = 4, Title = "'Ops, I did it again'", Artist = null, PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord artistShort = new MusicRecord { Id = 5, Title = "'Ops, I did it again'", Artist = "", PublicationYear = 2000, Duration = 2670, Genre = "Pop" };
        private MusicRecord durationShort = new MusicRecord { Id = 6, Title = "'Ops, I did it again'", Artist = "Britney Spears", PublicationYear = 2000, Duration = 29, Genre = "Pop" };
        private MusicRecord durationLong= new MusicRecord { Id = 7, Title = "'Ops, I did it again'", Artist = "Britney Spears", PublicationYear = 2000, Duration = 4801, Genre = "Pop" };
        private MusicRecord publicationYearBefore = new MusicRecord { Id = 8, Title = "'Ops, I did it again'", Artist = "Britney Spears", PublicationYear = 1981, Duration = 2670, Genre = "Pop" };
        private MusicRecord publicationYearAfter = new MusicRecord { Id = 9, Title = "'Ops, I did it again'", Artist = "Britney Spears", PublicationYear = 2025, Duration = 2670, Genre = "Pop" };
        private MusicRecord genreNull = new MusicRecord { Id = 10, Title = "'Ops, I did it again'", Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = null }; 
        private MusicRecord genreShort = new MusicRecord { Id = 11, Title = "'Ops, I did it again'", Artist = "Britney Spears", PublicationYear = 2000, Duration = 2670, Genre = "Po" };


        [TestMethod]
        public void ToStringTest()
        {
            string str = validMusicRecord.ToString();
            Assert.AreEqual(str, "1, 'Ops, I did it again', Britney Spears, 2670, 2000, Pop");
        }

        [TestMethod]
        public void ValidateTitleTest()
        {
            validMusicRecord.ValidateTitle();
            Assert.ThrowsException<ArgumentNullException>(() => titleNull.ValidateTitle());
            Assert.ThrowsException<ArgumentException>(() => titleShort.ValidateTitle());
        }

        [TestMethod]
        public void ValidateArtistTest()
        {
            validMusicRecord.ValidateArtist();
            Assert.ThrowsException<ArgumentNullException>(() => artistNull.ValidateArtist());
            Assert.ThrowsException<ArgumentException>(() => artistShort.ValidateArtist());
        }

        [TestMethod]
        public void ValidateDurationTest()
        {
            validMusicRecord.ValidateDuration();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => durationShort.ValidateDuration());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => durationLong.ValidateDuration());
        }

        [TestMethod]
        public void ValidatePublicationYearTest()
        {
            validMusicRecord.ValidatePublicationYear();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => publicationYearBefore.ValidatePublicationYear());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => publicationYearAfter.ValidatePublicationYear());
        }

        [TestMethod]
        public void ValidateGenreTest()
        {
            validMusicRecord.ValidateGenre();
            Assert.ThrowsException<ArgumentNullException>(() => genreNull.ValidateGenre());
            Assert.ThrowsException<ArgumentException>(() => genreShort.ValidateGenre());
        }

        [TestMethod]
        public void ValidateTest()
        {
            validMusicRecord.Validate();
            Assert.ThrowsException<ArgumentNullException>(() => titleNull.ValidateTitle());
            Assert.ThrowsException<ArgumentException>(() => titleShort.ValidateTitle());
            Assert.ThrowsException<ArgumentNullException>(() => artistNull.ValidateArtist());
            Assert.ThrowsException<ArgumentException>(() => artistShort.ValidateArtist());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => durationShort.ValidateDuration());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => durationLong.ValidateDuration());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => publicationYearBefore.ValidatePublicationYear());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => publicationYearAfter.ValidatePublicationYear());
            Assert.ThrowsException<ArgumentNullException>(() => genreNull.ValidateGenre());
            Assert.ThrowsException<ArgumentException>(() => genreShort.ValidateGenre());
        }

        [TestMethod] 
        [DataRow(30)]
        [DataRow(2000)]
        [DataRow(4800)]
        

        public void DurationLegalTest(int duration)
        {
            MusicRecord record = new MusicRecord(12, "Test", "Artist", duration, 2024, "Alternativ");
            record.ValidateDuration();
        }

        [TestMethod]
        [DataRow(29)]
        [DataRow(4801)]

        public void DurationFailTest(int duration)
        {
            MusicRecord record = new MusicRecord(13, "Test", "Artist", duration, 2024, "Alternativ");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Validate()); 
        }

        [TestMethod]
        [DataRow(1982)]
        [DataRow(2000)]
        [DataRow(2024)]


        public void PublicationYearLegalTest(int publicationYear)
        {
            MusicRecord record = new MusicRecord(12, "Test", "Artist", 3200, publicationYear, "Alternativ");
            record.ValidateDuration();
        }

        [TestMethod]
        [DataRow(1981)]
        [DataRow(2025)]

        public void PublicationYearFailTest(int publicationYear)
        {
            MusicRecord record = new MusicRecord(13, "Test", "Artist", 3200, publicationYear, "Alternativ");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => record.Validate());
        }
    }
}