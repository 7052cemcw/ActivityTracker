using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using ActivityTracker.Models;
using System.Threading.Tasks;

namespace ActivityTracker
{
    
    public class ActivityRepository
    {
        SQLiteAsyncConnection conn;
        public string StatusMessage { get; set; }

        /// <summary>
        /// Constructor to take database information and create the table if not present already.
        /// </summary>
        /// <param name="dbPath"></param>
        public ActivityRepository(string dbPath)
        {
            conn = new SQLiteAsyncConnection(dbPath);
            conn.CreateTableAsync<Activity>().Wait();
        }

        /// <summary>
        /// Method to add a new activity into the database. It takes the name and description of the activity.
        /// </summary>
        /// <param name="Aname"></param>
        /// <param name="Adesc"></param>
        /// <returns></returns>
         public async Task AddNewActivityAsync(string Aname, string Adesc)
         {
             int result = 0;
             try
             {
                 //basic validation to ensure a name was entered
                 if (string.IsNullOrEmpty(Aname))
                     throw new Exception("Valid name required");

                 result = await conn.InsertAsync(new Activity { ActivityName = Aname, ActivityDesc = Adesc });

                 StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, Aname);
             }
             catch (Exception ex)
             {
                 StatusMessage = string.Format("Failed to add {0}. Error: {1}", Aname, ex.Message);
             }
         }

        /// <summary>
        /// Method to fetch all activities from the database.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Activity>> GetAllActivitiesAsync()
        {
            try
            {
                return await conn.Table<Activity>().ToListAsync();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Activity>();
        }
    }
}
