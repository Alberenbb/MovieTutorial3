using Serenity;
using System;
using Hangfire;
namespace MovieTutorial3.Common.Jobs
{
    public class SimpleJob
    {

        // If you want to run SQL with a connection, add this
        // private readonly ISqlConnections Connections;
        // public SimpleJob(ISqlConnections connections) 
        // {
        //     this.Connections = connections ?? throw new ArgumentNullException(nameof(connections));
        // }

        public void Run()
        {
            BackgroundJob.Enqueue<Common.Jobs.SimpleJob>(job => job.Run());
            RecurringJob.AddOrUpdate<Common.Jobs.SimpleJob>(job => job.Run(), Cron.Hourly);
            RecurringJob.AddOrUpdate<Common.Jobs.SimpleJob>(job => job.Run(), "0 * * * *");
        }
    }
}