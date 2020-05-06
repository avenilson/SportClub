using System.Collections.Generic;

namespace SportClub.Core.Trainings
{
    public static class TrainingTypes
    {
        public static string Light = "Light";
        public static string Moderate = "Moderate";
        public static string Hard = "Hard";
        public static string Extreme = "Extreme";
        public static string MaximalEffort = "Maximal Effort";

        public static List<Data> Trainings =>
            new List<Data>
            {
                new Data( Light, "Light", "", ""),
                new Data(Moderate, "Moderate", "", ""),
                new Data(Hard, "Hard", "", ""),
                new Data(Extreme, "Extreme", "", ""),
                new Data(MaximalEffort, "Maximal Effort", "", "")
            };
    }
}
