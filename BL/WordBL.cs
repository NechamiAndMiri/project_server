﻿using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WordBL: IWordBL
    {
        IWordDL wordDL;

        public WordBL(IWordDL wordDL)
        {
            this.wordDL = wordDL;
        }

        public async Task<IEnumerable<TblPronunciationProblemsType>> GetAllPronunciationProblemsTypes()
        {
            return await wordDL.GetAllPronunciationProblemsTypes();
        }
    }
}
