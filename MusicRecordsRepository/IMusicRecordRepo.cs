using MusicRecordsRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicRecordsRepository
{
    public interface IMusicRecordRepo
    {
        IEnumerable<MusicRecord> Get();

        MusicRecord? GetById(int id);
        MusicRecord Add(MusicRecord musicRecord);
        MusicRecord? Remove(int id);
        MusicRecord? Update(int id, MusicRecord musicRecord);
    }
}
