// --------------------------------------------------------------------------------------------------------------------
// <copyright company="brightman software studios" file="DbCommandExtension.cs">
//   Copyright © brightman software studios 2023. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.Common;

namespace SammelLastschriftGenerator
{    
    internal static class DbCommandExtensionon
    {
        /// <summary>
        /// Adds a new Parameter to the Command
        /// </summary>
        /// <param name="command">Command, whose Parameter should be added</param>
        /// <param name="parameterName">Name of the Parameter</param>
        /// <param name="value">Value of the Object-Parameter</param>
        public static void AddParameter(this DbCommand command, string parameterName, object value)
        {
            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;
            command.Parameters.Add(parameter);
        }

        /// <summary>
        /// Adds a new Parameter to the Command
        /// </summary>
        /// <param name="command">Command, whose Parameter should be added</param>
        /// <param name="parameterName">Name of the Parameter</param>
        /// <param name="value">Value of the DateTime-Parameter</param>
        public static void AddParameter(this DbCommand command, string parameterName, DateTime value)
        {
            DbParameter parameter = command.CreateParameter();
            parameter.DbType = DbType.DateTime;
            parameter.ParameterName = parameterName;
            parameter.Value = value;
            command.Parameters.Add(parameter);
        }

        /// <summary>
        /// Adds a new Parameter to the Command
        /// </summary>
        /// <param name="command">Command, whose Parameter should be added</param>
        /// <param name="parameterName">Name of the Parameter</param>
        /// <param name="value">Value of the Guid-Parameter</param>
        public static void AddParameter(this DbCommand command, string parameterName, Guid value)
        {
            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value.ToString();
            parameter.DbType = System.Data.DbType.String;
            command.Parameters.Add(parameter);
        }

        /// <summary>
        /// Adds a new Parameter to the Command
        /// </summary>
        /// <param name="command">Command, whose Parameter should be added</param>
        /// <param name="parameterName">Name of the Parameter</param>
        /// <param name="value">Value of the Byte-Parameter</param>
        public static void AddParameter(this DbCommand command, string parameterName, Byte[] value)
        {
            DbParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;
            parameter.DbType = System.Data.DbType.Binary;
            command.Parameters.Add(parameter);
        }
    }
}