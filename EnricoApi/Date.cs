namespace EnricoApi
{
    public class Date
    {
        public Date(int day, int month, int year, int dayOfWeek)
        {
            Day = day;
            Month = month;
            Year = year;
            DayOfWeek = dayOfWeek;
        }

        public int Day { get; private set; }

        public int Month { get; private set; }

        public int Year { get; private set; }

        public int DayOfWeek { get; private set; }
    }
}
