using System;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;

namespace App.Console2
{

    public class Class1 : DbConfiguration, IDbCommandInterceptor
    {
        public Class1()
        {
            this.AddInterceptor(new DbCommandInterceptor());
        }

        public void NonQueryExecuted(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            LogInfo("NonQueryExecuted", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void NonQueryExecuting(DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            LogInfo("NonQueryExecuted", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            LogInfo("NonQueryExecuted", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            LogInfo("NonQueryExecuted", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void ScalarExecuted(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            LogInfo("NonQueryExecuted", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void ScalarExecuting(DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            LogInfo("NonQueryExecuted", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }


        private void LogInfo(string command, string commandText)
        {
            Console.WriteLine("Intercepted on: {0} :- {1} ", command, commandText);
        }
    }
}
