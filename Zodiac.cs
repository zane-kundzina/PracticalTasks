using System;

namespace CSharp.Activity.Profile
{
    /// <summary>
    ///	Definition of Zodiac sign class.
    /// </summary>
    public class Zodiac
    {
        // Static instances of zodiacs signs
        public static Zodiac ARIES = new Zodiac(3, 21, 4, 19, "Aries");
        public static Zodiac TAURUS = new Zodiac(4, 20, 5, 20, "Taurus");
        public static Zodiac GEMINI = new Zodiac(5, 21, 6, 20, "Gemini");
        public static Zodiac CANCER = new Zodiac(6, 21, 7, 22, "Cancer");
        public static Zodiac LEO = new Zodiac(7, 23, 8, 22, "Leo");
        public static Zodiac VIRGO = new Zodiac(8, 23, 9, 22, "Virgo");
        public static Zodiac LIBRA = new Zodiac(9, 23, 10, 22, "Libra");
        public static Zodiac SCORPIO = new Zodiac(10, 23, 11, 21, "Scorpio");
        public static Zodiac SAGITTARIUS = new Zodiac(11, 22, 12, 21, "Sagittarius");
        public static Zodiac CAPRICORN = new Zodiac(12, 22, 1, 19, "Capricorn");
        public static Zodiac AQUARIUS = new Zodiac(1, 20, 2, 18, "Aquarius");
        public static Zodiac PISCES = new Zodiac(2, 19, 3, 20, "Pisces");


        /// <summary>
        /// Property to return the Start Date
        /// </summary>
        public int StartDate { get; private set; }


        /// <summary>
        /// Property to return the End Date
        /// </summary>
        public int EndDate { get; private set; }


        /// <summary>
        /// Property to return the Start Month
        /// </summary>
        public int StartMonth { get; private set; }


        /// <summary>
        /// Property to return the End Month
        /// </summary>
        public int EndMonth { get; private set; }


        /// <summary>
        /// Property to return the zodiac Star Sign name
        /// </summary>
        public string StarSign { get; private set; }


        /// <summary>
        /// Constructor to initialize the zodiac objects.
        /// </summary>
        /// <param name="startMonth">start month</param>
        /// <param name="startDate">start date</param>
        /// <param name="endMonth">end month</param>
        /// <param name="endDate">end date</param>
        /// <param name="starSign">zodiac star sign</param>
        private Zodiac(int startMonth, int startDate, int endMonth, int endDate, string starSign)
        {
            this.StartMonth = startMonth;
            this.StartDate = startDate;
            this.EndMonth = endMonth;
            this.EndDate = endDate;
            this.StarSign = starSign;
        }


        /// <summary>
        /// Method to accept the birth date and return the corresponding Zodiac sign
        /// </summary>
        /// <param name="birthDate">Birth Date</param>
        /// <returns></returns>
        public static Zodiac GetZodiacSign(DateTime birthDate)
        {

            #region Activity 1.1
            // TODO: Given the birth date, return the corresponding
            // zodiac sign or null if the date does not have a corresponding zodiac sign.
            // Refer to the constants above for the zodiac sign values.
            // You may declare additional local variables if necessary to accomplish this activity.
            // HINT: Make use of the 'return' keyword

            int month = birthDate.Month;  // month of birth
            int day = birthDate.Day;      // date of birth

            if (((month == ARIES.StartMonth) && (day >= ARIES.StartDate || day <= 31)) || 
                ((month == ARIES.EndMonth) && (day >= 01 || day <= ARIES.EndDate)))
            {
                return ARIES;
            }
            if (((month == TAURUS.StartMonth) && (day >= TAURUS.StartDate || day <= 30)) || 
                ((month == TAURUS.EndMonth) && (day >= 01 || day <= TAURUS.EndDate)))
            {
                return TAURUS;
            }
            if (((month == GEMINI.StartMonth) && (day >= GEMINI.StartDate || day <= 31)) || 
                ((month == GEMINI.EndMonth) && (day >= 01 || day <= GEMINI.EndDate)))
            {
                return GEMINI;
            }
            if (((month == CANCER.StartMonth) && (day >= CANCER.StartDate || day <= 30)) || 
                ((month == CANCER.EndMonth) && (day >= 01 || day <= CANCER.EndDate)))
            {
                return CANCER;
            }
            if (((month == LEO.StartMonth) && (day >= LEO.StartDate || day <= 31)) || 
                ((month == LEO.EndMonth) && (day >= 01 || day <= LEO.EndDate)))
            {
                return LEO;
            }
            if (((month == VIRGO.StartMonth) && (day >= VIRGO.StartDate || day <= 31)) || 
                ((month == VIRGO.EndMonth) && (day >= 01 || day <= VIRGO.EndDate)))
            {
                return VIRGO;
            }
            if (((month == LIBRA.StartMonth) && (day >= LIBRA.StartDate || day <= 31)) || 
                ((month == LIBRA.EndMonth) && (day >= 01 || day <= LIBRA.EndDate)))
            {
                return LIBRA;
            }
            if (((month == SCORPIO.StartMonth) && (day >= SCORPIO.StartDate || day <= 31)) || 
                ((month == SCORPIO.EndMonth) && (day >= 01 || day <= SCORPIO.EndDate)))
            {
                return SCORPIO;
            }
            if (((month == SAGITTARIUS.StartMonth) && (day >= SAGITTARIUS.StartDate || day <= 30)) || 
                ((month == SAGITTARIUS.EndMonth) && (day >= 01 || day <= SAGITTARIUS.EndDate)))
            {
                return SAGITTARIUS;
            }
            if (((month == CAPRICORN.StartMonth) && (day >= CAPRICORN.StartDate || day <= 31)) || 
                ((month == CAPRICORN.EndMonth) && (day >= 01 || day <= CAPRICORN.EndDate)))
            {
                return CAPRICORN;
            }
            if (((month == AQUARIUS.StartMonth) && (day >= AQUARIUS.StartDate || day <= 31)) || 
                ((month == AQUARIUS.EndMonth) && (day >= 01 || day <= AQUARIUS.EndDate)))
            {
                return AQUARIUS;
            }
            if (((month == PISCES.StartMonth) && (day >= PISCES.StartDate || day <= 31)) || 
                ((month == PISCES.EndMonth) && (day >= 01 || day <= PISCES.EndDate)))
            {
                return PISCES;
            }


            //:::

            #endregion

            return null; // default behaviour
        }
    }
}