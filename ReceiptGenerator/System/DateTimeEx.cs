namespace System
{
    public static class DateTimeEx
    {
        public static DateTime ToLastDate(this DateTime date)
        {
            int lastDay = DateTime.DaysInMonth(date.Year, date.Month);

            return new DateTime(date.Year, date.Month, lastDay);
        }
    }
}