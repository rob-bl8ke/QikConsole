using System;
using System.CommandLine;

namespace CygSoft.Qik.QikConsole
{
    using static System.Console;

    public enum CommandType
    {
        GenerateSimple,
        GenerateMatrix
    }

    public interface ICommandFactory
    {
        public Command Create(CommandType commandType);
    }

    public class CommandFactory : ICommandFactory
    {
        private readonly NLog.ILogger logger;
        private readonly IProjectFile projectFile;
        private readonly IFileFunctions fileFunctions;

        public CommandFactory(IProjectFile projectFile, IFileFunctions fileFunctions, NLog.ILogger logger)
        {
            this.logger = logger ?? throw new ArgumentNullException($"{nameof(logger)} cannot be null.");
            this.projectFile = projectFile ?? throw new ArgumentNullException($"{nameof(projectFile)} cannot be null.");
            this.fileFunctions = fileFunctions ?? throw new ArgumentNullException($"{nameof(fileFunctions)} cannot be null.");
        }

        public Command Create(CommandType commandType)
        {
            switch (commandType)
            {
                case CommandType.GenerateSimple:
                    return new GenerateSimpleCommand(projectFile, fileFunctions, logger).Configure();

                case CommandType.GenerateMatrix:
                    return new GenerateMatrixCommand(projectFile, fileFunctions, logger).Configure();
                
                default:
                    throw new NotImplementedException();
            }
        }
    }
}