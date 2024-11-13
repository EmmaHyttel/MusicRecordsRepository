using MusicRecordsRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRecordsRepository
{
    public class MusicRecordRepo : IMusicRecordRepo
    {
        private static int _nextId = 1;
        private readonly List<MusicRecord> _repo = new();

        public MusicRecordRepo() // havde den ikke til eksamen, det er en liste med 5 objekter, før var den tom. Dette er en konstruktør
        {
            _repo.Add(new MusicRecord() { Id = _nextId++, Title = "Believe", Artist = "Justin Bieber", Duration = 2895, PublicationYear = 2012, Genre ="Pop"});
            _repo.Add(new MusicRecord() { Id = _nextId++, Title = "24K Magic", Artist = "Bruno Mars", Duration = 2012, PublicationYear = 2016, Genre ="Funk"});
            _repo.Add(new MusicRecord() { Id = _nextId++, Title = "For Altid", Artist = "Medina", Duration = 2352, PublicationYear = 2011, Genre ="Pop"});
            _repo.Add(new MusicRecord() { Id = _nextId++, Title = "Legend (Deluxe Edition)", Artist = "Bob Marley", Duration = 4312, PublicationYear = 1984, Genre ="Reggae"});
            _repo.Add(new MusicRecord() { Id = _nextId++, Title = "Infinite", Artist = "Eminem", Duration = 3827, PublicationYear = 1996, Genre = "Rap" }); 

        }
        public MusicRecord Add(MusicRecord musicRecord)
        {
            musicRecord.Validate();
            musicRecord.Id = _nextId++;
            _repo.Add(musicRecord);
            return musicRecord;
        }

        public IEnumerable<MusicRecord> Get()
        {
            IEnumerable<MusicRecord> result = new List<MusicRecord>(_repo);
            return result;
        }

        public MusicRecord? GetById(int id)
        {
            return _repo.Find(MusicRecord => MusicRecord.Id == id);
        }

        public MusicRecord? Remove(int id)
        {
            MusicRecord? musicRecord = GetById(id);
            if (musicRecord == null)
            {
                return null;
            }
            _repo.Remove(musicRecord);
            return musicRecord;
        }

        public MusicRecord? Update(int id, MusicRecord musicRecord)
        {
            musicRecord.Validate();
            MusicRecord? existingMusicRecord = GetById(id);
            if (existingMusicRecord == null)
            {
                return null;
            }
            existingMusicRecord.Title = musicRecord.Title;
            existingMusicRecord.Artist = musicRecord.Artist;
            existingMusicRecord.Duration = musicRecord.Duration;
            existingMusicRecord.PublicationYear = musicRecord.PublicationYear;
            existingMusicRecord.Genre = musicRecord.Genre;
            return existingMusicRecord;
        }
    }
}
