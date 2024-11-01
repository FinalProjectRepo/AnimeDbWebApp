﻿namespace AnimeDbWebApp.Common
{
    public static class ValidationConstants
    {
        public static class AnimeValidation
        {
            public const int MaxUrlLength = 500;
            public const int MaxPosterUrlLength = 500;
            public const int MaxTrailerUrlLength = 500;
            public const int MinTitleLength = 5;
            public const int MaxTitleLength = 255;
            public const int MaxEngTitleLength = 255;
            public const int MaxJapTitleLength = 255;
            public const int MinSourceLength = 2;
            public const int MaxSourceLength = 30;
            public const int MinEpisodes = 1;
            public const int MaxEpisodes = 5000;
            public const int MaxDurationLength = 255;
            public const int MaxRatingLength = 255;
            public const double MinScore = 0.00;
            public const double MaxScore = 10.00;
            public const int MinSypnosisLength = 5;
            public const int MaxSypnosisLength = 5000;
            public const int MinBackgroundLength = 5;
            public const int MaxBackgroundLength = 5000;
        }

        public static class TypeValidation 
        {
            public const int MinNameLength = 2;
            public const int MaxNameLength = 30;
        }

        public static class ProducerValidations
        {
            public const int MaxUrlLength = 500;
            public const int MaxImgUrlLength = 500;
            public const int MinNameLength = 2;
            public const int MaxNameLength = 30;
            public const int MinJpNameLength = 2;
            public const int MaxJpNameLength = 30;
            public const int MaxAboutLength = 5000;
        }

        public static class GenreValidations
        {
            public const int MinNameLength = 3;
            public const int MaxNameLength = 20;
        }

        public static class MangaValidations
        {
            public const int MinTitleLength = 5;
            public const int MaxTitleLength = 255;
            public const int MaxEngTitleLength = 255;
            public const int MaxJapTitleLength = 255;
            public const double MinScore = 0.00;
            public const double MaxScore = 10.00;
            public const int MinSypnosisLength = 5;
            public const int MaxSypnosisLength = 255;
            public const int MinBackgroundLength = 5;
            public const int MaxBackgroundLength = 255;
        }

        public static class AuthorValidations
        {
            public const int MaxUrlLength = 500;
            public const int MaxWebsiteUrlLength = 500;
            public const int MaxPosterUrlLength = 500;
            public const int MinNameLength = 5;
            public const int MaxNameLength = 255;
            public const int MaxGivenNameLength = 255;
            public const int MaxFamilyNameLength = 255;
            public const int MaxAboutLength = 5000;
        }
    }
}