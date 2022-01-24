﻿




using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IExerciseDL
    {
        Task<List<TblExercise>> GetExercises(int difficultylevelId);
        Task<List<TblWordsPerExercise>> GetExerciseWords(int exerciseId);
        Task PostExercise(TblExercise exercise);
        Task PostWordPerExercise(TblWordsPerExercise wordPerExercise);
        Task PutExercise(TblExercise exercise);
        Task DeleteExercise(int exerciseId);
        Task DeleteWordFromExercise(int wordId);
    }
}