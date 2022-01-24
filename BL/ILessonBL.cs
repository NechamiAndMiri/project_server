﻿using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface ILessonBL
    {
     Task<List<TblLesson>> GetAllLessons(int patientID);
     Task<List<TblWordsGivenToPractice>> GetLessonWords(int lessonID);
     Task PostLesson(TblLesson tblLesson);
     Task PostWordToLesson(TblWordsGivenToPractice WordGivenToPractice);
     Task PutColIsCheckedAtLesson(int lessonId);
     Task PutColIsValidAtWordToPractice(int wordId);
     Task DeleteLesson(int lessonId);
     Task DeleteWordFromLesson(int wordId);
     Task PutLesson(TblLesson tblLesson);
     Task PutWordForLesson(TblWordsGivenToPractice word);
    }
}