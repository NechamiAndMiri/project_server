﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IWordDL
    {
        Task<IEnumerable<TblPronunciationProblemsType>> GetAllPronunciationProblemsTypes();
        Task<IEnumerable<TblDifficultyLevel>> GetAllLevels(int problemsTypeId);
    }
}